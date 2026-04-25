namespace NeuPlay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
<<<<<<< HEAD

            Theme.ApplyTheme(this);
=======
>>>>>>> 63deea7cc78d739560ad602a8f17263d76851c80
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

        
        private void pnl_MainContent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
