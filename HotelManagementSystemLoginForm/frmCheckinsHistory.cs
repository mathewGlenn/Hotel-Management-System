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
    public partial class frmCheckinsHistory : Form
    {
   MySqlConnection con = new MySqlConnection(@"Data Source=localhost; Initial Catalog=HotelManagementSystem; User id=root; password=''");
        public frmCheckinsHistory()
        {
            InitializeComponent();
        }
        string MyConnectionString = "Server=localhost; Database=HotelManagementSystem; Uid=root; PWD=;";

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmCheckinsHistory_Activated(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(MyConnectionString);
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * from tbl_allcheckins";
            MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            con.Close();
        }

        private void frmCheckinsHistory_Load(object sender, EventArgs e)
        {

        }
    }
}
