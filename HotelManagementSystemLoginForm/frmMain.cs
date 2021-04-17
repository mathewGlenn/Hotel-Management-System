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

        MySqlConnection con = new MySqlConnection(@"Data Source=localhost; Initial Catalog=HotelManagementSystem; User id=root; password=''");
        public frmMain()
        {
            InitializeComponent();
            label3.Text = DateTime.Now.ToString();


        }
        string ConnectionString = "Server=localhost; Database=HotelManagementSystem; Uid=root; PWD=;";
        private void button5_Click(object sender, EventArgs e)
        {
            frmCheckIn n = new frmCheckIn();
            n.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            frmReservations n = new frmReservations();
            n.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmViewRoomType k = new frmViewRoomType();
            k.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {

            frmCheckout m = new frmCheckout();
            m.ShowDialog();
        }

        private void datGridreservations_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridReservation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridReservation.AutoResizeColumns();
            dataGridReservation.AllowUserToResizeColumns = true;
        }
        private void datGridreservations_CellClick(object sender, DataGridViewCellEventArgs e)
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
        private void button2_Click_1(object sender, EventArgs e)
        {
            {
                DialogResult dr = MessageBox.Show("Are you really going to leave?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Application.ExitThread();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                DialogResult dr = MessageBox.Show("Confirm you're going to logout.", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    this.Hide();
                    frmLogin m = new frmLogin();
                    m.Show();
                }
            }
        }


        private void button6_Click(object sender, EventArgs e)
        {
            frmCheckinsHistory n = new frmCheckinsHistory();
            n.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmReservationsHistory m = new frmReservationsHistory();
            m.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmAbout m = new frmAbout();
            m.ShowDialog();
        }

        private void datGridreservations_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void frmMain_Activated(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand sc = new MySqlCommand("SELECT count(Room_ID) AS TotalCount FROM tbl_availablerooms", con);
            MySqlDataReader reader;
            reader = sc.ExecuteReader();
            while (reader.Read())
            {
                lblavailable.Text = reader["TotalCount"].ToString();
            }
            con.Close();
            {
                con.Open();
                MySqlCommand scc = new MySqlCommand("SELECT count(Room_ID) AS TotalCountt FROM tbl_occupiedrooms", con);
                MySqlDataReader readerr;
                readerr = scc.ExecuteReader();
                while (readerr.Read())
                {
                    lblcheckin.Text = readerr["TotalCountt"].ToString();
                }
                con.Close();
                {
                    con.Open();
                    MySqlCommand sccc = new MySqlCommand("SELECT count(Room_ID) AS TotalCountt FROM tbl_reservation", con);
                    MySqlDataReader readerrr;
                    readerrr = sccc.ExecuteReader();
                    while (readerrr.Read())
                    {
                        lblreservations.Text = readerrr["TotalCountt"].ToString();
                    }
                    con.Close();
                    {

                        con.Open();
                        MySqlCommand scccc = new MySqlCommand("SELECT sum(Person_No + extra_person) AS TotalCountt FROM tbl_occupiedrooms", con);
                        MySqlDataReader readerrrr;
                        readerrrr = scccc.ExecuteReader();
                        while (readerrrr.Read())
                        {
                            lblguests.Text = readerrrr["TotalCountt"].ToString();
                        }
                    }


                    con.Close(); ;

                    {
                        MySqlConnection cona = new MySqlConnection(ConnectionString);
                        cona.Open();
                        MySqlCommand cmda = con.CreateCommand();
                        cmda.CommandText = "SELECT * from tbl_reservation";
                        MySqlDataAdapter adapta = new MySqlDataAdapter(cmda);
                        DataSet dsa = new DataSet();
                        adapta.Fill(dsa);
                        dataGridReservation.DataSource = dsa.Tables[0].DefaultView;
                        this.dataGridReservation.Columns["Customer_ID"].Visible = false;
                        this.dataGridReservation.Columns["Room_ID"].Visible = false;
                        this.dataGridReservation.Columns["Customer_ID"].Visible = false;
                        this.dataGridReservation.Columns["Booking_Date"].Visible = false;
                       // this.datGridreservations.Columns["Room_Name"].Visible = false;
                        dataGridReservation.Columns["Customer_Name"].HeaderText = "Guest Name";
                        dataGridReservation.Columns["Room_Name"].HeaderText = "Room Name";
                        this.dataGridReservation.Columns["No_Person"].Visible = false;
                        dataGridReservation.Columns["Checkin_Date"].HeaderText = "Checkin Date";
                        dataGridReservation.Columns["Checkout_Date"].HeaderText = "Checkout Date";
                        this.dataGridReservation.Columns["Total_Amount"].Visible = false;
                        this.dataGridReservation.Columns["Down_Payment"].Visible = false;
                        this.dataGridReservation.Columns["Payment_Type"].Visible = false;

                        this.dataGridReservation.Columns["Description"].Visible = false;
                        this.dataGridReservation.Columns["Rate_Per_Hour"].Visible = false;
                        this.dataGridReservation.Columns["Rate_Per_Day"].Visible = false;
                        this.dataGridReservation.Columns["Rate_Per_Extra_PH"].Visible = false;
                        cona.Close();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmShowReservations m = new frmShowReservations();
            m.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            frmCheckout m = new frmCheckout();
            m.ShowDialog();
        }

        private void label23_Click(object sender, EventArgs e)
        {
            Form1 n = new Form1();
            n.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        // This is comment for github testing
    }
}
 