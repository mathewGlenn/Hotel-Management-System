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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string MyConnectionString = "server=localhost; database=HotelManagementSystem;uid=root;password=;";
        private void Form2_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(MyConnectionString);
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * from tbl_users";
            MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            con.Close();
            {
                id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                user.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {

            MySqlConnection con = new MySqlConnection(MyConnectionString);
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd = new MySqlCommand("update tbl_users set Admin_Username=@user, Admin_Password=@pword where Admin_ID=@uid", con);
            cmd.Parameters.AddWithValue("@uid", id.Text);
            //  cmd.Parameters.AddWithValue("@name", txtguestname.Text)
            cmd.Parameters.AddWithValue("@pword", textBox1.Text);
            cmd.Parameters.AddWithValue("@user", user.Text);
            this.Hide();
            cmd.ExecuteNonQuery();
            MessageBox.Show("User Login Updated Successfully");
            con.Close();
        }
    }
}
