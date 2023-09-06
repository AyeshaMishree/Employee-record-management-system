using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;

namespace EmployeeManagement
{
    public partial class Form1 : Form
    {

        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;  

        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if ( user.Text=="")
            {
                btnlogin.Enabled = false;
            }
            else
            {
                btnlogin.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (user.Text !="" && pass.Text != "")
            {
                OleDbConnection con = new OleDbConnection(cs);
                con.Open();
                string query = "select * from login where username1=@user1 and password1=@pass1";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@user1", user.Text);
                cmd.Parameters.AddWithValue("@pass1", pass.Text);
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    MessageBox.Show("Login Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    welcome wl = new welcome();
                    wl.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Fill all fields", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (pass.Text == "")
            {
                btnlogin.Enabled = false;
            }
            else
            {
                btnlogin.Enabled = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Signup sup = new Signup();
            sup.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnlogin.Enabled = false;
        }
    }
}
