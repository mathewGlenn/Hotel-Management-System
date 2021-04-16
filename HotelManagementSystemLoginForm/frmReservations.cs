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

        string connectionstring = "server=localhost; database=HotelManagementSystem; uid=root;password=;";
        private void button1_Click(object sender, EventArgs e)
        {
            {
                DialogResult dr = MessageBox.Show("Please Confirm Reservation", "", MessageBoxButtons.YesNo, MessageBoxIcon.None);
                if (dr == DialogResult.Yes)
                {
                    string payment = string.Empty;
                    if (rbfull.Checked)
                    {
                        payment = "Fully Paid";
                        label12.Text = "0";
                    }
                    else if (rbdown.Checked)
                    {
                        payment = "Half Paid";
                    }
                    if (txtCustomerName.Text != "")
                    {
                        MySqlConnection con = new MySqlConnection(connectionstring);
                        MySqlCommand cmd;
                        con.Open();
                        cmd = con.CreateCommand();
                        cmd.CommandText = @"INSERT INTO tbl_reservation (Room_ID, Customer_Name, Room_Name,No_Person, Booking_Date, Checkin_Date,CheckOut_Date, Total_Amount, Down_Payment, Payment_Type, Description, Rate_Per_Hour, Rate_Per_Day, Rate_Per_Extra_PH,Checkin_Time, Checkout_Time) VALUES (@roomid, @customername, @roomname,@noperson,@booking,@checkin,@checkout,@total, @down,@paymenttype, @description, @rph, @rpd, @epp,@timein,@timeout);
                                    INSERT INTO tbl_reservationhistory (Customer_Name, Room_Name,No_Person, Booking_Date, Checkin_Date,CheckOut_Date, Total_Amount, Down_Payment, Payment_Type) VALUES (@customername, @roomname,@noperson,@booking,@checkin,@checkout,@total, @down,@paymenttype)";
                        cmd.Parameters.AddWithValue("@roomid", lblroomid.Text);
                        cmd.Parameters.AddWithValue("@customername", txtCustomerName.Text);
                        cmd.Parameters.AddWithValue("@roomtype", cmbroomtype.Text);
                        cmd.Parameters.AddWithValue("@description", lbldescription.Text);
                        cmd.Parameters.AddWithValue("@rph", txtrph.Text);
                        cmd.Parameters.AddWithValue("@rpd", txtrpd.Text);
                        cmd.Parameters.AddWithValue("@epp", txtepp.Text);
                        cmd.Parameters.AddWithValue("@roomname", comboBox2.Text);
                        cmd.Parameters.AddWithValue("@noperson", numericUpDown1.Text);
                        cmd.Parameters.AddWithValue("@booking", dateTimePicker2.Text);
                        cmd.Parameters.AddWithValue("@checkin", dateCheckin.Text);
                        cmd.Parameters.AddWithValue("@checkout", dateTimePicker1.Text);
                        cmd.Parameters.AddWithValue("@total", label8.Text);
                        cmd.Parameters.AddWithValue("@down", label12.Text);
                        cmd.Parameters.AddWithValue("@timein", dateTimePicker3.Text);
                        cmd.Parameters.AddWithValue("@timeout", dateTimePicker4.Text);
                        cmd.Parameters.AddWithValue("@paymenttype", payment);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        frmmessagebox1.Show("Room Reservation Successful", "lbldialog", "OKAY");
                        this.Hide();
                    }
                    else
                    {
                        frmmessagebox1.Show("Please Provide Complete Details", "lbldialog", "OKAY");
                    }

                }
            }
   
        }

        private void frmReservations_Load(object sender, EventArgs e)
        {
          //  cmbroomtype.Items.Clear();
            comboBox2.Items.Clear();
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select Room_Type from tbl_rooms order by Room_Type asc";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
             //   cmbroomtype.Items.Add(dr["Room_Type"].ToString());
                comboBox2.Items.Add(dr["Room_Type"].ToString()); ;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmReservations NewForm = new frmReservations();
            NewForm.Show();
            this.Dispose(false);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            DateTime DateIn, DateOut;
            int TotalDays;
            int totalCost;
            int val23;
            Int32 val1 = Convert.ToInt32(txtrpd.Text);
            Int32 val2 = Convert.ToInt32(numericUpDown1.Text);
            Int32 val3 = Convert.ToInt32(txtepp.Text);

            DateIn = Convert.ToDateTime(dateCheckin.Value);
            DateOut = Convert.ToDateTime(dateTimePicker1.Value);

            val23 = (val2 * val3);
            TotalDays = (DateOut - DateIn).Days;
            {
                totalCost = (val1 * TotalDays + val23);
                label8.Text = Convert.ToString(totalCost);

                totalCost = ((val1 * TotalDays + val23) / 2);
                label12.Text = Convert.ToString(totalCost);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmShowReservations n1 = new frmShowReservations();
            n1.ShowDialog();
        }

        private void cmbroomtype_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
        private void button14_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmReservations_Activated(object sender, EventArgs e)
        {
            MySqlCommand cmda = con.CreateCommand();
            cmda.CommandText = "SELECT * from tbl_reservation";
            MySqlDataAdapter adapta = new MySqlDataAdapter(cmda);
            DataSet dsa = new DataSet();
            adapta.Fill(dsa);
            datGridreservations.DataSource = dsa.Tables[0].DefaultView;
            this.datGridreservations.Columns["Customer_ID"].Visible = false;
            this.datGridreservations.Columns["Room_ID"].Visible = false;
            this.datGridreservations.Columns["Customer_ID"].Visible = false;
            this.datGridreservations.Columns["Booking_Date"].Visible = false;
            this.datGridreservations.Columns["Customer_Name"].Visible = false;
            datGridreservations.Columns["Room_Name"].HeaderText = "Room Name";
            this.datGridreservations.Columns["No_Person"].Visible = false;
            datGridreservations.Columns["Checkin_Date"].HeaderText = "Checkin Date";
            datGridreservations.Columns["Checkout_Date"].HeaderText = "Checkout Date";
            this.datGridreservations.Columns["Total_Amount"].Visible = false;
            this.datGridreservations.Columns["Down_Payment"].Visible = false;
            this.datGridreservations.Columns["Payment_Type"].Visible = false;
            this.datGridreservations.Columns["Description"].Visible = false;
            this.datGridreservations.Columns["Rate_Per_Hour"].Visible = false;
            this.datGridreservations.Columns["Rate_Per_Day"].Visible = false;
            this.datGridreservations.Columns["Rate_Per_Extra_PH"].Visible = false;

        }

        private void datGridreservations_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            datGridreservations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            datGridreservations.AutoResizeColumns();
            datGridreservations.AllowUserToResizeColumns = true;
        }

        private void datGridreservations_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

  
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox3.Text = textBox3.Text.Remove(textBox3.Text.Length - 1);
            }
          
                if (rbfull.Checked == true)
                {
                    int change;

                    Int32 val1 = Convert.ToInt32(label8.Text);
                    Int32 val2 = Convert.ToInt32(textBox3.Text);
                    {
                        change = (val2 - val1);
                        lblchange.Text = Convert.ToString(change + ".00"); ;
                    }
                }
                else if (rbdown.Checked == true)
                {
                    int change;

                    Int32 val1 = Convert.ToInt32(label12.Text);
                    Int32 val2 = Convert.ToInt32(textBox3.Text);
                    {
                        change = (val2 - val1);
                        lblchange.Text = Convert.ToString(change + ".00"); ;
                    }
                }
               
                {
                  
                    
                }
            }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from tbl_rooms where Room_Type='" + comboBox2.Text + "'; ";

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            MySqlDataReader myReader;
            try
            {

                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    string roomid = myReader.GetString("Room_ID");
                    string description = myReader.GetString("Description");
                    string type = myReader.GetString("Room_Type");
                    string roomname = myReader.GetString("Room_Name");
                    string rph = myReader.GetString("Rate_Per_Hour");
                    string rpd = myReader.GetString("Rate_Per_Day");
                    string epp = myReader.GetString("Extra_Person_PH");
                    lblroomid.Text = roomid;
                    cmbroomtype.Text = type;
                    lbldescription.Text = description;
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        }
    }
