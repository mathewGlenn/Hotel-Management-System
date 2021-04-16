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
    public partial class frmShowReservations : Form
    {
        public frmShowReservations()
        {
            InitializeComponent();
        }

        string MyConnectionString = "Server=localhost; Database=HotelManagementSystem; Uid=root; PWD=;";
        MySqlConnection con;
        MySqlDataAdapter adapt;
        DataTable dt;   

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain fl = new frmMain();
            fl.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReservations fl = new frmReservations();
            fl.Show();
        }

        private void frmShowReservations_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(MyConnectionString);
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * from tbl_reservation";
            MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            dataGridReservation.DataSource = ds.Tables[0].DefaultView;
            con.Close();
        }
        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain fl = new frmMain();
            fl.Show();
        }

        private void viewRoomTypesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddRoomTypes fl = new frmAddRoomTypes();
            fl.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            con = new MySqlConnection(MyConnectionString);
            con.Open();
            adapt = new MySqlDataAdapter("select * from tbl_reservation where Customer_Name like '" + txtSearch.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridReservation.DataSource = dt;
            con.Close();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(MyConnectionString);
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * from tbl_reservation";
            MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            dataGridReservation.DataSource = ds.Tables[0].DefaultView;
            con.Close();
        }

        private void dataGridReservation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            frmCheckinreserve myForm = new frmCheckinreserve();

            myForm.label10.Text = dataGridReservation.CurrentRow.Cells[2].Value.ToString();
            myForm.label11.Text = dataGridReservation.CurrentRow.Cells[3].Value.ToString();
            myForm.label12.Text = dataGridReservation.CurrentRow.Cells[4].Value.ToString();
            myForm.label14.Text = dataGridReservation.CurrentRow.Cells[5].Value.ToString();
            myForm.label15.Text = dataGridReservation.CurrentRow.Cells[6].Value.ToString();
            myForm.label16.Text = dataGridReservation.CurrentRow.Cells[7].Value.ToString();
            myForm.label17.Text = dataGridReservation.CurrentRow.Cells[8].Value.ToString();
            myForm.label18.Text = dataGridReservation.CurrentRow.Cells[9].Value.ToString();
            myForm.label19.Text = dataGridReservation.CurrentRow.Cells[10].Value.ToString();

            myForm.ShowDialog();
        }
    }
}
