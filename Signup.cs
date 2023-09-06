using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;
using System.Data.SqlClient;

namespace EmployeeManagement
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Dispose();
        }

        private void username_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(username.Text) == true)
            {
                username.Focus();
                errorProvider1.SetError(this.username, "Pleas enter username");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text) == true)
            {
                textBox3.Focus();
                errorProvider2.SetError(this.textBox3, "Pleas fill password");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text != textBox3.Text)
            {
                textBox2.Focus();
                errorProvider3.SetError(this.textBox2, "Password Mismatched!");
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            //  try
            //   {

            try
            {

                string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
                OleDbConnection con = new OleDbConnection(cs);
                con.Open();
                string query1 = "insert into login values(@user,@password)";
                OleDbCommand cmd = new OleDbCommand(query1, con);
                cmd.Parameters.AddWithValue("@user", username.Text);
                cmd.Parameters.AddWithValue("@password", textBox3.Text);

                //  cmd.ExecuteNonQuery();

                cmd.ExecuteNonQuery();
                string query2 = "insert into signup values(@users,@passwords)";
                OleDbCommand cmd2 = new OleDbCommand(query2, con);
                cmd2.Parameters.AddWithValue("@users", username.Text);
                cmd2.Parameters.AddWithValue("@passwords", textBox3.Text);
                int a = cmd2.ExecuteNonQuery();


                con.Close();

                if (a > 0)
                {
                    MessageBox.Show("Registed Successfully", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Registed Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("May this username or password is already signed up! ");
            }

        }
            

        private void button1_Click(object sender, EventArgs e)
        {
            username.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
            f2.Show();
            this.Hide();
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                btnlogin.Enabled = false;
            }
            else
            {
                btnlogin.Enabled = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                btnlogin.Enabled = false;
            }
            else
            {
                btnlogin.Enabled = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                btnlogin.Enabled = false;
            }
            else
            {
                btnlogin.Enabled = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void Signup_Load(object sender, EventArgs e)
        {
            btnlogin.Enabled = false;

        }
    }
}
