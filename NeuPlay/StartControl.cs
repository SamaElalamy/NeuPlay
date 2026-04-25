using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuPlay
{
    public partial class StartControl : UserControl
    {
        public StartControl()
        {
            InitializeComponent();

            Theme.ApplyTheme(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 parent = (Form1)this.FindForm();
            if (parent != null)
            {
                parent.LoadScreen(new PrivacyPolicyControl());
            }

        }
    }
}
