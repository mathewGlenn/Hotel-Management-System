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
    public partial class frmmessagebox1 : Form
    {
        public frmmessagebox1()
        {
            InitializeComponent();
        }
        static frmmessagebox1 MsgBox; static DialogResult result = DialogResult.No;
        public static DialogResult Show(string Text, string Caption, string btnokay)
        {
            MsgBox = new frmmessagebox1();
            MsgBox.lbldialog.Text = Text;
            MsgBox.btnokay.Text = btnokay;
            MsgBox.ShowDialog();
            return result;

        }
    
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnokay_Click(object sender, EventArgs e)
        {
            result = DialogResult.Yes;
            MsgBox.Close();
        }
    }
}
