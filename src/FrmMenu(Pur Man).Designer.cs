﻿namespace YummyRestaurantSystem
{
    partial class FrmMenuPurMan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPurMan));
            this.btnCreOrder = new System.Windows.Forms.Button();
            this.btnOrderMan = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblHelloMsg = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnCO = new System.Windows.Forms.Button();
            this.btnOM = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreOrder
            // 
            this.btnCreOrder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCreOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreOrder.ForeColor = System.Drawing.Color.Black;
            this.btnCreOrder.Location = new System.Drawing.Point(940, 229);
            this.btnCreOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreOrder.Name = "btnCreOrder";
            this.btnCreOrder.Size = new System.Drawing.Size(267, 125);
            this.btnCreOrder.TabIndex = 15;
            this.btnCreOrder.Text = "Create Order";
            this.btnCreOrder.UseVisualStyleBackColor = false;
            // 
            // btnOrderMan
            // 
            this.btnOrderMan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOrderMan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderMan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderMan.ForeColor = System.Drawing.Color.Black;
            this.btnOrderMan.Location = new System.Drawing.Point(392, 229);
            this.btnOrderMan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOrderMan.Name = "btnOrderMan";
            this.btnOrderMan.Size = new System.Drawing.Size(267, 125);
            this.btnOrderMan.TabIndex = 14;
            this.btnOrderMan.Text = "Order Manage";
            this.btnOrderMan.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnLogout.Location = new System.Drawing.Point(1244, 35);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(168, 39);
            this.btnLogout.TabIndex = 13;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblHelloMsg
            // 
            this.lblHelloMsg.AutoSize = true;
            this.lblHelloMsg.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelloMsg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHelloMsg.Location = new System.Drawing.Point(379, 35);
            this.lblHelloMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHelloMsg.Name = "lblHelloMsg";
            this.lblHelloMsg.Size = new System.Drawing.Size(235, 32);
            this.lblHelloMsg.TabIndex = 12;
            this.lblHelloMsg.Text = "Hello [UserName]!";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.btnCO);
            this.panel1.Controls.Add(this.btnOM);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 744);
            this.panel1.TabIndex = 100;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button4.Location = new System.Drawing.Point(200, 688);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 39);
            this.button4.TabIndex = 97;
            this.button4.Text = "Logout";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(25, 701);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(37, 15);
            this.lblTime.TabIndex = 96;
            this.lblTime.Text = "Time";
            // 
            // btnCO
            // 
            this.btnCO.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCO.ForeColor = System.Drawing.Color.Black;
            this.btnCO.Location = new System.Drawing.Point(16, 408);
            this.btnCO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCO.Name = "btnCO";
            this.btnCO.Size = new System.Drawing.Size(271, 44);
            this.btnCO.TabIndex = 95;
            this.btnCO.Text = "Create Order";
            this.btnCO.UseVisualStyleBackColor = false;
            // 
            // btnOM
            // 
            this.btnOM.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOM.ForeColor = System.Drawing.Color.Black;
            this.btnOM.Location = new System.Drawing.Point(16, 335);
            this.btnOM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOM.Name = "btnOM";
            this.btnOM.Size = new System.Drawing.Size(271, 44);
            this.btnOM.TabIndex = 94;
            this.btnOM.Text = "Order Manage";
            this.btnOM.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 35);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 218);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmMenuPurMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 744);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCreOrder);
            this.Controls.Add(this.btnOrderMan);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblHelloMsg);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMenuPurMan";
            this.Text = "Purchase Manager Menu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCreOrder;
        private System.Windows.Forms.Button btnOrderMan;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblHelloMsg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCO;
        private System.Windows.Forms.Button btnOM;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button4;
    }
}