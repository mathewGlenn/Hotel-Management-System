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
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain fl = new frmMain();
            fl.Show();
        }
        private void frmViewRoomType_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(MyConnectionString);
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * from tbl_rooms";
            MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            this.dataGridView1.Columns["Room_Name"].Visible = false;
            this.dataGridView1.Columns["Person_No"].Visible = false;
            this.dataGridView1.Columns["uid"].Visible = false;
            dataGridView1.Columns["Room_Type"].HeaderText = "Room";
            con.Close();
        }
        private void button14_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            frmRoomDetails myForm = new frmRoomDetails();

            myForm.label10.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            myForm.label11.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            myForm.label14.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            myForm.label15.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            myForm.label16.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            myForm.label17.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            myForm.label18.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            myForm.label19.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();

            myForm.ShowDialog();
        }
    }
}
