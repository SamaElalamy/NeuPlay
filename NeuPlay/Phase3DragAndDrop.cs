using System;
using System.Drawing;
using System.Windows.Forms;
//Making a delay between images
using System.Threading.Tasks;
using System.Diagnostics.Eventing.Reader;

namespace NeuPlay
{
    public partial class Phase3DragAndDrop : UserControl
    {
        private SpellQuestLevels gameManager = new SpellQuestLevels();
        private WordItem currentWord;
        private Control[] dragButtons;
        private Label[] dropSlots;
        private Users loggedInUser;

        public Phase3DragAndDrop(Users currentUser)
        {
            InitializeComponent();
            loggedInUser = currentUser;
            this.Load += Phase3DragAndDrop_Load;
        }

        private void Phase3DragAndDrop_Load(object sender, EventArgs e)
        {
            dragButtons = new Control[] { letter1, letter2, letter3, letter4 };

            dropSlots = new Label[] { label1, label2, label3, label4 };

            foreach (Control btn in dragButtons)
            {
                btn.MouseDown += DragButton_MouseDown;
            }

            foreach (Label slot in dropSlots)
            {
                slot.AllowDrop = true;
                slot.DragEnter += Slot_DragEnter;
                slot.DragDrop += Slot_DragDrop;
            }
            try
            {
                string path = Application.StartupPath + "\\SpellQuestData\\level2.txt";
                if (gameManager.StartLevel(path))
                {
                    if (gameManager.StartLevel(path))
                    {
                        progressBar1.Maximum = gameManager.NumberOfWord;
                        progressBar1.Value = 0;
                        UpdateScreen();
                    }
                    
                }
            }
            catch(Exception ex)
            { 
                    MessageBox.Show("This level is not available",ex.Message);
            }

            
            
        }

        public void UpdateScreen()
        {
            if (gameManager.IsLevelComplete())
            {
                PopUpManager.ShowMessage(true);
                MessageBox.Show($"Congratulations! your total score is: {gameManager.Score}");
                ScoreLabel.Text = (gameManager.CurrentIndex + 1).ToString() + "/" + gameManager.NumberOfWord.ToString();
                if (gameManager.CurrentIndex <= progressBar1.Maximum)
                {
                    progressBar1.Value = gameManager.CurrentIndex;
                }
                return;
            }

            currentWord = gameManager.GetCurrentWord();

            try
            {
                string DragAndDropPath= Application.StartupPath + "\\Images\\" + currentWord.OriginalWord + ".png";
                WordHintpic.Image = Image.FromFile(DragAndDropPath);
                WordHintpic.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch 
            {
                MessageBox.Show("File is not available");
            }

            for (int i = 0; i < dragButtons.Length; i++)
            {
                if (i < currentWord.ShuffledWord.Length)
                {
                    dragButtons[i].Text = currentWord.ShuffledWord[i].ToString().ToUpper();
                    dragButtons[i].Visible = true; 
                }
                else
                {
                    dragButtons[i].Visible = false;
                }
            }

            for (int i = 0; i < dropSlots.Length; i++)
            {
                dropSlots[i].Text = "";
                if (i < currentWord.OriginalWord.Length)
                    dropSlots[i].Visible = true;
                else
                    dropSlots[i].Visible = false;
            }
        }


        private void DragButton_MouseDown(object sender, MouseEventArgs e)
        {
            Control btn = (Control)sender;
            if (!string.IsNullOrEmpty(btn.Text))
            {
                btn.DoDragDrop(btn.Text, DragDropEffects.Copy);
            }
        }

        private void Slot_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void Slot_DragDrop(object sender, DragEventArgs e)
        {
            Label slot = (Label)sender;

            if (string.IsNullOrEmpty(slot.Text))
            {
                string droppedLetter = (string)e.Data.GetData(DataFormats.Text);
                slot.Text = droppedLetter; 

                foreach (Control btn in dragButtons)
                {
                    if (btn.Visible && btn.Text == droppedLetter)
                    {
                        btn.Visible = false;
                        break;
                    }
                }

                CheckWinCondition(); 
            }
        }

        //Checking words
        //Adding async to add a delay to the screen
        private async void CheckWinCondition()
        {
            string formedWord = "";
            int filledCount = 0;

            for (int i = 0; i < currentWord.OriginalWord.Length; i++)
            {
                if (!string.IsNullOrEmpty(dropSlots[i].Text))
                {
                    formedWord += dropSlots[i].Text;
                    filledCount++;
                }
            }

            
            if (filledCount == currentWord.OriginalWord.Length)
            {
                if (formedWord.ToUpper() == currentWord.OriginalWord.ToUpper())
                {
                    PopUpManager.ShowMessage(true);
                    //A 3 seconds' delay to allow the child to see the original word
                    await Task.Delay(1000);
                    gameManager.CheckAnswer(currentWord.MissingLetter);
                    if(gameManager.CurrentIndex>=gameManager.NumberOfWord)
                    {
                        Form1 parent = (Form1)this.FindForm();
                        if (parent != null)
                        {
                            parent.LoadScreen(new Phase4Dictation(loggedInUser));
                        }
                        return;
                    }
                    ScoreLabel.Text = (gameManager.CurrentIndex + 1).ToString() + "/" + gameManager.NumberOfWord.ToString();
                    if (gameManager.CurrentIndex <= progressBar1.Maximum)
                    {
                        progressBar1.Value = gameManager.CurrentIndex;
                    }
                    UpdateScreen();
                }
                else
                {
                    PopUpManager.ShowMessage(false);
                    await Task.Delay(1000);
                    UpdateScreen(); 
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 parent = (Form1)this.FindForm();
            if (parent != null)
            {
                parent.LoadScreen(new Phase4Dictation(loggedInUser));
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}