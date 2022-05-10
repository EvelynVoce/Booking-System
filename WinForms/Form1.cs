using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class Form1 : Form
    {
        private Rectangle bttnOriginalRectangle;
        private Rectangle titleOriginalRectangle;
        private Rectangle surgeryOriginalRectangle;
        private Rectangle doctorOriginalRectangle;
        private Rectangle dateOriginalRectangle;
        private Rectangle originalFormSize;
        private Rectangle lblSurgerySize;
        private Rectangle lblDoctorSize;
        private Rectangle lblDateSize;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_hello_Click(object sender, EventArgs e)
        {
            string chosenSurgery = surgeryDrop.Text;
            string chosenDoctor = doctorDrop.Text;

            Console.WriteLine(chosenSurgery);
            Console.WriteLine(chosenDoctor + "\n");

        }

        private void resizeControl(Rectangle r, Control c)
        {
            float xRatio = (float)(this.Width) / (float)(originalFormSize.Width);
            float yRatio = (float)(this.Height) / (float)(originalFormSize.Height);

            int newX = (int)(r.Location.X * xRatio);
            int newY = (int)(r.Location.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            resizeControl(bttnOriginalRectangle, btn_hello);
            resizeControl(titleOriginalRectangle, lbl_title);
            resizeControl(dateOriginalRectangle, dateTimePicker1);
            resizeControl(surgeryOriginalRectangle, surgeryDrop);
            resizeControl(doctorOriginalRectangle, doctorDrop);
            resizeControl(lblSurgerySize, lblSurgery);
            resizeControl(lblDoctorSize, lblDoctor);
            resizeControl(lblDateSize, lblDate);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Width, this.Height);
            bttnOriginalRectangle = new Rectangle(btn_hello.Location.X, btn_hello.Location.Y, btn_hello.Width, btn_hello.Height);
            titleOriginalRectangle = new Rectangle(lbl_title.Location.X, lbl_title.Location.Y, lbl_title.Width, lbl_title.Height);
            dateOriginalRectangle = new Rectangle(dateTimePicker1.Location.X, dateTimePicker1.Location.Y, dateTimePicker1.Width, dateTimePicker1.Height);
            surgeryOriginalRectangle = new Rectangle(surgeryDrop.Location.X, surgeryDrop.Location.Y, surgeryDrop.Width, surgeryDrop.Height);
            doctorOriginalRectangle = new Rectangle(doctorDrop.Location.X, doctorDrop.Location.Y, doctorDrop.Width, doctorDrop.Height);

            lblSurgerySize = new Rectangle(lblSurgery.Location.X, lblSurgery.Location.Y, lblSurgery.Width, lblSurgery.Height);
            lblDoctorSize = new Rectangle(lblDoctor.Location.X, lblDoctor.Location.Y, lblDoctor.Width, lblDoctor.Height);
            lblDateSize = new Rectangle(lblDate.Location.X, lblDate.Location.Y, lblDate.Width, lblDate.Height);
        }
    }
}
