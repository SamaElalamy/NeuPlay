using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace NeuPlay
{
    public class Theme
    {
        //دي باليت الالوان اللي هنستخدمها
        public static class Palette
        {
            public static Color Background = ColorTranslator.FromHtml("#F9EBF9"); //وردي
            public static Color PrimaryBlue = ColorTranslator.FromHtml("#5B7FFF"); //ازرق
            public static Color FunYellow = ColorTranslator.FromHtml("#FFD35B"); //اصفر
            public static Color MainPurple = ColorTranslator.FromHtml("#9B6FFF"); //بربل
            public static Color Text = Color.FromArgb(40, 40, 40); //لون التيكست رمادي غامق

        }

        public static void ApplyTheme(Control screen)
        {
            screen.BackColor = Palette.Background;

            foreach (Control c in screen.Controls)
            {
                //خانات التيكست(Guna2)
                if (c is Guna2TextBox txt)
                {
                    txt.BorderRadius = 15;
                    txt.BorderColor = Color.LightGray;
                    txt.FocusedState.BorderColor = Palette.PrimaryBlue;
                    txt.FillColor = Color.White;
                    txt.ForeColor = Color.Black;
                    txt.Font = new Font("Segoe UI", 12);
                }

                //الازرار(Guna2)
                if (c is Guna2Button button)
                {
                    button.FillColor = Palette.PrimaryBlue;
                    button.ForeColor = Color.White;
                    button.BorderRadius = 15;
                    button.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                }

                //دي للقائمه زي بتاعت العمر
                if(c is Guna2ComboBox combo)
                {
                    combo.BorderRadius = 10;
                    combo.FocusedState.BorderColor= Palette.PrimaryBlue;
                }

                if (c.HasChildren)
                {
                    ApplyTheme(c);
                }

            }

        }
    }





}