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
    public partial class frmLogin : Form
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost; Initial Catalog=HotelManagementSystem; User id=root; password=''");
        public frmLogin()
        {
            InitializeComponent();
        }

        
        string MyConnectionString = "Server=localhost; Database=HotelManagementSystem; Uid=root; PWD=;";

        private void btn_Submit_Click(object sender, EventArgs e)

        {
            if (txt_Password.Text == "" || txt_Username.Text == "")
            {
                MessageBox.Show("Please provide User Name and Password");
                return;
            }
            try
            {
                //Create SqlConnection
                MySqlConnection con = new MySqlConnection(MyConnectionString);
                MySqlCommand cmd = new MySqlCommand("Select * from tbl_adminusers where Admin_Username=@username and Admin_Password=@password", con);
                cmd.Parameters.AddWithValue("@username", txt_Password.Text);
                cmd.Parameters.AddWithValue("@password", txt_Username.Text);
                con.Open();
                MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;
                //If count is equal to 1, than show frmMain form
                if (count == 1)
                {
                    MessageBox.Show("welcome, " + txt_Username.Text + " !");
                    this.Hide();
                    frmMain fm = new frmMain();
                    fm.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txt_Password_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
