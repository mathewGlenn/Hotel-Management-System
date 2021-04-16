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
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost; Initial Catalog=HotelManagementSystem; User id=root; password=''");
        MySqlCommand cmd;
        MySqlDataAdapter adapt;
        public frmShowReservations()
        {
            InitializeComponent();
            DisplayData();
            ClearData();

        }

        string MyConnectionString = "Server=localhost; Database=HotelManagementSystem; Uid=root; PWD=;";
        DataTable dt;

     
        public void loadTable()
        {
            MySqlConnection con = new MySqlConnection(MyConnectionString);
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * from tbl_reservation";
            MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            dataGridReservation.DataSource = ds.Tables[0].DefaultView;
            this.dataGridReservation.Columns["Customer_ID"].Visible = false;
            dataGridReservation.Columns["Room_ID"].HeaderText = "Room ID";
            this.dataGridReservation.Columns["Customer_ID"].Visible = false;
            this.dataGridReservation.Columns["Booking_Date"].Visible = false;
            //this.dataGridReservation.Columns["Room_Type"].Visible = false;
            dataGridReservation.Columns["Customer_Name"].HeaderText = "Guest Name";
            dataGridReservation.Columns["Room_Name"].HeaderText = "Room Name";
            dataGridReservation.Columns["No_Person"].HeaderText = "# of Extra Person";
            dataGridReservation.Columns["Checkin_Date"].HeaderText = "Checkin";
            dataGridReservation.Columns["Checkout_Date"].HeaderText = "Checkout";
            dataGridReservation.Columns["Total_Amount"].HeaderText = "Checkin Rate";
            dataGridReservation.Columns["Down_Payment"].HeaderText = "Down Payment";
            dataGridReservation.Columns["Payment_Type"].HeaderText = "Payment Type";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            con = new MySqlConnection(MyConnectionString);
            con.Open();
            adapt = new MySqlDataAdapter("select * from tbl_reservation where Customer_Name like '" + txtSearch.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridReservation.DataSource = dt;
        }
        
        private void dataGridReservation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcusid.Text = dataGridReservation.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtroomid.Text = dataGridReservation.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtguestname.Text = dataGridReservation.Rows[e.RowIndex].Cells[2].Value.ToString();
                ptype.Text = dataGridReservation.Rows[e.RowIndex].Cells[12].Value.ToString();
                txtroomtype.Text = dataGridReservation.Rows[e.RowIndex].Cells[3].Value.ToString();
              //  txtroomname.Text = dataGridReservation.Rows[e.RowIndex].Cells[4].Value.ToString();
                cmbperson.Text = dataGridReservation.Rows[e.RowIndex].Cells[4].Value.ToString();
                lblrate.Text = dataGridReservation.Rows[e.RowIndex].Cells[10].Value.ToString();
                lblbalance.Text = dataGridReservation.Rows[e.RowIndex].Cells[11].Value.ToString();
                txtrph.Text = dataGridReservation.Rows[e.RowIndex].Cells[14].Value.ToString();
                txtrpd.Text = dataGridReservation.Rows[e.RowIndex].Cells[15].Value.ToString();
                txtepp.Text = dataGridReservation.Rows[e.RowIndex].Cells[16].Value.ToString();

                dateTimePicker1.Text = dataGridReservation.Rows[e.RowIndex].Cells[7].Value.ToString();
                dateTimePicker4.Text = dataGridReservation.Rows[e.RowIndex].Cells[9].Value.ToString();
                dateTimePicker3.Text = dataGridReservation.Rows[e.RowIndex].Cells[8].Value.ToString();
                dateTimePicker2.Text = dataGridReservation.Rows[e.RowIndex].Cells[6].Value.ToString();

                txtroomdescript.Text = dataGridReservation.Rows[e.RowIndex].Cells[13].Value.ToString();

            }

        private void dataGridReservation_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmReservationDetails myForm = new frmReservationDetails();

            myForm.label10.Text = dataGridReservation.CurrentRow.Cells[2].Value.ToString();
            //myForm.label11.Text = dataGridReservation.CurrentRow.Cells[3].Value.ToString();
            myForm.label14.Text = dataGridReservation.CurrentRow.Cells[3].Value.ToString();
            myForm.label15.Text = dataGridReservation.CurrentRow.Cells[4].Value.ToString();
            myForm.label16.Text = dataGridReservation.CurrentRow.Cells[5].Value.ToString();
            myForm.label17.Text = dataGridReservation.CurrentRow.Cells[6].Value.ToString();
            myForm.label18.Text = dataGridReservation.CurrentRow.Cells[8].Value.ToString();
            myForm.label19.Text = dataGridReservation.CurrentRow.Cells[10].Value.ToString();
            myForm.label6.Text = dataGridReservation.CurrentRow.Cells[12].Value.ToString();

            myForm.ShowDialog();
        }
        private void DisplayData()
        {
            DataTable dt = new DataTable();
            adapt = new MySqlDataAdapter("select * from tbl_reservation", con);
            adapt.Fill(dt);
            dataGridReservation.DataSource = dt;
        }
        private void ClearData()
        {
            txtguestname.Text = "";
            txtroomtype.Text = "";
            lblbalance.Text = "";
            cmbperson.Text = "";
            dateTimePicker2.Text = "";
            dateTimePicker3.Text = "";
            lblrate.Text = "";
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            if (txtguestname.Text != "" && txtroomtype.Text != "")
            {
                 con.Open();
            cmd = new MySqlCommand("update tbl_reservation set Total_Amount=@total, Checkin_Date=@Checkin_Date, Checkout_Date=@Checkout_Date,Checkin_Time=@Checkin_Time, Checkout_Time=@Checkout_Time where Room_ID=@uid", con);
               cmd.Parameters.AddWithValue("@uid",txtroomid.Text);
              //  cmd.Parameters.AddWithValue("@name", txtguestname.Text);
                cmd.Parameters.AddWithValue("@total", lblrate.Text);
                cmd.Parameters.AddWithValue("@Checkin_Date", dateTimePicker2.Text);
                cmd.Parameters.AddWithValue("@Checkout_Date", dateTimePicker3.Text);
                cmd.Parameters.AddWithValue("@Checkin_Time", dateTimePicker4.Text);
                cmd.Parameters.AddWithValue("@Checkout_Time", dateTimePicker1.Text);

                cmd.ExecuteNonQuery();
                frmmessagebox.Show("Update successful,","lbldialog","OKAY");
                DisplayData();
                ClearData();
                con.Close();
            }
          
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                DialogResult dr = MessageBox.Show("Are you sure to cancel this reservation?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    if (txtroomid.Text != "")
                    {
                        MySqlConnection con = new MySqlConnection(MyConnectionString);
                        MySqlCommand cmd;
                        con.Open();
                        {
                            cmd = con.CreateCommand();
                            cmd.CommandText = @"INSERT INTO tbl_cancelledreservation(Room_ID, Room_Name, Person_No, Description, Rate_Per_Hour, Rate_Per_Day, Extra_Person_PH, Vehicle_Info,Checkin,Checkout,orHour, Total_Amount) VALUES (@id, @roomname, @personno, @description,@rph, @rpd, @epp,@vehicle,@checkin,@checkout,@hour,@totalamount);
                                delete from tbl_reservation where Room_ID=@id";
                               
                               
                            cmd.Parameters.AddWithValue("@id", txtroomid.Text);
                            //cmd.Parameters.AddWithValue("@roomtype", txtroomtype.Text);
                              cmd.Parameters.AddWithValue("@roomname", txtroomtype.Text);
                            cmd.Parameters.AddWithValue("@personno", cmbperson.Text);
                            cmd.Parameters.AddWithValue("@description", txtroomdescript.Text);
                            cmd.Parameters.AddWithValue("@rph", txtrph.Text);
                            cmd.Parameters.AddWithValue("@rpd", txtrpd.Text);
                            cmd.Parameters.AddWithValue("@epp", txtepp.Text);
                            cmd.Parameters.AddWithValue("@vehicle", txtvehicle.Text);
                            cmd.Parameters.AddWithValue("@checkin", dateTimePicker2.Text);
                            cmd.Parameters.AddWithValue("@checkout", dateTimePicker3.Text);
                            cmd.Parameters.AddWithValue("@hour", txtorhour.Text);
                            cmd.Parameters.AddWithValue("@totalamount", lblrate.Text);
                            cmd.ExecuteNonQuery();
                            con.Close();
                            frmmessagebox1.Show("Reservation Cancelled Successfully", "lbldialog", "OKAY");

                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select Reservation to cancel");
                    }
                }
            }
         
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(MyConnectionString);
            MySqlCommand cmd;
            con.Open();
            {
                cmd = con.CreateCommand();
                cmd.CommandText = @"INSERT INTO tbl_occupiedrooms(Room_ID, Room_Name, Person_No, Description, Rate_Per_Hour, Rate_Per_Day, Extra_Person_PH, Vehicle_Info,Checkin,Checkout,orHour, Total_Amount) VALUES (@id, @roomname, @personno, @description,@rph, @rpd, @epp,@vehicle,@checkin,@checkout,@hour,@totalamount);
                                delete from tbl_reservation where Room_ID=@id;
                                delete from tbl_availablerooms where Room_ID=@id;
                                INSERT INTO tbl_allcheckins (Room_ID,  Room_Name, Person_No, Vehicle_Info,Checkin,Checkout,orHour, Total_Amount) VALUES (@id, @roomname, @personno, @vehicle,@checkin,@checkout,@hour,@totalamount)";
                cmd.Parameters.AddWithValue("@id", txtroomid.Text);
                cmd.Parameters.AddWithValue("@roomname", txtroomtype.Text);
              //  cmd.Parameters.AddWithValue("@roomname", txtroomname.Text);
                cmd.Parameters.AddWithValue("@personno", cmbperson.Text);
                cmd.Parameters.AddWithValue("@description", txtroomdescript.Text);
                cmd.Parameters.AddWithValue("@rph", txtrph.Text);
                cmd.Parameters.AddWithValue("@rpd", txtrpd.Text);
                cmd.Parameters.AddWithValue("@epp", txtepp.Text);
                cmd.Parameters.AddWithValue("@vehicle", txtvehicle.Text);
                cmd.Parameters.AddWithValue("@checkin", dateTimePicker2.Text);
                cmd.Parameters.AddWithValue("@checkout", dateTimePicker3.Text);
                cmd.Parameters.AddWithValue("@hour", txtorhour.Text);
                cmd.Parameters.AddWithValue("@totalamount", lblrate.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                frmmessagebox.Show("Checkin Succsessfull","lbldialog","OKAY");
                dataGridReservation.Refresh();
            }
        }
        private void button8_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmReservations n = new frmReservations();
            n.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmShowReservations_Activated(object sender, EventArgs e)
        {
            loadTable();
        }

        private void frmShowReservations_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }



        private void dataGridReservation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void dateTimePicker3_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dateTimePicker3_MouseCaptureChanged(object sender, EventArgs e)
        {
         
        }

        private void dateTimePicker3_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void dateTimePicker3_FormatChanged(object sender, EventArgs e)
        {
 
        }

        private void frmShowReservations_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void frmShowReservations_MouseClick(object sender, MouseEventArgs e)
        {
            DateTime DateIn, DateOut;
            int TotalDays;
            int totalCost;
            int additional;
            int val23;
            Int32 val1 = Convert.ToInt32(txtrpd.Text);
            Int32 val2 = Convert.ToInt32(cmbperson.Text);
            Int32 val3 = Convert.ToInt32(txtepp.Text);
            Int32 val4 = Convert.ToInt32(lblrate.Text);

            DateIn = Convert.ToDateTime(dateTimePicker2.Value);
            DateOut = Convert.ToDateTime(dateTimePicker3.Value);

            val23 = (val2 * val3);
            TotalDays = (DateOut - DateIn).Days;
            {
                totalCost = (val1 * TotalDays + val4);
                lblrate.Text = Convert.ToString(totalCost);

                additional = (val1 * TotalDays);
                label14.Text = Convert.ToString(additional);
            }
        }
    }
}