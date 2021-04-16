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
                lblmessage.Text = ("Please provide Username and Password");
                return;
            }
            try
            {
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

                    this.Hide();
                    new frmMain().Show();
                    frmmessagebox1.Show("Welcome " +txt_Username.Text,"lbldialog", "OKAY");
                   
                }
                else
                {
                    lblmessage.Text = ("Check Your Username or Password");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        bool focus = true;
        private void frmLogin_Paint(object sender, PaintEventArgs e)
        {     
            if (focus)
            {
                txt_Username.BorderStyle = BorderStyle.None;
                txt_Password.BorderStyle = BorderStyle.None;
                Pen p = new Pen(Color.SlateGray);
                Graphics g = e.Graphics;
                int variance = 3;
                g.DrawRectangle(p, new Rectangle(txt_Username.Location.X - variance, txt_Username.Location.Y - variance, txt_Username.Width + variance, txt_Username.Height + variance));
                g.DrawRectangle(p, new Rectangle(txt_Password.Location.X - variance, txt_Password.Location.Y - variance, txt_Password.Width + variance, txt_Password.Height + variance));
            }
            else
            {
                txt_Username.BorderStyle = BorderStyle.FixedSingle;
                txt_Password.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            focus = true;
            this.Refresh();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            focus = false;
            this.Refresh();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
