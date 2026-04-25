namespace NeuPlay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void LoadScreen(UserControl newScreen)
        {
            pnl_MainContent.Controls.Clear();
            newScreen.Dock = DockStyle.Fill;
            pnl_MainContent.Controls.Add(newScreen);
            newScreen.BringToFront();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            LoadScreen(new StartControl());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 parent = (Form1)this.FindForm();
            if (parent != null)
            {
                parent.LoadScreen(new PrivacyPolicyControl());
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pnl_MainContent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
