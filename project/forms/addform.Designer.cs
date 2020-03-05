namespace project.forms
{
    partial class addform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addform));
            this.price = new System.Windows.Forms.TextBox();
            this.productname = new System.Windows.Forms.TextBox();
            this.productid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelremove = new System.Windows.Forms.Panel();
            this.add = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.button15 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(157, 179);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(180, 24);
            this.price.TabIndex = 16;
            // 
            // productname
            // 
            this.productname.Location = new System.Drawing.Point(157, 137);
            this.productname.Name = "productname";
            this.productname.Size = new System.Drawing.Size(180, 24);
            this.productname.TabIndex = 15;
            // 
            // productid
            // 
            this.productid.Location = new System.Drawing.Point(157, 88);
            this.productid.Name = "productid";
            this.productid.Size = new System.Drawing.Size(180, 24);
            this.productid.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(141)))), ((int)(((byte)(158)))));
            this.label3.Location = new System.Drawing.Point(10, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Product ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(141)))), ((int)(((byte)(158)))));
            this.label1.Location = new System.Drawing.Point(10, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(141)))), ((int)(((byte)(158)))));
            this.label2.Location = new System.Drawing.Point(10, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(141)))), ((int)(((byte)(158)))));
            this.label4.Location = new System.Drawing.Point(10, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Catagory";
            // 
            // panelremove
            // 
            this.panelremove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(141)))), ((int)(((byte)(158)))));
            this.panelremove.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelremove.Location = new System.Drawing.Point(0, 0);
            this.panelremove.Name = "panelremove";
            this.panelremove.Size = new System.Drawing.Size(389, 13);
            this.panelremove.TabIndex = 32;
            // 
            // add
            // 
            this.add.ActiveBorderThickness = 1;
            this.add.ActiveCornerRadius = 20;
            this.add.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(141)))), ((int)(((byte)(158)))));
            this.add.ActiveForecolor = System.Drawing.Color.White;
            this.add.ActiveLineColor = System.Drawing.Color.White;
            this.add.BackColor = System.Drawing.Color.White;
            this.add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add.BackgroundImage")));
            this.add.ButtonText = "ADD";
            this.add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.Color.White;
            this.add.IdleBorderThickness = 1;
            this.add.IdleCornerRadius = 20;
            this.add.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(141)))), ((int)(((byte)(158)))));
            this.add.IdleForecolor = System.Drawing.Color.White;
            this.add.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(141)))), ((int)(((byte)(158)))));
            this.add.Location = new System.Drawing.Point(14, 302);
            this.add.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(343, 74);
            this.add.TabIndex = 34;
            this.add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // button15
            // 
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.ForeColor = System.Drawing.Color.Transparent;
            this.button15.Image = ((System.Drawing.Image)(resources.GetObject("button15.Image")));
            this.button15.Location = new System.Drawing.Point(332, 19);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(46, 51);
            this.button15.TabIndex = 36;
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Drink",
            "Cake",
            "Food"});
            this.comboBox1.Location = new System.Drawing.Point(157, 227);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 24);
            this.comboBox1.TabIndex = 37;
            // 
            // addform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(389, 405);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.add);
            this.Controls.Add(this.panelremove);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.price);
            this.Controls.Add(this.productname);
            this.Controls.Add(this.productid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addform";
            this.Text = "addform";
            this.Load += new System.EventHandler(this.addform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox productname;
        private System.Windows.Forms.TextBox productid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelremove;
        private Bunifu.Framework.UI.BunifuThinButton2 add;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}