using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagement
{
    using System.IO;
    using System.Security.Policy;
    using System.Xml.Linq;
    using System;
    using System.Collections;

    namespace PROJECT
    {
       
    }
            public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        private void welcome_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Record ar= new Add_Record();
            ar.ShowDialog();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            update up = new update();
            up.Show();
            this.Hide();
           
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btndisplay1rec_Click(object sender, EventArgs e)
        {

            delete_records dltrecord = new delete_records();
            dltrecord.ShowDialog();
            this.Hide();


        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            Display_all_Record dis = new Display_all_Record();
            dis.Show();
            this.Hide();

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            delete_records dlt = new delete_records();
            dlt.ShowDialog();
            this.Hide();

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            update upd = new update();
            upd.ShowDialog();
            this.Hide();

        }

        private void btndltrec_Click(object sender, EventArgs e)
        {
            delete_records dltrec = new delete_records();
            dltrec.ShowDialog();
            this.Hide();

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
           // this.Close();
            Form1 back = new Form1();
            back.Show();
            this.Hide();
        }

        private void btnsign_Click(object sender, EventArgs e)
        {
           // this.Close();
            Signup back = new Signup();
            back.Show();
            this.Hide();
            Signup sign = new Signup();  
            sign.ShowDialog();
        }
    }
}
