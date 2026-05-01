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

        }
    }





}