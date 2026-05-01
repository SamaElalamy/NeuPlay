using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;

namespace NeuPlay
{
    public partial class OrderLevelControl : UserControl
    {
        private Control draggedNumber = null; // بيحفظ الرقم اللي الطفل بيسحبه
        private Random random = new Random();
        Score score = new Score();

        public OrderLevelControl()
        {
            InitializeComponent();
            SetupDragAndDrop();
            Theme.ApplyTheme(this);
        }

        private void SetupDragAndDrop()
        {
            // 1. تفعيل السحب للأرقام
            Control[] numbers = { lbl_Num1, lbl_Num2, lbl_Num3, lbl_Num4, lbl_Num5,lbl_Num6,lbl_Num7,lbl_Num8,lbl_Num9,lbl_Num10 };
            foreach (Control num in numbers)
            {
                num.MouseDown += Number_MouseDown; // لما يدوس عليه
            }

            // 2. تفعيل الاستقبال للمربعات الفاضية
            Control[] slots = { box_Slot1, box_Slot2, box_Slot3, box_Slot4, box_Slot5,box_Slot6,box_Slot7,box_Slot8,box_Slot9,box_Slot10 };
            foreach (Control slot in slots)
            {
                slot.AllowDrop = true; // يسمح إن حاجة تقع فيه
                slot.DragEnter += Slot_DragEnter; // لما الرقم يدخل جواه
                slot.DragDrop += Slot_DragDrop; // لما يسيب الرقم جواه
            }
        }


        private void Number_MouseDown(object sender, MouseEventArgs e)
        {
            draggedNumber = (Control)sender; // بنسجل إنه ده الرقم اللي بيتسحب
            draggedNumber.DoDragDrop(draggedNumber.Text, DragDropEffects.Move);
        }


        private void Slot_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                e.Effect = DragDropEffects.Move; // بيظهر علامة السحب
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }


        private void Slot_DragDrop(object sender, DragEventArgs e)
        {
            Control targetSlot = (Control)sender; // ده المربع الفاضي
            string textData = (string)e.Data.GetData(DataFormats.StringFormat);

            // لو المربع فاضي أو عاوز يبدل الرقم
            targetSlot.Text = textData;
            targetSlot.BackColor = Color.LightGreen; // بنلونه عشان يعرف إنه اتحط

            // بنخفي الرقم الأصلي كأنه اتنقل بجد
            if (draggedNumber != null)
            {
                draggedNumber.Visible = false;
            }
        }


        private void btn_Check_Click(object sender, EventArgs e)
        {
            bool iscorrect = box_Slot1.Text == "1" && box_Slot2.Text == "2" &&
                box_Slot3.Text == "3" && box_Slot4.Text == "4" && box_Slot5.Text == "5" &&
                box_Slot6.Text == "6" && box_Slot7.Text == "7" && box_Slot8.Text == "8" &&
                box_Slot9.Text == "9" && box_Slot10.Text == "10";

            if (iscorrect)
            {
                MessageBox.Show("مبروك! رتبت الأرقام بامتياز 🏆", "أنت عبقري", MessageBoxButtons.OK, MessageBoxIcon.Information);

                score.AddPoints("StairsLevel"); //استدعاء داله الاسكور
                MessageBox.Show("نقاطك: " + Score.points, "برافو🎉");

                Form1 parentForm = (Form1)this.FindForm();
                if (parentForm != null) parentForm.LoadScreen(new CompareLevelControl());
            }
            else
            {
                MessageBox.Show("الترتيب محتاج تركيز شوية، مين أصغر رقم؟", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetLevel(); //ميثود بترجع الارقام
            }
        }

        private void ResetLevel()
        {

            Control[] numbers = { lbl_Num1, lbl_Num2, lbl_Num3, lbl_Num4, lbl_Num5,
                                  lbl_Num6,lbl_Num7,lbl_Num8,lbl_Num9,lbl_Num10};
            foreach (Control num in numbers) num.Visible = true;

            Control[] slots = { box_Slot1, box_Slot2, box_Slot3, box_Slot4, box_Slot5,
                                box_Slot6, box_Slot7, box_Slot8, box_Slot9, box_Slot10};
            foreach (Control slot in slots) { slot.Text = ""; slot.BackColor = Color.LightGray; }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Form1 parentForm = (Form1)this.FindForm();
            if (parentForm != null)
            {
                parentForm.LoadScreen(new NumbersLand());
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}