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
    public partial class frmCheckout : Form
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost; Initial Catalog=HotelManagementSystem; User id=root; password=''");
        MySqlDataAdapter adapt;
        public frmCheckout()
        {
            InitializeComponent();
            DisplayData();
            ClearData();
        }
        string MyConnectionString = "Server=localhost; Database=HotelManagementSystem; Uid=root; PWD=;";

        private void frmViewCheckins_Load(object sender, EventArgs e)
        {
            loadTable();
        }
        public void loadTable()
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * from tbl_occupiedrooms";
            MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            dataGridCheckin.DataSource = ds.Tables[0].DefaultView;
            con.Close();
        }

        private void DisplayData()
        {
            DataTable dt = new DataTable();
            adapt = new MySqlDataAdapter("select * from tbl_occupiedrooms", con);
            adapt.Fill(dt);
            dataGridCheckin.DataSource = dt;
        }
        private void ClearData()
        {
            textBox1.Text = "";
            comboBox1.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            dateTimePicker2.Text = "";
            dateTimePicker3.Text = "";
            label4.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {

            MySqlConnection con = new MySqlConnection(MyConnectionString);
            MySqlCommand cmd;
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = @"INSERT INTO tbl_availablerooms(Room_ID, Room_Type, Room_Name, Person_No, Description, Rate_Per_Hour, Rate_Per_Day, Extra_Person_PH) VALUES (@id, @roomtype, @roomname, @personno, @description, @rph, @rpd, @epp);
                                   delete from tbl_occupiedrooms where Room_ID=" + textBox1.Text;
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            cmd.Parameters.AddWithValue("@roomtype", comboBox1.Text);
            cmd.Parameters.AddWithValue("@roomname", comboBox3.Text);
            cmd.Parameters.AddWithValue("@personno", comboBox4.Text);
            cmd.Parameters.AddWithValue("@description", lbldescription.Text);
            cmd.Parameters.AddWithValue("@rph", txtrph.Text);
            cmd.Parameters.AddWithValue("@rpd", txtrpd.Text);
            cmd.Parameters.AddWithValue("@epp", txtepp.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            frmmessagebox1.Show("Checkout Successful. Room " + comboBox3.Text + " is now available", "lbldialog", "Okay");
            this.Hide();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridCheckin_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridCheckin.Rows[e.RowIndex].Cells[0].Value.ToString();
            comboBox1.Text = dataGridCheckin.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBox3.Text = dataGridCheckin.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBox4.Text = dataGridCheckin.Rows[e.RowIndex].Cells[3].Value.ToString();
            lbldescription.Text = dataGridCheckin.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtrph.Text = dataGridCheckin.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtrpd.Text = dataGridCheckin.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtepp.Text = dataGridCheckin.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtvehicle.Text = dataGridCheckin.Rows[e.RowIndex].Cells[8].Value.ToString();
            dateTimePicker2.Text = dataGridCheckin.Rows[e.RowIndex].Cells[9].Value.ToString();
            dateTimePicker3.Text = dataGridCheckin.Rows[e.RowIndex].Cells[10].Value.ToString();
            textBox2.Text = dataGridCheckin.Rows[e.RowIndex].Cells[11].Value.ToString();
            label4.Text = dataGridCheckin.Rows[e.RowIndex].Cells[12].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCheckIn c = new frmCheckIn();
            c.ShowDialog();
        }

        private void frmCheckout_Activated(object sender, EventArgs e)
        {
         
        }

        private void numericUpDown1_Click(object sender, EventArgs e)
        {
           //   DateTime DateIn, DateOut;
           //  int TotalDays;
            int totalCost;
            int additional;
            //int val23;
            Int32 val1 = Convert.ToInt32(txtrph.Text);
            Int32 val2 = Convert.ToInt32(numericUpDown1.Text);
            Int32 val3 = Convert.ToInt32(label4.Text);
             Int32 val4 = Convert.ToInt32(txtrpd.Text);

           //   DateIn = Convert.ToDateTime(dateTimePicker2.Value);
            //   DateOut = Convert.ToDateTime(dateTimePicker3.Value);

            //  val23 = (val2 * val3);
             //TotalDays = (DateOut - DateIn).Days;
            {
                totalCost = (val1 * val2 + val3);
                label4.Text = Convert.ToString(totalCost);

                   additional = (val1*val2);
                   label13.Text = Convert.ToString(additional);

                 //  totalCost = (TotalDays * val4 +val3);
                 //  label4.Text = Convert.ToString(additional);
            }
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
          
        }

        private void numericUpDown2_Click(object sender, EventArgs e)
        {
           // DateTime DateIn, DateOut;
           // int TotalDays;
            int totalCost;
            int additional;
            //int val23;
          //  Int32 val1 = Convert.ToInt32(txtrp.Text);
            Int32 val2 = Convert.ToInt32(numericUpDown2.Text);
            Int32 val3 = Convert.ToInt32(label4.Text);
            Int32 val4 = Convert.ToInt32(txtrpd.Text);

          //  DateIn = Convert.ToDateTime(dateTimePicker2.Value);
          //  DateOut = Convert.ToDateTime(dateTimePicker3.Value);

            //  val23 = (val2 * val3);
           // TotalDays = (DateOut - DateIn).Days;
            {
                totalCost = (val4 * val2 + val3);
                label4.Text = Convert.ToString(totalCost);

                additional = (val4 * val2);
                label13.Text = Convert.ToString(additional);

              //  totalCost = (TotalDays * val4 + val3);
               // label4.Text = Convert.ToString(additional);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(MyConnectionString);
            MySqlCommand cmd;

            con.Open();
            cmd = new MySqlCommand("update tbl_occupiedrooms set Total_Amount=@total where Room_ID=@uid", con);
            cmd.Parameters.AddWithValue("@uid", textBox1.Text);
            cmd.Parameters.AddWithValue("@total", label4.Text);
           // cmd.Parameters.AddWithValue("@price", cmbperson.Text);
            cmd.ExecuteNonQuery();
            frmmessagebox.Show("Update successful,", "lbldialog", "OKAY");
            DisplayData();
            ClearData();
            con.Close();
        }
    }
}