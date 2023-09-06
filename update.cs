using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms; 
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Configuration;
using System.Runtime.CompilerServices;
using System.ComponentModel.DataAnnotations;
using EmployeeManagement.dbtkDataSetTableAdapters;
using System.Text.RegularExpressions;
using System.Reflection.Emit;
using System.Net.NetworkInformation;
namespace EmployeeManagement
{
    public partial class update : Form
    {
       
        public update()
        {
            InitializeComponent();
        }

        //variable for email validation
        string patternemail = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
                OleDbConnection con = new OleDbConnection(cs);
                con.Open();
                string query1 = "update employee set ID=@ID,NAME=@NAME,GENDER=@GENDER,CONTACT_NO=@CONTACT_NO,EMAIL_ADDRESS=@EMAIL_ADDRESS,DESIGNATION=@DESIGNATION,SALARY=@SALARY,DATE_OF_HIRING=@DATE_OF_HIRING,DATE_OF_FIRING=@DATE_OF_FIRING where NAME='" + updateemp.Text + "'";
                OleDbCommand cmd = new OleDbCommand(query1, con);
                cmd.Parameters.AddWithValue("@ID", id.Text);
                cmd.Parameters.AddWithValue("@NAME", name.Text);
                cmd.Parameters.AddWithValue("@GENDER", gender.Text);
                cmd.Parameters.AddWithValue("@CONTACT_NO", contact.Text);
                cmd.Parameters.AddWithValue("@EMAIL_ADDRESS", email.Text);
                cmd.Parameters.AddWithValue("@DESIGNATION", des.Text);
                cmd.Parameters.AddWithValue("@SALARY", salary.Text);
                cmd.Parameters.AddWithValue("@DATE_OF_HIRING", textBox1.Text);
                cmd.Parameters.AddWithValue("@DATE_OF_FIRING", textBox2.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record updated successfully!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("You have entered data in incorrect format otherwise already registered ID is inserted ! ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            welcome back = new welcome();
            back.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void updateemp_TextChanged(object sender, EventArgs e)
        {
            if (updateemp.Text == "")
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }

        }

        private void dol1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void update_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;

        }
        //validation code
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) == true)
            {
                textBox1.Focus();
                errorProvider9.SetError(textBox1, "This field is required!");
            }
            else
            {
                errorProvider9.Clear();
            }
        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }
        ////VALIDATIONS CODE FOR LEAVE EVENTS OF TEXTBOXES
        private void salary_Leave_1(object sender, EventArgs e)
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

        private void id_Leave_1(object sender, EventArgs e)
        {
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

        private void gender_Leave_1(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(gender.Text) == true)
            {
                gender.Focus();
                errorProvider4.SetError(gender, "This field is required!");
            }
            else
            {
                errorProvider4.Clear();
            }
            if (gender.SelectedItem == null)
            {
                gender.Focus();
                MessageBox.Show("Please select designation from given options! ");
            }
            else
            {
                errorProvider4.Clear();
            }
        }

        private void des_Leave_1(object sender, EventArgs e)
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

        private void email_Leave_1(object sender, EventArgs e)
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
                MessageBox.Show("Please enter the valid email address! ");
            }
            else
            {
                errorProvider3.Clear();
            }
        }
        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_Leave_1(object sender, EventArgs e)
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

        private void contact_Leave_1(object sender, EventArgs e)
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

        private void textBox1_Leave_1(object sender, EventArgs e)
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

        private void id_KeyPress_1(object sender, KeyPressEventArgs e)
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
        private void contact_KeyPress_1(object sender, KeyPressEventArgs e)
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
        private void salary_KeyPress_1(object sender, KeyPressEventArgs e)
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
                MessageBox.Show("Please enter a valid salary, use digits only!");
            }
        }
        private void name_KeyPress_1(object sender, KeyPressEventArgs e)
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
    }
}

