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
    public partial class frmReservationDetails : Form
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost; Initial Catalog=HotelManagementSystem; User id=root; password=''");
        public frmReservationDetails()
        {
            InitializeComponent();
        }
                                                                            
        string ConnectionString = "Server=localhost; Database=HotelManagementSystem; Uid=root; PWD=;";
        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(ConnectionString);
            MySqlCommand cmd;
            con.Open();
            {
                cmd = con.CreateCommand();
                cmd.CommandText = @"INSERT INTO tbl_checkin( Room_Name,  Person_No,Checkin_Datetime,Checkout_Datetime,Total_Amount) VALUES ( @roomname, @personno,@checkin,@checkout,@totalamount);
                              INSERT INTO tbl_occupiedroom (Room_Name, Checkin_Datetime, Checkout_Datetime) values (@roomname, @checkin, @checkout);
                                INSERT INTO tbl_allcheckin( Room_Name, Person_No,Checkin_Datetime,Checkout_Datetime,Total_Amount) VALUES ( @roomname, @personno,@checkin,@checkout,@totalamount)";
              //  cmd.Parameters.AddWithValue("@roomtype", label11.Text);
                cmd.Parameters.AddWithValue("@roomname", label14.Text);
                cmd.Parameters.AddWithValue("@@personno", label15.Text);
                cmd.Parameters.AddWithValue("@checkin", label17.Text);
                cmd.Parameters.AddWithValue("@checkout", label18.Text);
                cmd.Parameters.AddWithValue("@totalamount", label19.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Checkin Succsessfull");
                this.Close();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
