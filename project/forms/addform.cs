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
using System.IO;

namespace project.forms
{
    public partial class addform : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Teba\Desktop\CoffeShop DB.accdb");

        public addform()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void addform_Load(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {

                

                con.Open(); // open connection
                OleDbCommand cmd = new OleDbCommand(); // make object 
                cmd.Connection = con; // connect

                

                cmd.CommandText =
    "insert into tblProducts values('" + productid.Text + "','" + productname.Text + "' ,'" + price.Text + "','" + comboBox1.Text + "');";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Done");

                this.Close();
           }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

       
        private void button15_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void catagory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
