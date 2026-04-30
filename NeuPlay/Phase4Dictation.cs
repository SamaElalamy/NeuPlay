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
        public Phase4Dictation()
        {
            InitializeComponent();
            this.Load += Phase4Dictation_Load;
        }

        private void Phase4Dictation_Load(object sender, EventArgs e)
        {
            
            string path = Application.StartupPath + "\\SpellQuestData\\level5.txt";

            if (gameManager.StartLevel(path))
            {
                UpdateScreen();
            }
            else
            {
                MessageBox.Show("مش قادرين نحمل ملف الكلمات!");
            }
        }

        private void UpdateScreen()
        {
            if (gameManager.IsLevelComplete())
            {
                MessageBox.Show($"عاش يا بطل! خلصت المستوى والسكور بتاعك: {gameManager.Score}");
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

            // 2. تفريغ مربع النص عشان الطفل يكتب الكلمة الجديدة
            InputWordtxtbox.Text = "";
            InputWordtxtbox.Focus();

        }
        // بنخلي مؤشر الكتابة يقف جوه المربع أوتوماتيك عشان الطفل ميتعبش


        // كود زرار Check (اربطيه بحدث الـ Click للزرار الأزرق عندك)
        private void Checkbtn_Click(object sender, EventArgs e)
        {
            // بناخد الكلمة اللي الطفل كتبها ونشيل أي مسافات زيادة
            string childAnswer = InputWordtxtbox.Text.Trim();

            // بنقارن إجابة الطفل بالكلمة الأصلية (OriginalWord) 
            // واستخدمنا IgnoreCase عشان لو الطفل كتب كابيتال أو سمول تطلعله صح
            if (childAnswer.Equals(currentWord.OriginalWord, StringComparison.OrdinalIgnoreCase))
            {
                PopUpManager.ShowMessage(true);
                gameManager.CheckAnswer(currentWord.MissingLetter);
                if (gameManager.CurrentIndex >= gameManager.NumberOfWord)
                {
                    Form1 parent = (Form1)this.FindForm();
                    if (parent != null)
                    {
                        parent.LoadScreen(new ServicesScreenControl());
                    }
                    return;
                }
                ScoreLabel.Text = (gameManager.CurrentIndex + 1).ToString() + "/" + gameManager.NumberOfWord.ToString();
                // الخدعة: بنبعت للمدير الحرف الناقص بتاع الكلمة دي عشان يزود السكور وينقلنا عاللي بعدها
                UpdateScreen();
            }
            else
            {
                PopUpManager.ShowMessage(false);
                InputWordtxtbox.Text = ""; // بنفضي المربع عشان يكتب من الأول
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