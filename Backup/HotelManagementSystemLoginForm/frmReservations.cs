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
    public partial class frmReservations : Form
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost; Initial Catalog=HotelManagementSystem; User id=root; password=''");
        public frmReservations()
        {
            InitializeComponent();
        }
        string ConnectionString = "Server=localhost; Database=HotelManagementSystem; Uid=root; PWD=;";

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain fl = new frmMain();
            fl.Show();
        }

       
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmShowReservations fl = new frmShowReservations();
            fl.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string payment = string.Empty;
            if (rbfull.Checked)
            {
                payment = "Fully Paid";
            }
            else if (rbdown.Checked)
            {
                payment = "Half Paid";
            }
            if (txtCustomerName.Text != "")
            {
                MySqlConnection con = new MySqlConnection(ConnectionString);
                MySqlCommand cmd;
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO tbl_reservation (Customer_Name,Room_Type,Bed_Type, Room_Name,No_Person, Booking_Date, Checkin_Date,CheckOut_Date, Total_Amount, Down_Payment, Payment_Type) VALUES (@customername,@roomtype,@bedtype, @roomname,@noperson,@booking,@checkin,@checkout,@total, @down,@paymenttype)";
                cmd.Parameters.AddWithValue("@customername", txtCustomerName.Text);
                cmd.Parameters.AddWithValue("@roomtype", comboBox1.Text);
                cmd.Parameters.AddWithValue("@bedtype", comboBox3.Text);
                cmd.Parameters.AddWithValue("@roomname", comboBox2.Text);
                cmd.Parameters.AddWithValue("@noperson", numericUpDown1.Text);
                cmd.Parameters.AddWithValue("@booking", dateTimePicker2.Text);
                cmd.Parameters.AddWithValue("@checkin", dateCheckin.Text);
                cmd.Parameters.AddWithValue("@checkout", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@total",label8.Text);
                cmd.Parameters.AddWithValue("@down", label12.Text);
                cmd.Parameters.AddWithValue("@paymenttype", payment);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Room Reservation Succesfull");
            }
            else
            {
                MessageBox.Show("Please provide complete details");
            }

        }

        private void frmReservations_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select Room_Type,Room_Name, Bed_Type from tbl_roomtypes";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["Room_Type"].ToString());
                comboBox2.Items.Add(dr["Room_Name"].ToString());
                comboBox3.Items.Add(dr["Bed_Type"].ToString());

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmReservations NewForm = new frmReservations();
            NewForm.Show();
            this.Dispose(false);
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

        private void viewRoomTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void availableRoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void checkinsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reservationsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime DateIn, DateOut;
            int TotalDays;
            int Single, Triple, Twin, totalCost;

            Single = 1000;
            Triple = 2000;
            Twin = 3000;

            DateIn = Convert.ToDateTime(dateCheckin.Value);
            DateOut = Convert.ToDateTime(dateTimePicker1.Value);

            TotalDays = (DateOut - DateIn).Days;

            if (comboBox1.Text == "Single")
            {
                totalCost = (Single * TotalDays);
                label8.Text = String.Format("\u20B1{0} ", totalCost);
                totalCost = (Single * TotalDays /2);
                label12.Text = String.Format("\u20B1{0} ", totalCost);
            }

            if (comboBox1.Text == "Twin" )
            {
                 totalCost = (Twin * TotalDays);
                 label8.Text = String.Format("\u20B1{0} ", totalCost);
                 totalCost = (Single * TotalDays / 2);
                 label12.Text = String.Format("\u20B1{0} ", totalCost);
            }

            if (comboBox1.Text == "Triple" )
            {
                 totalCost = (Triple * TotalDays);
                 label8.Text = String.Format("\u20B1{0} ", totalCost);
                 totalCost = (Single * TotalDays / 2);
                 label12.Text = String.Format("\u20B1{0} ", totalCost);
            }
        }
        
        }
    }
