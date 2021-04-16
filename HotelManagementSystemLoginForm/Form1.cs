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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string MyConnectionString = "server=localhost; database=HotelManagementSystem; uid=root;password=;";
        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || user.Text == "")
            {
               MessageBox.Show ("Acces Denied");
                return;
            }
            try
            {
                MySqlConnection con = new MySqlConnection(MyConnectionString);
                MySqlCommand cmd = new MySqlCommand("Select * from tbl_adminusers where Admin_Username=@username and Admin_Password=@password", con);
                cmd.Parameters.AddWithValue("@username", user.Text);
                cmd.Parameters.AddWithValue("@password", textBox1.Text);
                con.Open();
                MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;
                //If count is equal to 1, than show frmMain form
                if (count == 1)
                {
                    MessageBox.Show("Access Granted");
                    this.Hide();
                    Form2 fm = new Form2();
                    fm.ShowDialog();
                }
                else
                {
                    MessageBox.Show ("Acces Denied");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
