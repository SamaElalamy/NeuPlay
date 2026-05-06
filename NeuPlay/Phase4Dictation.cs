using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NeuPlay
{
    public partial class Phase4Dictation : UserControl
    {
        private SpellQuestLevels gameManager = new SpellQuestLevels();
        private WordItem currentWord;
        private Users loggedInUser;
        public Phase4Dictation(Users currentUser)
        {
            InitializeComponent();
            loggedInUser = currentUser;
            this.Load += Phase4Dictation_Load;
        }

        private void Phase4Dictation_Load(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\SpellQuestData\\level5.txt";

            if (gameManager.StartLevel(path))
            {
                
                progressBar1.Maximum = gameManager.NumberOfWord;
                progressBar1.Value = 0;

                UpdateScreen();
            }
            else
            {
                MessageBox.Show("File is not available!");
            }
        }

        private void UpdateScreen()
        {
            if (gameManager.IsLevelComplete())
            {
                MessageBox.Show($"عاش يا بطل! خلصت المستوى والسكور بتاعك: {gameManager.Score}");
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
                
                string cleanImagePath = Application.StartupPath + "\\DictationImages\\" + currentWord.OriginalWord + ".png";

                HintPic.Image = Image.FromFile(cleanImagePath);
                HintPic.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch { }

            
            InputWordtxtbox.Text = "";
            InputWordtxtbox.Focus();

        }
        


        
        private void Checkbtn_Click(object sender, EventArgs e)
        {
            string childAnswer = InputWordtxtbox.Text.Trim();

            if (childAnswer.Equals(currentWord.OriginalWord, StringComparison.OrdinalIgnoreCase))
            {
                PopUpManager.ShowMessage(true);

                gameManager.CheckAnswer(currentWord.MissingLetter);

                if (gameManager.CurrentIndex >= gameManager.NumberOfWord)
                {
                    Form1 parent = (Form1)this.FindForm();
                    if (parent != null)
                    {
                        
                        parent.LoadScreen(new ServicesScreenControl(loggedInUser));
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
                InputWordtxtbox.Text = ""; 
                InputWordtxtbox.Focus();
            }
        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void InputWordtxtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}