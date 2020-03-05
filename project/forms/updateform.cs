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
    public partial class updateform : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Teba\Desktop\CoffeShop DB.accdb");

        public updateform()
        {
            InitializeComponent();
        }

        private void remove_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open(); // open connection
                OleDbCommand cmd = new OleDbCommand(); // make object 
                cmd.Connection = con; // connect
                cmd.CommandText =
                "update  tblProducts set productName='" + txtup1.Text + "' where productName='" + txtold.Text + "'";
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void updateform_Load(object sender, EventArgs e)
        {

        }
    }
}
