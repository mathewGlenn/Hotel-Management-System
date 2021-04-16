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
    public partial class frmCheckIn : Form
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost; Initial Catalog=HotelManagementSystem; User id=root; password=''");
        public frmCheckIn()
        {
            InitializeComponent();
        }
        string ConnectionString = "Server=localhost; Database=HotelManagementSystem; Uid=root; PWD=;";
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain fl = new frmMain();
            fl.Show();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void frmCheckIn_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox4.Items.Clear();
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select Room_Type,Room_Name,Bed_Type from tbl_roomtypes";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["Room_Type"].ToString());
                comboBox2.Items.Add(dr["Room_Name"].ToString());
                comboBox4.Items.Add(dr["Bed_Type"].ToString());
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            frmCheckIn NewForm = new frmCheckIn();
            NewForm.Show();
            this.Dispose(false);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmViewCheckins fl = new frmViewCheckins();
            fl.Show();
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(ConnectionString);
            MySqlCommand cmd;
            con.Open();
            if (comboBox1.Text != "")
            {
                cmd = con.CreateCommand();
                cmd.CommandText = @"INSERT INTO tbl_checkin(Room_Type, Room_Name, Bed_Type, Person_No, Vehicle_Info,Checkin_Datetime,Checkout_Datetime,Total_Amount) VALUES (@roomtype, @roomname, @bedtype, @personno, @vehicle,@checkin,@checkout,@totalamount);
                              INSERT INTO tbl_occupiedroom (Room_Name, Checkin_Datetime, Checkout_Datetime) values (@roomname, @checkin, @checkout);
                                INSERT INTO tbl_allcheckin(Room_Type, Room_Name, Bed_Type, Person_No, Vehicle_Info,Checkin_Datetime,Checkout_Datetime,Total_Amount) VALUES (@roomtype, @roomname, @bedtype, @personno, @vehicle,@checkin,@checkout,@totalamount)";
                cmd.Parameters.AddWithValue("@roomtype", comboBox1.Text);
                cmd.Parameters.AddWithValue("@roomname", comboBox2.Text);
                cmd.Parameters.AddWithValue("@bedtype", comboBox4.Text);
                cmd.Parameters.AddWithValue("@@personno", numericUpDown1.Text);
                cmd.Parameters.AddWithValue("@vehicle", textBox2.Text);
                cmd.Parameters.AddWithValue("@checkin", indateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@checkout", outdateTimePicker2.Text);
                cmd.Parameters.AddWithValue("@totalamount", lbl_total.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Checkin Succsessfull");
            }
            else
            {
                MessageBox.Show("Please provide complete details");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            DateTime DateIn, DateOut;
            int TotalDays;
            int Single, Triple, Twin, totalCost;

            Single = 1000;
            Triple = 2000;
            Twin = 3000;

            DateIn = Convert.ToDateTime(indateTimePicker1.Value);
            DateOut = Convert.ToDateTime(outdateTimePicker2.Value);

            TotalDays = (DateOut - DateIn).Days;

            if (comboBox1.Text == "Single")
            {
                totalCost = (Single * TotalDays);
                lbl_total.Text = String.Format("\u20B1{0} ", totalCost);
            }

            if (comboBox1.Text == "Twin" )
            {
                 totalCost = (Twin * TotalDays);
                 lbl_total.Text = String.Format("\u20B1{0} ", totalCost);
            }

            if (comboBox1.Text == "Triple" )
            {
                 totalCost = (Triple * TotalDays);
                 lbl_total.Text = String.Format("\u20B1{0} ", totalCost);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(comboBox3.SelectedItem);
            int Single, Triple, Twin, totalCost;


            Single = 100;
            Triple = 300;
            Twin = 200;



            if (comboBox1.Text == "Single")
            {
                totalCost = (Single * quantity);
                lbl_total.Text = String.Format("\u20B1{0} ", totalCost);
            }

            if (comboBox1.Text == "Twin")
            {
                totalCost = (Twin * quantity);
                lbl_total.Text = String.Format("\u20B1{0} ", totalCost);
            }

            if (comboBox1.Text == "Triple")
            {
                totalCost = (Triple *quantity);
                lbl_total.Text = String.Format("\u20B1{0} ", totalCost);
            }
        }

        private void viewRoomTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmViewRoomType f1 = new frmViewRoomType();
            f1.Show();
        }

        private void reservationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReservations f1 = new frmReservations();
            f1.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_total_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
