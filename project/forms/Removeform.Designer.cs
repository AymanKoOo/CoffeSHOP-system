﻿namespace project.forms
{
    partial class Removeform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Removeform));
            this.panelremove = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.remove = new Bunifu.Framework.UI.BunifuThinButton2();
            this.button15 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelremove
            // 
            this.panelremove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(141)))), ((int)(((byte)(158)))));
            this.panelremove.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelremove.Location = new System.Drawing.Point(0, 0);
            this.panelremove.Name = "panelremove";
            this.panelremove.Size = new System.Drawing.Size(250, 13);
            this.panelremove.TabIndex = 23;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 24);
            this.textBox1.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(141)))), ((int)(((byte)(158)))));
            this.label3.Location = new System.Drawing.Point(21, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Product Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(3, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Enter Name Of Product";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // remove
            // 
            this.remove.ActiveBorderThickness = 1;
            this.remove.ActiveCornerRadius = 20;
            this.remove.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(141)))), ((int)(((byte)(158)))));
            this.remove.ActiveForecolor = System.Drawing.Color.White;
            this.remove.ActiveLineColor = System.Drawing.Color.White;
            this.remove.BackColor = System.Drawing.Color.White;
            this.remove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("remove.BackgroundImage")));
            this.remove.ButtonText = "Remove";
            this.remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.remove.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove.ForeColor = System.Drawing.Color.White;
            this.remove.IdleBorderThickness = 1;
            this.remove.IdleCornerRadius = 20;
            this.remove.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(141)))), ((int)(((byte)(158)))));
            this.remove.IdleForecolor = System.Drawing.Color.White;
            this.remove.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(141)))), ((int)(((byte)(158)))));
            this.remove.Location = new System.Drawing.Point(19, 147);
            this.remove.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(199, 44);
            this.remove.TabIndex = 34;
            this.remove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // button15
            // 
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.ForeColor = System.Drawing.Color.Transparent;
            this.button15.Image = ((System.Drawing.Image)(resources.GetObject("button15.Image")));
            this.button15.Location = new System.Drawing.Point(210, 19);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(40, 41);
            this.button15.TabIndex = 43;
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // Removeform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(250, 205);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panelremove);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Removeform";
            this.Text = "Removeform";
            this.Load += new System.EventHandler(this.Removeform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelremove;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 remove;
        private System.Windows.Forms.Button button15;
    }
}