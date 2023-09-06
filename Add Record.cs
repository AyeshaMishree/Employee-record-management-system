using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Configuration;
using System.Runtime.CompilerServices;
using System.ComponentModel.DataAnnotations;
using EmployeeManagement.dbtkDataSetTableAdapters;
using System.Text.RegularExpressions;
using System.Reflection.Emit;
using System.Net.NetworkInformation;
using System.CodeDom;

namespace EmployeeManagement
{
    public partial class Add_Record : Form
    {
        OleDbConnection conn;  
        OleDbDataAdapter adapter;
        DataTable dt;
        public Add_Record()
        {
            InitializeComponent();
        }
        //variable for email validation
        string patternemail = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

        void Getemployee()
        {
                conn = new OleDbConnection(@" Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Aysha\Desktop\dbtk.accdb");
                // conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0; Data Source = dbtk.accdb");
                dt = new DataTable();
                adapter = new OleDbDataAdapter("SELECT *FROM employee", conn);
                conn.Open();
                adapter.Fill(dt);
                Display_all_Record mform = new Display_all_Record();
                mform.dgvdisplay.DataSource = dt;
                conn.Close();
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

            if (contact.Text == "")
            {
                btnsave.Enabled = false;
            }
            else
            {
                btnsave.Enabled = true;
            }
        }

        private OleDbConnection GetConn()
        {
            return conn;
        }

        private void btnsave_Click(object sender, EventArgs e, OleDbConnection conn)
        {
                conn.Open();
                conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0; Data Source = dbtk.accdb");
                string query = "insert into employee (ID, NAME,GENDER,CONTACT NO,EMAIL ADDRESS,DESIGNATION,SALARY,DATE OF HIRING,DATE OF FIRING) VALUES" +
                    "(@name,@gender,@contactno,@emailaddress,@designation,@salary,@dateofhiring,@dateoffiring)";
                OleDbCommand cmd = conn.CreateCommand();
                cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", name.Text);
                cmd.Parameters.AddWithValue("@gender", gender.Text);
                cmd.Parameters.AddWithValue("@contactno", contact.Text);
                cmd.Parameters.AddWithValue("@emailaddress", email.Text);
                cmd.Parameters.AddWithValue("@designation", des.Text);
                cmd.Parameters.AddWithValue("@salary", salary.Text);
                cmd.Parameters.AddWithValue("@dateofhiring", textBox1.Text);
                cmd.Parameters.AddWithValue("@dateoffiring", textBox2.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Record saved successfully!");
                Getemployee();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            id.Clear();
            name.Clear();
            gender.Text= string.Empty;
            email.Clear();
            contact.Clear();
            des.Text = string.Empty;
            salary.Clear();
            textBox1.Clear();
            textBox2.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            // here is the exception of same id in execute non query line
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
                OleDbConnection con = new OleDbConnection(cs);
                con.Open();
                string query3 = "insert into employee values(@ID,@NAME,@GENDER,@CONTACT_NO,@EMAIL_ADDRESS,@DESIGNATION,@SALARY,@DATE_OF_HIRING,@DATE_OF_FIRING)";
                OleDbCommand cmd = new OleDbCommand(query3, con);
                cmd.Parameters.AddWithValue("@ID", id.Text);
                cmd.Parameters.AddWithValue("@NAME", name.Text);
                cmd.Parameters.AddWithValue("@GENDER", gender.Text);
                cmd.Parameters.AddWithValue("@CONTACT_NO", contact.Text);
                cmd.Parameters.AddWithValue("@EMAIL_ADDRESS", email.Text);
                cmd.Parameters.AddWithValue("@DESIGNATION", des.Text);
                cmd.Parameters.AddWithValue("@SALARY", salary.Text);
                cmd.Parameters.AddWithValue("@DATE_OF_HIRING", textBox1.Text);
                cmd.Parameters.AddWithValue("@DATE_OF_FIRING", textBox2.Text);
                int a = cmd.ExecuteNonQuery();
                con.Close();
                if (a > 0)
                {
                    id.Clear();
                    name.Clear();
                    gender.Text = string.Empty;
                    email.Clear();
                    contact.Clear();
                    des.Text = string.Empty;
                    salary.Clear();
                    textBox1.Clear();
                    textBox2.Clear();
                    MessageBox.Show("Record saved Successfully!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            //catch (IndexOutOfRangeException)
            //{
            //    MessageBox.Show(" You have put something in incorrect format!  ");
            //}
            catch (Exception ex)
            {
                MessageBox.Show("You have entered date in incorrect format otherwise already registered ID is inserted ! ");
            }
            //if application closes unusually, DB connection will also be close
            finally
            {
                Getemployee();
            }


        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            welcome back = new welcome();
            back.Show();



            //welcome w1 = new welcome();
            //w1.Show();
            //this.Hide();
        }

        private void Add_Record_Load(object sender, EventArgs e)
        {
            btnsave.Enabled = false;

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

            if (name.Text == "")
            {
                btnsave.Enabled = false;
            }
            else
            {
                btnsave.Enabled = true;
            }
        }
        private void id_TextChanged(object sender, EventArgs e)
        {
            if (id.Text == "")
            {
                btnsave.Enabled = false;
            }
            else
            {
                btnsave.Enabled = true;
            }
        }
        
       //VALIDATIONS CODE FOR LEAVE EVENTS OF TEXTBOXES

        private void id_Leave(object sender, EventArgs e)
        {
            int outid;
            if (string.IsNullOrEmpty(id.Text) == true)
            {
                id.Focus();
                errorProvider1.SetError(id, "This field is required!");
            }
            else
            {
                     errorProvider1.Clear();
            }
        }

        private void gender_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (gender.Text == "")
            {
                btnsave.Enabled = false;
            }
            else
            {
                btnsave.Enabled = true;
            }
        }

        private void email_TextChanged(object sender, EventArgs e)
        {

            if (email.Text == "")
            {
                btnsave.Enabled = false;
            }
            else
            {
                btnsave.Enabled = true;
            }
        }

        private void dol_TextChanged(object sender, EventArgs e)
        {

        }

        private void gender_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(gender.Text) == true)
            {
                des.Focus();
                errorProvider4.SetError(gender, "This field is required!");
            }
            else
            {
                errorProvider4.Clear();
            }
            if (gender.SelectedItem == null)
            {
                gender.Focus();
                MessageBox.Show("Please select gender from given options! ");
            }
            else
            {
                errorProvider4.Clear();
            }
        }

        private void des_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(des.Text) == true)
            {
                des.Focus();
                errorProvider2.SetError(des, "This field is required!");

            }
            else
            {
                errorProvider2.Clear();
            }
            if (des.SelectedItem == null)
            {
                des.Focus();
                MessageBox.Show("Please select designation from given options! ");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void email_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(email.Text) == true)
            {
                email.Focus();
                errorProvider3.SetError(email, "This field is required!");

            }
            else
            {
                errorProvider3.Clear();
            }
            if (Regex.IsMatch(email.Text, patternemail) == false)
            {
                email.Focus();
                errorProvider3.SetError(this.email, "Invalid email!");
               // MessageBox.Show("Please enter the valid email address! ");
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void name_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(name.Text) == true)
            {
                name.Focus();
                errorProvider5.SetError(name, "This field is required!");
            }
            else
            {
                errorProvider5.Clear();
            }
        }

        private void contact_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(contact.Text) == true)
            {
                contact.Focus();
                errorProvider6.SetError(contact, "This field is required!");
            }
            else
            {
                errorProvider6.Clear();
            }
        }

        private void salary_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(salary.Text) == true)
            {
                salary.Focus();
                errorProvider7.SetError(salary, "This field is required!");
            }
            else
            {
                errorProvider7.Clear();
            }
        }

        private void doh_Leave(object sender, EventArgs e)
        {
           
        }

        //VALIDATIONS CODE FOR KEYPRESS EVENTS OF TEXTBOXES

        private void id_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch))
            {
                e.Handled = false;
            }
            else if (ch == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Use digits only!");
            }
        }

        private void contact_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch))
            {
                e.Handled = false;
            }
            //backspace key
            else if (ch == 8)
            {
                e.Handled = false;
            }
            //comma key
            else if (ch == 188)
            {
                e.Handled = false;
            }
            //oem minus key
            else if (ch == 189)
            {
                e.Handled = false;
            }
            //oem subtract key
            else if (ch == 109)
            {
                e.Handled = false;
            }
            //shift key
            else if (ch == 65536)
            {
                e.Handled = false;
            }
            //capslock key
            else if (ch == 20)
            {
                e.Handled = false;
            }
            //delete key
            else if (ch == 46)
            {
                e.Handled = false;
            }
            //left shift key
            else if (ch == 160)
            {
                e.Handled = false;
            }
            //alt key
            else if (ch == 18)
            {
                e.Handled = false;
            }
            //num lock key
            else if (ch == 144)
            {
                e.Handled = false;
            }
            //right alt key
            else if (ch == 165)
            {
                e.Handled = false;
            }
            //right shift key
            else if (ch == 161)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid contact number!");
            }
        }
        private void salary_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch))
            {
                e.Handled = false;
            }
            //backspace key
            else if (ch == 8)
            {
                e.Handled = false;
            }
            //space key
            else if (ch == 32)
            {
                e.Handled = false;
            }
            //comma key
            else if (ch == 188)
            {
                e.Handled = false;
            }
            //oem minus key
            else if (ch == 189)
            {
                e.Handled = false;
            }
            //oem subtract key
            else if (ch == 109)
            {
                e.Handled = false;
            }
            //shift key
            else if (ch == 65536)
            {
                e.Handled = false;
            }
            //capslock key
            else if (ch == 20)
            {
                e.Handled = false;
            }
            //delete key
            else if (ch == 46)
            {
                e.Handled = false;
            }
            //left shift key
            else if (ch == 160)
            {
                e.Handled = false;
            }
            //alt key
            else if (ch == 18)
            {
                e.Handled = false;
            }
            //num lock key
            else if (ch == 144)
            {
                e.Handled = false;
            }
            //right alt key
            else if (ch == 165)
            {
                e.Handled = false;
            }
            //right shift key
            else if (ch == 161)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid salary, use digits only!");
            }
            
        }

        private void name_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetter(ch))
            {
                e.Handled = false;
            }
            //backspace key
            else if (ch == 8)
            {
                e.Handled = false;
            }
            //comma key
            else if (ch == 188)
            {
                e.Handled = false;
            }
            //oem minus key
            else if (ch == 189)
            {
                e.Handled = false;
            }
            //oem subtract key
            else if (ch == 109)
            {
                e.Handled = false;
            }
            //shift key
            else if (ch == 65536)
            {
                e.Handled = false;
            }
            //capslock key
            else if (ch == 20)
            {
                e.Handled = false;
            }
            //delete key
            else if (ch == 46)
            {
                e.Handled = false;
            }
            //left shift key
            else if (ch == 160)
            {
                e.Handled = false;
            }
            //alt key
            else if (ch == 18)
            {
                e.Handled = false;
            }
            //num lock key
            else if (ch == 144)
            {
                e.Handled = false;
            }
            //space key
            else if (ch == 32)
            {
                e.Handled = false;
            }
            //right alt key
            else if (ch == 165)
            {
                e.Handled = false;
            }
            //right shift key
            else if (ch == 161)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid name!");
            }
        }
        //date time picker instead of textboxes
        private void doh1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void dol1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void des_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (des.Text == "")
            {
                btnsave.Enabled = false;
            }
            else
            {
                btnsave.Enabled = true;
            }
        }

        private void salary_TextChanged(object sender, EventArgs e)
        {

            if (salary.Text == "")
            {
                btnsave.Enabled = false;
            }
            else
            {
                btnsave.Enabled = true;
            }
        }

        private void doh1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) == true)
            {
                textBox1.Focus();
                errorProvider8.SetError(textBox1, "This field is required!");
            }
            else
            {
                errorProvider8.Clear();
            }
        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                btnsave.Enabled = false;
            }
            else
            {
                btnsave.Enabled = true;
            }
        }
    }
}
