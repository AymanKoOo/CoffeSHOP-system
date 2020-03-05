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
namespace project.forms
{
    public partial class Removeform : Form
    {
        public Removeform()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Teba\Desktop\CoffeShop DB.accdb");
        private void button61_Click(object sender, EventArgs e)
        {
           



        }

        private void Removeform_Load(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void remove_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open(); // open connection
                OleDbCommand cmd = new OleDbCommand(); // make object 
                cmd.Connection = con; // connect
                cmd.CommandText =
                "delete from tblProducts where productID=" + textBox1.Text + "";
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
    }
}
