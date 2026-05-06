
using System;
using System.Drawing;  
using System.Windows.Forms;

namespace NeuPlay
{
    public partial class Phase1FlashCardControl : UserControl
    {
        private WordItem[] levelWords;
        private Users loggedInUser;

        //indicates the current word in the file
        private int currentIndex = 0;

        public Phase1FlashCardControl(Users currentUser)
        {
            InitializeComponent();
            loggedInUser = currentUser;
        }

        private void Phase1FlashCardControl_Load(object sender, EventArgs e)
        {
            LevelManager manager = new LevelManager();
            string path = Application.StartupPath + "\\SpellQuestData\\level1.txt";
            levelWords = manager.LoadLevel(path);
            ScoreLabel.Text = "1/" + levelWords.Length.ToString();
            DisplayCurrentCard();
            //progress bar
            progressBar1.Maximum= levelWords.Length;
            progressBar1.Value = 0;
        }

        private void DisplayCurrentCard()
        {
            WordItem currentWord = levelWords[currentIndex];
            WordPic.Image = Image.FromFile(currentWord.ImagesPath);
            MagicCardpic.Visible = true;
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if(MagicCardpic.Visible==true)
            {
                MessageBox.Show("Please flip the card");
                return;
            }
            if (levelWords != null)
            {
                currentIndex++;
                if (currentIndex >= levelWords.Length)
                {
                    currentIndex = 0;
                    Form1 parent = (Form1)this.FindForm();
                    if (parent != null)
                    {
                        parent.LoadScreen(new Phase2FillinTheBlanks(loggedInUser));
                    }
                }
                else
                {
                    DisplayCurrentCard();
                    ScoreLabel.Text = (currentIndex + 1).ToString() + "/" + levelWords.Length.ToString();
                    if(levelWords.Length<=progressBar1.Maximum)
                    {
                        progressBar1.Value = currentIndex;
                    }
                }

            }
        }
        private void revealbtn_Click(object sender, EventArgs e)
        {
            MagicCardpic.Visible = false;

            WordPic.Visible = true;
        }
    }
}
