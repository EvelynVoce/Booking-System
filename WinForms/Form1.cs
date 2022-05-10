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
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_hello_Click(object sender, EventArgs e)
        {
            lbl_title.Text = "WOW YOU PRESSED MY BUTTONS!";
        }
    }
}
