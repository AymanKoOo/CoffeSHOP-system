namespace project.forms
{
    partial class updateform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updateform));
            this.update = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtup1 = new System.Windows.Forms.TextBox();
            this.panelremove = new System.Windows.Forms.Panel();
            this.txtold = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.button15 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // update
            // 
            this.update.ActiveBorderThickness = 1;
            this.update.ActiveCornerRadius = 20;
            this.update.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(141)))), ((int)(((byte)(158)))));
            this.update.ActiveForecolor = System.Drawing.Color.White;
            this.update.ActiveLineColor = System.Drawing.Color.White;
            this.update.BackColor = System.Drawing.Color.White;
            this.update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("update.BackgroundImage")));
            this.update.ButtonText = "Update";
            this.update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.Color.White;
            this.update.IdleBorderThickness = 1;
            this.update.IdleCornerRadius = 20;
            this.update.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(141)))), ((int)(((byte)(158)))));
            this.update.IdleForecolor = System.Drawing.Color.White;
            this.update.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(141)))), ((int)(((byte)(158)))));
            this.update.Location = new System.Drawing.Point(34, 214);
            this.update.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(227, 44);
            this.update.TabIndex = 38;
            this.update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.update.Click += new System.EventHandler(this.remove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(7, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Enter New Name Of Product";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(141)))), ((int)(((byte)(158)))));
            this.label3.Location = new System.Drawing.Point(42, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "New Product Name";
            // 
            // txtup1
            // 
            this.txtup1.Location = new System.Drawing.Point(40, 118);
            this.txtup1.Name = "txtup1";
            this.txtup1.Size = new System.Drawing.Size(221, 22);
            this.txtup1.TabIndex = 35;
            // 
            // panelremove
            // 
            this.panelremove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(141)))), ((int)(((byte)(158)))));
            this.panelremove.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelremove.Location = new System.Drawing.Point(0, 0);
            this.panelremove.Name = "panelremove";
            this.panelremove.Size = new System.Drawing.Size(317, 13);
            this.panelremove.TabIndex = 39;
            // 
            // txtold
            // 
            this.txtold.Location = new System.Drawing.Point(40, 175);
            this.txtold.Name = "txtold";
            this.txtold.Size = new System.Drawing.Size(221, 22);
            this.txtold.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(141)))), ((int)(((byte)(158)))));
            this.label2.Location = new System.Drawing.Point(38, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Product Name";
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
            this.button15.Location = new System.Drawing.Point(250, 19);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(55, 44);
            this.button15.TabIndex = 42;
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // updateform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(317, 271);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtold);
            this.Controls.Add(this.panelremove);
            this.Controls.Add(this.update);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtup1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "updateform";
            this.Text = "updateform";
            this.Load += new System.EventHandler(this.updateform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtup1;
        private System.Windows.Forms.Panel panelremove;
        private System.Windows.Forms.TextBox txtold;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button button15;
    }
}