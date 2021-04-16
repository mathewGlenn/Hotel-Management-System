using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmRoomDetails : Form
    {
        public frmRoomDetails()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmEditRoomType myForm = new frmEditRoomType();

            myForm.textBox6.Text = label10.Text.ToString();
            myForm.textBox1.Text = label11.Text.ToString();
         //   myForm.textBox2.Text = label14.Text.ToString();
            myForm.numericUpDown2.Text = label15.Text.ToString();
            myForm.richTextBox1.Text = label16.Text.ToString();
            myForm.textBox4.Text = label17.Text.ToString();
            myForm.textBox5.Text = label18.Text.ToString();
            myForm.textBox3.Text = label19.Text.ToString();

            this.Hide();
            myForm.ShowDialog();
        }
    }
}
