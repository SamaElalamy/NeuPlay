using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace NeuPlay
{
    internal class Theme
    {

        public static class Palette
        {
            public static Color Background = ColorTranslator.FromHtml("#F9EBF9");
            public static Color PrimaryBlue = ColorTranslator.FromHtml("#5B7FFF");
            public static Color FunYellow = ColorTranslator.FromHtml("#FFD35B");
            public static Color MainPurple = ColorTranslator.FromHtml("#9B6FFF");
            public static Color Text = Color.FromArgb(40, 40, 40);

        }



        public static void ApplyTheme(Control screen)
        {
            screen.BackColor = Palette.Background;




            foreach (Control c in screen.Controls)
            {

                if (c is Guna2TextBox txt)
                {
                    txt.BorderRadius = 15;
                    txt.BorderColor = Color.LightGray;
                    txt.FocusedState.BorderColor = Palette.PrimaryBlue;
                    txt.FillColor = Color.White;
                    txt.ForeColor = Color.Black;
                    txt.Font = new Font("Segoe UI", 12);

                    txt.Font = new Font("Segoe UI", 12);
                }


                if (c is Guna2Button button)
                {
                    button.FillColor = Palette.PrimaryBlue;
                    button.ForeColor = Color.White;
                    button.BorderRadius = 15;
                    button.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                }


                if (c is Guna2ComboBox combo)
                {
                    combo.BorderRadius = 15;
                    combo.FocusedState.BorderColor = Palette.PrimaryBlue;
                }


                if (c.HasChildren)
                {
                    ApplyTheme(c);
                }

            }

        }
    }





}