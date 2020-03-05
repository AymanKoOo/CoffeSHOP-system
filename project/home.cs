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
using project.forms;
using System.Threading;
using System.Drawing.Printing;
using System.IO;

namespace project
{
    public partial class Home : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Teba\Desktop\CoffeShop DB.accdb");
        public int RowIndex = 0;
       
        public Home()
        {

            InitializeComponent();
            sidepanel.Height = drinkse.Height;
            sidepanel.Top = drinkse.Top;
            overs.BringToFront();
            orderpanel.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {

            add.Enabled = false;
            remove.Enabled = false;
            search.Enabled = false;
          //  txtsearch.Enabled = false;
            viewall.Enabled = false;
            update.Enabled = false;
            clear.Enabled = false;
            search.Enabled = false;
        }

       

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
      
         
        //  drink button //////////////////////////////////////////////////
        private void button1_Click(object sender, EventArgs e)
        {
            sidepanel.Height = drinkse.Height;
            sidepanel.Top = drinkse.Top;
            overs.BringToFront();

            orderpanel.BringToFront();
            
            flp.Controls.Clear();

         
            con.Open(); // open connection
            OleDbCommand cmd = new OleDbCommand(); // make object 
            cmd.Connection = con; // connect
            cmd.CommandText =
            "select * from tblProducts where category='Drink'";
            cmd.ExecuteNonQuery();

            OleDbDataAdapter dat = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            dat.Fill(dt);


            foreach (DataRow item in dt.Rows)
            {

                Button b = new Button();
                b.Size = new Size(100, 150);
                b.Text = item["productName"].ToString();

                b.Image = Image.FromFile("E:\\c.PNG");
                b.ForeColor = Color.Black;
                b.TextAlign = ContentAlignment.BottomCenter;
                b.Tag = item["productID"].ToString();
                int x = Convert.ToInt32(b.Tag);
                b.Click += B_Click1;

                flp.Controls.Add(b);
                con.Close();
            }
        }

        private void B_Click1(object sender, EventArgs e)
        {
            Button b = sender as Button;

            int id = Convert.ToInt32((b.Tag));

            filltable(id);
            con.Close();
        }


        public bool CheckProductAlreadyAdded(int ProductID)
        {
            foreach (DataGridViewRow Row in dataGridView2.Rows)
            {
                if (Convert.ToInt32(Row.Cells[0].Value) == ProductID)
                {
                    RowIndex = Row.Index;
                    return true;
                }
            }
            return false;
        }

        private void filltable(int id)
        {

            con.Close();

            con.Open(); // open connection
            OleDbCommand cmd = new OleDbCommand(); // make object 
            cmd.Connection = con; // connect                     
            cmd.CommandText = "select * from tblProducts where productID=" + id + "";

            cmd.ExecuteNonQuery();

            OleDbDataAdapter dat = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            dat.Fill(dt);


            int quanity = 1;
            foreach (DataRow item in dt.Rows)
            {


                if (CheckProductAlreadyAdded(id))
                {

                    // Product Alraedy Exists in Datagrid view 
                    int Quantity = Convert.ToInt32(dataGridView2.Rows[RowIndex].Cells[3].Value);
                    double Price = Convert.ToDouble(dataGridView2.Rows[RowIndex].Cells[2].Value);

                    Quantity++;

                    /////////////<Do thisssss...... Important.. Have decimal part in the total price>
                    double TotalPrice = Convert.ToDouble(Quantity * Price);

                    dataGridView2.Rows[RowIndex].Cells[3].Value = Quantity;
                    dataGridView2.Rows[RowIndex].Cells[4].Value = TotalPrice;

                }

                else
                {
                    int n = dataGridView2.Rows.Add();
                    quanity = 1;

                    dataGridView2.Rows[n].Cells[0].Value = item["productID"].ToString();
                    dataGridView2.Rows[n].Cells[1].Value = item["productName"].ToString();
                    dataGridView2.Rows[n].Cells[2].Value = item["price"].ToString();
                    dataGridView2.Rows[n].Cells[3].Value = quanity;
                    dataGridView2.Rows[n].Cells[4].Value = item["price"].ToString();

                }
            }
        }

    /// ///////////////////////////////////////////////////////////////////////////

    private void button3_Click(object sender, EventArgs e)
        {
            sidepanel.Height = cakes.Height;
            sidepanel.Top = cakes.Top;
            overs.BringToFront();

            orderpanel.BringToFront();


            flp.Controls.Clear();

            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText =
            "select * from tblProducts where category='Cake'"; 
            cmd.ExecuteNonQuery();

            OleDbDataAdapter dat = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            dat.Fill(dt);


            foreach (DataRow item in dt.Rows)
            {

                Button b = new Button();
                b.Size = new Size(100, 100);
                b.Text = item["productName"].ToString();
                b.Image = Image.FromFile("E:\\aa.PNG"); // Put source -> for Cake pic
                b.ForeColor = Color.Black;
                b.TextAlign = ContentAlignment.BottomCenter;
                b.Tag = item["productID"].ToString();
                int x = Convert.ToInt32(b.Tag);


                b.Click += B_Click1;

                flp.Controls.Add(b);
                con.Close();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            sidepanel.Height = foode.Height;
            sidepanel.Top = foode.Top;
            overs.BringToFront();

            orderpanel.BringToFront();
            flp.Controls.Clear();
            con.Open(); // open connection
            OleDbCommand cmd = new OleDbCommand(); // make object 
            cmd.Connection = con; // connect
            cmd.CommandText =
            "select * from tblProducts where category='Food'";
            cmd.ExecuteNonQuery();

            OleDbDataAdapter dat = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            dat.Fill(dt);


            foreach (DataRow item in dt.Rows)
            {

                Button b = new Button();
                b.Size = new Size(100, 100);
                b.Text = item["productName"].ToString();

                b.Image = Image.FromFile("E:\\food.PNG");
                b.ForeColor = Color.Black;
                b.TextAlign = ContentAlignment.BottomCenter;


                b.Tag = item["productID"].ToString();
                int x = Convert.ToInt32(b.Tag);



                b.Click += B_Click1;

                flp.Controls.Add(b);
                con.Close();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            sidepanel.Height = adminee.Height;
            sidepanel.Top = adminee.Top;
            adminpanel.BringToFront();
          
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button32_Click(object sender, EventArgs e)
        {

        }

        private void button34_Click(object sender, EventArgs e)
        {

            sidepanel.Height = hot_drinks.Height;
            sidepanel.Top = hot_drinks.Top;
            overs.BringToFront();

  
            
            flp.Controls.Clear();
           
            con.Open(); 
            OleDbCommand cmd = new OleDbCommand(); 
            cmd.Connection = con; 
            cmd.CommandText =
            "select * from tblProducts where category='Cake'"; // Data Base HotDrinks row in cataegory
            cmd.ExecuteNonQuery();

            OleDbDataAdapter dat = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            dat.Fill(dt);


            foreach (DataRow item in dt.Rows)
            {

                Button b = new Button();
                b.Size = new Size(100, 100);
                b.Text = item["productName"].ToString();
                b.Image = Image.FromFile("E:\\aa.PNG"); // Put source -> for HotDrinks pic
                b.ForeColor = Color.Black;
                b.TextAlign = ContentAlignment.BottomCenter;
                b.Tag = item["productID"].ToString();
                int x = Convert.ToInt32(b.Tag);


                b.Click += B_Click1;

                flp.Controls.Add(b);
                con.Close();
            }


        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void overs_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button63_Click(object sender, EventArgs e)
        {

        }

        private void overs_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void admine1_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin2_Click(object sender, EventArgs e)
        {

            OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Teba\Desktop\CoffeShop DB.accdb");
            con.Open();
            //OleDbDataAdapter ada = new OleDbDataAdapter("Select Count (*)From Login Where Username='" + user_name.Text + "'and Password='" + password.Text + "'", con);
            //DataTable dt = new DataTable();
            //ada.Fill(dt);

            //if (dt.Rows[0][0].ToString() == "1")
            //{

                add.Enabled = true;
                remove.Enabled = true;
                search.Enabled = false;
               // txtsearch.Enabled = true;
                viewall.Enabled = true;
                update.Enabled = true;
                clear.Enabled = true;
                search.Enabled = true;
            //}
            //else
            //{
            //    MessageBox.Show("please check username or password");
            //}
            //con.Close();
        }

        private void d1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            addform ob1 = new addform();
            ob1.Show();
        }

        private void remove_Click(object sender, EventArgs e)
        {
            Removeform ob1 = new Removeform();
            ob1.Show();
        }

        private void update_Click(object sender, EventArgs e)
        {
            updateform ob1 = new updateform();
            ob1.Show();
        }

        private void viewall_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open(); // open connection
                OleDbCommand cmd = new OleDbCommand(); // make object 
                cmd.Connection = con; // connect
                cmd.CommandText = "select * from tblProducts";
                cmd.ExecuteNonQuery();

                OleDbDataAdapter dat = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                dat.Fill(dt);

                dataGridView1.Rows.Clear();

                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();

                    dataGridView1.Rows[n].Cells[0].Value = item["productID"].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item["productName"].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item["price"].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = item["category"].ToString();

                }

                con.Close();
            }
            catch
            {
                MessageBox.Show("Error");
                con.Close();
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open(); // open connection
                OleDbCommand cmd = new OleDbCommand(); // make object 
                cmd.Connection = con; // connect                     
                cmd.CommandText = "select * from tblProducts where productID=" + textBox1.Text + "";

                cmd.ExecuteNonQuery();

                OleDbDataAdapter dat = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                dat.Fill(dt);
                dataGridView1.Rows.Clear();


                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();

                    dataGridView1.Rows[n].Cells[0].Value = item["productID"].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item["productName"].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item["price"].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = item["category"].ToString();
                }

                con.Close();

            }

            catch
            {
                MessageBox.Show("Not Found");
                con.Close();
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void adminpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cakess_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open(); // open connection
                OleDbCommand cmd = new OleDbCommand(); // make object 
                cmd.Connection = con; // connect
                cmd.CommandText =
                "select * from tblProducts where category='Cake'";
                cmd.ExecuteNonQuery();

                OleDbDataAdapter dat = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                dat.Fill(dt);

                dataGridView1.Rows.Clear();

                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();

                    dataGridView1.Rows[n].Cells[0].Value = item["productID"].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item["productName"].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item["price"].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = item["category"].ToString();
                }

                con.Close();
            }
            catch
            {
                MessageBox.Show("Error");
                con.Close();
            }
        }

        private void foodss_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open(); // open connection
                OleDbCommand cmd = new OleDbCommand(); // make object 
                cmd.Connection = con; // connect
                cmd.CommandText =
                "select * from tblProducts where category='Food'";
                cmd.ExecuteNonQuery();

                OleDbDataAdapter dat = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                dat.Fill(dt);

                dataGridView1.Rows.Clear();

                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();

                    dataGridView1.Rows[n].Cells[0].Value = item["productID"].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item["productName"].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item["price"].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = item["category"].ToString();
                }

                con.Close();
            }

            catch
            {
                MessageBox.Show("Error");
                con.Close();
            }
        }

        private void drinkss_Click(object sender, EventArgs e)
        {

            con.Open(); // open connection
            OleDbCommand cmd = new OleDbCommand(); // make object 
            cmd.Connection = con; // connect
            cmd.CommandText =
            "select * from tblProducts where category='Drink'";
            cmd.ExecuteNonQuery();

            OleDbDataAdapter dat = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            dat.Fill(dt);

            dataGridView1.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();

                dataGridView1.Rows[n].Cells[0].Value = item["productID"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["productName"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["price"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["category"].ToString();
            }

            con.Close();

        }

      
       

        

        private void button3_Click_1(object sender, EventArgs e)
        {
            double sum = 0.0;

            for (int i = 0; i <= dataGridView2.Rows.Count - 1; i++)
            {
                sum = sum + double.Parse(dataGridView2.Rows[i].Cells[4].Value.ToString());
            }

            label4.Text = sum.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            label4.Text = "0";
            label5.Text = "....";
            label10.Text = "....";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                Random rnd = new Random();
                int number1 = rnd.Next(10000, 133333);
                int number2 = rnd.Next(100600, 133333);
                con.Open(); // open connection

                OleDbCommand cmd = new OleDbCommand(); // make object 
                cmd.Connection = con; // connect
                cmd.CommandText =
    "insert into tblTransactions values('" + number2 + "','" + DateTime.Now + "')";
                label5.Text = number2.ToString();
                label10.Text = DateTime.Now.ToString();
                cmd.ExecuteNonQuery();
                con.Close();

                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {

                    con.Open();
                    cmd.CommandText =
            "insert into tblTransactrionItem values('" + number1 + "','" + number2 + "','" + dataGridView2.Rows[i].Cells[0].Value + "','" + dataGridView2.Rows[i].Cells[3].Value + "')";
                    number1++;


                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                MessageBox.Show("Transaction Done");
                PrintRecipt();

            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void PrintRecipt()
        {
            PrintDialog printDialog = new PrintDialog();

            System.Drawing.Printing.PrintDocument printDocument = new PrintDocument();

            printDialog.Document = printDocument;

            printDocument.PrintPage += PrintDocument_PrintPage;

            DialogResult result = printDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                printDocument.Print();
            }

        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            string underline = "---------------------------------";
            string line = "_________________________________";
            string transactionID = label5.Text;
            string date = label10.Text;
            Graphics graphic = e.Graphics;

            Font font = new Font("Courier new", 12);
            float fontheight = font.GetHeight();
            int startX = 10;
            int startY = 10;
            int offset = 40;

            graphic.DrawString(line, font, new SolidBrush(Color.Black), startX, startY);
            graphic.DrawString("CoffeShop".PadLeft(16), new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontheight + 5;
            graphic.DrawString(underline, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontheight + 5;
            graphic.DrawString("Invoice ID:  #" + transactionID, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontheight + 5;
            graphic.DrawString("Invoice Date:" + date, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontheight + 5;
            graphic.DrawString(underline, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontheight + 5;
            graphic.DrawString(("QTY".PadRight(5) + "Name".PadRight(10) + "Price".PadRight(10) + "Total".PadRight(25)), font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontheight + 5;

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {

                string productName = row.Cells[1].Value.ToString();
                string productPrice = row.Cells[2].Value.ToString();
                string productQuantity = row.Cells[3].Value.ToString();
                string productTotalPrice = row.Cells[4].Value.ToString();

                string productline = productQuantity + productName + productPrice + productTotalPrice;

                //  graphic.DrawString(productline.PadRight(20), font, new SolidBrush(Color.Black), startX, startY + offset);
                graphic.DrawString(underline, font, new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)fontheight + 5;
                graphic.DrawString(productQuantity.PadRight(5) + productName.PadRight(10) + productPrice.PadRight(10) + productTotalPrice.PadRight(25), font, new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)fontheight + 5;

            }

            graphic.DrawString(line, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontheight + 5;

            string subtotal = label1.Text;

            string totalprice = (Convert.ToString((Convert.ToDouble(subtotal) + 5)));

            //offset = offset + 20;

            graphic.DrawString("Sub-total".PadRight(25) + String.Format("$" + subtotal), font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontheight + 5;
            graphic.DrawString(underline, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontheight + 5;
            graphic.DrawString("Sales Tax".PadRight(25) + String.Format("$5"), font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontheight + 5;
            graphic.DrawString(underline, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontheight + 5;
            Font font2 = new Font("Algerian", 14, FontStyle.Bold);

            graphic.DrawString("Total".PadRight(40) + String.Format("$" + totalprice), font2, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontheight + 5;
            graphic.DrawString(line, font, new SolidBrush(Color.Black), startX, startY);

        }

        private void txtsearch_OnTextChange(object sender, EventArgs e)
        {
           


        }
    }
}

    
