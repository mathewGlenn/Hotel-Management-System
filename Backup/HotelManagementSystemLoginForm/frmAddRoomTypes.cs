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
    public partial class frmAddRoomTypes : Form
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost; Initial Catalog=HotelManagementSystem; User id=root; password=''");
        public frmAddRoomTypes()

        {
            InitializeComponent();
        }
        string ConnectionString = "Server=localhost; Database=HotelManagementSystem; Uid=root; PWD=;";

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

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

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            MySqlConnection con = new MySqlConnection(ConnectionString);
            MySqlCommand cmd;
            con.Open();
            if (textBox1.Text != "")
            {
                cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO tbl_roomtypes (Room_Type,Room_Name,Person_No, Bedroom_No, Bed_Type, Rate_Per_Hour,Rate_Per_Day,Extra_Person_PH, Description) VALUES (@roomtype, @roomname, @personno, @bedroomno,@bedtype,@description,@rateperhour,@rateperday,@extraperson)";
                cmd.Parameters.AddWithValue("@roomtype", textBox1.Text);
                cmd.Parameters.AddWithValue("@roomname", textBox2.Text);
                cmd.Parameters.AddWithValue("@@personno", numericUpDown2.Text);
                cmd.Parameters.AddWithValue("@bedroomno", numericUpDown3.Text);
                cmd.Parameters.AddWithValue("@bedtype", comboBox1.Text);
                cmd.Parameters.AddWithValue("@rateperhour", textBox3.Text);
                cmd.Parameters.AddWithValue("@rateperday", textBox4.Text);
                cmd.Parameters.AddWithValue("@extraperson", textBox5.Text);
                cmd.Parameters.AddWithValue("@description", richTextBox1.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Room Type Added Succsessfully");
            }
            else
            {
                MessageBox.Show("Please provide complete details");
            }
            }

        private void frmAddRoomTypes_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            frmAddRoomTypes NewForm = new frmAddRoomTypes();
            NewForm.Show();
            this.Dispose(false);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain fl = new frmMain();
            fl.Show();
        }

        private void roomTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewRoomTypesToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void viewRoomTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddRoomTypes f1 = new frmAddRoomTypes();
            f1.Show();
        }

        private void checkinsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
           frmCheckIn f1 = new frmCheckIn();
            f1.Show();
        }

        private void reservationsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        }
            }
