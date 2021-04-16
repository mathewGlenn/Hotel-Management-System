using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class frmEditRoomType : Form
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost; Initial Catalog=HotelManagementSystem; User id=root; password=''");
        public frmEditRoomType()
        {
            InitializeComponent();
           
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmViewRoomType fl = new frmViewRoomType();
            fl.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmViewRoomType fl = new frmViewRoomType();
            fl.Show();
        }

 
        private void button2_Click_2(object sender, EventArgs e)
        {
            frmEditRoomType NewForm = new frmEditRoomType();
            NewForm.Show();
            this.Dispose(false);

        }
        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain fl = new frmMain();
            fl.Show();
        }

        private void viewRoomTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEditRoomType f1 = new frmEditRoomType();
            f1.Show();
        }

        private void checkinsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCheckIn f1 = new frmCheckIn();
            f1.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;
            con.Open();
            cmd = new MySqlCommand("update tbl_availablerooms set Room_Type=@type,Person_No=@personno,Description=@description, Rate_Per_Hour=@rateperhour,Rate_Per_Day=@rateperday,Extra_Person_PH=@extraperson where Room_ID=" + textBox6.Text, con);
            cmd.Parameters.AddWithValue("@type", textBox1.Text);
            //cmd.Parameters.AddWithValue("@roomname", textBox2.Text);
            cmd.Parameters.AddWithValue("@personno", numericUpDown2.Text);
            cmd.Parameters.AddWithValue("@rateperhour", textBox3.Text);
            cmd.Parameters.AddWithValue("@rateperday", textBox4.Text);
            cmd.Parameters.AddWithValue("@extraperson", textBox5.Text);
            cmd.Parameters.AddWithValue("@description", richTextBox1.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            frmmessagebox.Show("Update successful,", "lbldialog", "OKAY");
        }

        private void pnl_AddRoom_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}