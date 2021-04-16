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
    public partial class frmViewRoomType : Form
    {
        public frmViewRoomType()
        {
            InitializeComponent();
        }
        string MyConnectionString = "Server=localhost; Database=HotelManagementSystem; Uid=root; PWD=;";


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddRoomTypes fl = new frmAddRoomTypes();
            fl.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain fl = new frmMain();
            fl.Show();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                txtID.Text = row.Cells[0].Value.ToString();
               
            } 
        }

        private void button9_Click(object sender, EventArgs e)
        {
           
        }

        private void frmViewRoomType_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(MyConnectionString);
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * from tbl_roomtypes";
            MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            con.Close();
        }

        private void viewRoomTypesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddRoomTypes fl = new frmAddRoomTypes();
            fl.Show();
        }
    }
}
