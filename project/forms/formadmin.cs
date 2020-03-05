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
using System.Threading;

namespace project.forms
{
    public partial class formadmin : Form
    {
        public formadmin()
        {
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
        }
        public void StartForm()
        {
            Application.Run(new splashscreen());
        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void formadmin_Load(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
           
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\YOUSSEF_SAMY\source\repos\project\project\LOGIN.accdb;Persist Security Info=True");
            OleDbDataAdapter ada = new OleDbDataAdapter("Select Count (*)From Login Where Username='"+ username.Text+"'and Password='" + Passwordadmin.Text+"'",con);
            DataTable dt = new DataTable();
            ada.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Home obj = new Home();
                obj.Show(); 
            }
            else
            {
                MessageBox.Show("please check username or password");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
