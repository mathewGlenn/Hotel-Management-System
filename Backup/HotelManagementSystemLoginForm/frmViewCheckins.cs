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
    public partial class frmViewCheckins : Form
    {
        public frmViewCheckins()
        {
            InitializeComponent();
        }
        string MyConnectionString = "Server=localhost; Database=HotelManagementSystem; Uid=root; PWD=;";
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCheckIn fl = new frmCheckIn();
            fl.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmViewCheckins_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(MyConnectionString);
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * from tbl_checkin";
            MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            con.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(MyConnectionString);
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * from tbl_checkin";
            MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            con.Close();
        }
    }
}
