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

        private void frmCheckIn_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();

            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select Room_Type,Room_Name from tbl_availablerooms order by Room_Type asc";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["Room_Name"].ToString());
                comboBox2.Items.Add(dr["Room_Type"].ToString());

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCheckout fl = new frmCheckout();
            fl.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(ConnectionString);
            MySqlCommand cmd;
            con.Open();
            if (comboBox1.Text != "")
            {

                cmd = con.CreateCommand();
                cmd.CommandText = @"INSERT INTO tbl_occupiedrooms(extra_person,Room_ID, Room_Type, Room_Name, Person_No, Description, Rate_Per_Hour, Rate_Per_Day, Extra_Person_PH, Vehicle_Info,Checkin,Checkout,orHour, Total_Amount) VALUES (@extraperson,@id,@roomtype, @roomname, @personno, @description,@rph, @rpd, @epp,@vehicle,@checkin,@checkout,@hour,@totalamount);
                                delete from tbl_availablerooms where Room_ID=@id;
                                INSERT INTO tbl_allcheckins (Room_ID, Room_Type, Room_Name, Person_No, Vehicle_Info,Checkin,Checkout,orHour, Total_Amount, Cash, Cash_Change) VALUES (@id,@roomtype, @roomname, @personno, @vehicle,@checkin,@checkout,@hour,@totalamount,@cash,@change)";
                cmd.Parameters.AddWithValue("@id", label6.Text);
                cmd.Parameters.AddWithValue("@roomtype", comboBox1.Text);
                cmd.Parameters.AddWithValue("@extraperson", numericUpDown1.Text);
                cmd.Parameters.AddWithValue("@roomname", comboBox2.Text);
                cmd.Parameters.AddWithValue("@personno", numericUpDown2.Text);
                cmd.Parameters.AddWithValue("@description", textBox1.Text);
                cmd.Parameters.AddWithValue("@rph", txtrph.Text);
                cmd.Parameters.AddWithValue("@rpd", txtrpd.Text);
                cmd.Parameters.AddWithValue("@epp", txtepp.Text);
                cmd.Parameters.AddWithValue("@vehicle", textBox2.Text);
                cmd.Parameters.AddWithValue("@checkin", indateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@checkout", outdateTimePicker2.Text);
                cmd.Parameters.AddWithValue("@hour", comboBox3.Text);
                cmd.Parameters.AddWithValue("@totalamount", lbl_total.Text);
                cmd.Parameters.AddWithValue("@cash", textBox3.Text);
                cmd.Parameters.AddWithValue("@change", lblchange.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                frmmessagebox.Show("Checkin Successfull","lbldialog", "OKAY");

                this.Hide();
                frmMain n = new frmMain();
                n.Invalidate();
                n.Refresh();
            }
            else
            {
                MessageBox.Show("Please provide complete details");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            DateTime DateIn, DateOut;
            Int32 TotalDays;
            Int32 totalCost;
            Int32 val23;
            Int32 val2ba;
            Int32 val1 = Convert.ToInt32(txtrpd.Text);
            Int32 val2a = Convert.ToInt32(numericUpDown1.Text);
            Int32 val2b = Convert.ToInt32(numericUpDown2.Text);
            Int32 val3 = Convert.ToInt32(txtepp.Text);

            DateIn = Convert.ToDateTime(indateTimePicker1.Value);
            DateOut = Convert.ToDateTime(outdateTimePicker2.Value);

            val2ba = (val2a + val2b);
            val23 = (val2ba * val3);
            TotalDays = (DateOut - DateIn).Days;
            {
                totalCost = (val1 * TotalDays + val23);
                lbl_total.Text = Convert.ToString( totalCost);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int hourrate = Convert.ToInt32(comboBox3.SelectedItem);
            int totalCost;
            int val23;
            Int32 val1 = Convert.ToInt32(txtrph.Text);
            Int32 val2 = Convert.ToInt32(numericUpDown1.Text);
            Int32 val3 = Convert.ToInt32(txtepp.Text);

            val23 = (val2 * val3);
            {
                totalCost = (val1 * hourrate + val23);
                lbl_total.Text = Convert.ToString(totalCost );
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            frmCheckout f1 = new frmCheckout();
            f1.ShowDialog();
            this.Hide();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox3.Text = textBox3.Text.Remove(textBox3.Text.Length - 1);
            }
            //label8.Text = textBox3.Text.Remove(label8.Text.Length - 1);

            int change;

            Int32 val1 = Convert.ToInt32(lbl_total.Text);
            Int32 val2 = Convert.ToInt32(textBox3.Text);
            {
                
                change = (val2 - val1);
                lblchange.Text = Convert.ToString(change +".00"); ;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from tbl_availablerooms where Room_Type='" + comboBox2.Text + "'; ";

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            MySqlDataReader myReader;
            try
            {

                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    string description = myReader.GetString("Description");
                    string type = myReader.GetString("Room_Type");
                    string roomname = myReader.GetString("Room_Name");
                    string roomid = myReader.GetString("Room_ID");
                    string rph = myReader.GetString("Rate_Per_Hour");
                    string rpd = myReader.GetString("Rate_Per_Day");
                    string epp = myReader.GetString("Extra_Person_PH");
                    string personno = myReader.GetString("Person_No");

                    numericUpDown2.Text = personno;
                    comboBox1.Text = type;
                    textBox1.Text = description;
                    label6.Text = roomid;
                    comboBox2.Text = roomname;
                    txtrph.Text = rph;
                    txtrpd.Text = rpd;
                    txtepp.Text = epp;
                }
                myReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
