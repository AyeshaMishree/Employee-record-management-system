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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.NetworkInformation;
using System.Collections;
using System.Configuration;

namespace EmployeeManagement
{
    public partial class delete_records : Form
    {
        public delete_records()
        {
            InitializeComponent();
        }
            void Getemployee()
            {
                conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0; Data Source = dbtk.accdb");
                dt = new DataTable();
                adapter = new OleDbDataAdapter("SELECT *FROM employee", conn);
                conn.Open();
                adapter.Fill(dt);
                dgvdisplay.DataSource = dt;
                conn.Close();
            }

        private void dgvdisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            Add_Record myform = new Add_Record();
            // string query = "insert into employee  values  (@id,@name,@gender,@contactno,@emailaddress,@designation,@salary,@dateofhiring,@dateoffiring)";

            //string query = "INSERT INTO employee (ID, NAME,GENDER,CONTACT NO,EMAIL ADDRESS,DESIGNATION,SALARY,DATE OF HIRING,DATE OF FIRING) VALUES" +
            // "(@name,@gender,@contactno,@emailaddress,@designation,@salary,@dateofhiring,@dateoffiring)";

            // cmd = new OleDbCommand(query, conn);
            cmd = new OleDbCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from employee";
            dt = new DataTable();
            cmd.ExecuteNonQuery();
            dgvdisplay.DataSource = dt;
            myform.id.Text = dgvdisplay.CurrentRow.Cells[0].Value.ToString();
            myform.name.Text = dgvdisplay.CurrentRow.Cells[1].Value.ToString();
            myform.gender.Text = dgvdisplay.CurrentRow.Cells[2].Value.ToString();
            myform.contact.Text = dgvdisplay.CurrentRow.Cells[3].Value.ToString();
            myform.email.Text = dgvdisplay.CurrentRow.Cells[4].Value.ToString();
            myform.des.Text = dgvdisplay.CurrentRow.Cells[5].Value.ToString();
            myform.salary.Text = dgvdisplay.CurrentRow.Cells[6].Value.ToString();
            myform.doh1.Text = dgvdisplay.CurrentRow.Cells[7].Value.ToString();
            myform.dol.Text = dgvdisplay.CurrentRow.Cells[8].Value.ToString();
            myform.ShowDialog();
        }


        OleDbDataAdapter adp;
        DataSet ds;
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        DataTable dt;
        int a = 0;
        int row = 0;

        OleDbConnection con;
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int n = dgvdisplay.Rows.Add();
            string id = dgvdisplay[0, row].Value.ToString();
            cmd.CommandText = "delete from employee where id=" + id;
            cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Record is Deleted");
                adp = new OleDbDataAdapter("select * from employee", con);
                ds = new DataSet();
                adp.Fill(ds, "employee");
                dgvdisplay.DataSource = ds.Tables["employee"];
            }
        }
        
        private void dgvdisplay_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
        }

        private void view_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            OleDbConnection con = new OleDbConnection(cs);
            con.Open();
            adp = new OleDbDataAdapter("select * from employees ", con);
            ds = new DataSet();
            adp.Fill(ds, "employee");
            dgvdisplay.DataSource = ds.Tables["employee"];
            con.Close();
        }
        private void btndelete_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            OleDbConnection con = new OleDbConnection(cs);
            con.Open();
            adp = new OleDbDataAdapter("delete from employee where name='" + deletename.Text + "'", con);
            ds = new DataSet();
            adp.Fill(ds, "employee");
            dgvdisplay.DataSource = ds.Tables["employee"];
            con.Close();
            MessageBox.Show("Record deleted successfully");
        }

        private void delete_records_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            OleDbConnection con = new OleDbConnection(cs);
            con.Open();
            adp = new OleDbDataAdapter("delete from employee where name='" + deletename.Text + "'", con);
            ds = new DataSet();
            adp.Fill(ds, "employee");
            dgvdisplay.DataSource = ds.Tables["employee"];
            con.Close();
            MessageBox.Show("Record deleted successfully!");
        }

        private void view_Click_1(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            OleDbConnection con = new OleDbConnection(cs);
            con.Open();
            adp = new OleDbDataAdapter("select * from employee ", con);
            ds = new DataSet();
            adp.Fill(ds, "employee");
            dgvdisplay.DataSource = ds.Tables["employee"];
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            welcome back = new welcome();
            back.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void deletename_TextChanged(object sender, EventArgs e)
        {
            if (deletename.Text == "")
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }
    }
}
