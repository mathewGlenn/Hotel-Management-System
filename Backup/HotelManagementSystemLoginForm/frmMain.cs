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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        string ConnectionString = "Server=localhost; Database=HotelManagementSystem; Uid=root; PWD=;";

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
  
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(ConnectionString);
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * from tbl_checkin";
            MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            con.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           this.Hide();
            frmCheckIn fl = new frmCheckIn();
            fl.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReservations fl = new frmReservations();
            fl.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void viewRoomTypesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddRoomTypes fl = new frmAddRoomTypes();
            fl.Show();
        }

        private void viewRoomTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           this.Hide();
            frmViewRoomType fl = new frmViewRoomType();
            fl.Show();
        }

        private void fileToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
                Application.Exit();
        }

        private void frmclosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain f1 = new frmMain();
            f1.Show();
        }

        private void availableRoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
                
        }

        private void reservationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmShowReservations f1 = new frmShowReservations();
            f1.Show();

        }

        private void availableRoomsToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
                this.Hide();
                frmLogin fl = new frmLogin();
                fl.Show();
            }

        private void showCheckinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmViewCheckins f1 = new frmViewCheckins();
            f1.Show();
        }
        }
        }
        
        
