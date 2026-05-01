using System;
using System.Drawing;
using System.Windows.Forms;


namespace NeuPlay
{
    
    public partial class Phase2FillinTheBlanks : UserControl
    {
        private SpellQuestLevels gameManager = new SpellQuestLevels();

        public Phase2FillinTheBlanks()
        {
            InitializeComponent();
            this.Load += Phase2FillinTheBlanks_Load;
        }

        private void Phase2FillinTheBlanks_Load(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\SpellQuestData\\level4.txt";

            try
            {
                if (gameManager.StartLevel(path))
                {
                    progressBar1.Maximum = gameManager.NumberOfWord;
                    progressBar1.Value = 0;

                    UpdateScreen();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to load file!" + ex.Message);
            }
        }

        private void UpdateScreen()
        {
            if (gameManager.IsLevelComplete())
            {
                PopUpManager.ShowMessage(true);
                Form1 parent = (Form1)this.FindForm();
                if (parent != null)
                {
                    parent.LoadScreen(new Phase3DragAndDrop());
                }
                return;
            }
            ScoreLabel.Text = (gameManager.CurrentIndex + 1).ToString() + "/" + gameManager.NumberOfWord.ToString();
            if (gameManager.CurrentIndex <= progressBar1.Maximum)
            {
                progressBar1.Value = gameManager.CurrentIndex;
            }

            WordItem current = gameManager.GetCurrentWord();

            DrawWordBoxes(current);

            SetupButtons(current.MissingLetter);
        }

        private void DrawWordBoxes(WordItem current)
        {
            flowLayoutPanel1.Controls.Clear();
            bool isBlankDrawn = false;

            foreach (char c in current.OriginalWord)
            {
                Label lbl = new Label();
                lbl.AutoSize = false;
                lbl.Size = new Size(80, 80);
                lbl.BackColor = ColorTranslator.FromHtml("#b79af8");
                lbl.ForeColor = ColorTranslator.FromHtml("#ffd35b");
                lbl.BorderStyle = BorderStyle.FixedSingle;
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                lbl.Font = new Font("Arial", 28, FontStyle.Bold);
                lbl.Margin = new Padding(10);

                if (Char.ToUpper(c) == Char.ToUpper(current.MissingLetter) && !isBlankDrawn)
                {
                    lbl.Text = ".....";
                    lbl.ForeColor = Color.White;
                    isBlankDrawn = true;

                }
                else
                {
                    lbl.Text = c.ToString().ToUpper();
                    lbl.ForeColor = Color.Black;
                }

                flowLayoutPanel1.Controls.Add(lbl);
            }
        }
        private void SetupButtons(char correctLetter)
        {
            Button[] btns = { btn_Choice1, btn_Choice2, btn_Choice3, btn_Choice4 };
            Random rand = new Random();
            int correctIndex = rand.Next(0, 4);

            for (int i = 0; i < 4; i++)
            {
                if (i == correctIndex)
                {
                    btns[i].Text = correctLetter.ToString().ToUpper();

                }
                else
                {

                    char randomLetter;
                    do
                    {
                        randomLetter = (char)rand.Next('A', 'Z' + 1);
                    } while (randomLetter == Char.ToUpper(correctLetter));

                    btns[i].Text = randomLetter.ToString();
                }


                btns[i].Click -= ChoiceButton_Click;
                btns[i].Click += ChoiceButton_Click;
            }
        }


        private void ChoiceButton_Click(object sender, EventArgs e)
        {
            Button clickedBtn = (Button)sender;
            char childAnswer = clickedBtn.Text[0];

            if (gameManager.CheckAnswer(childAnswer))
            {

                UpdateScreen();

            }
            else
            {
                PopUpManager.ShowMessage(false);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 parent = (Form1)this.FindForm();
            if (parent != null)
            {
                parent.LoadScreen(new Phase3DragAndDrop());
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


 
