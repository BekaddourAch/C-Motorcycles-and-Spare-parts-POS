namespace Disdriver
{
    partial class Server_Status
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUsrName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtPwd);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtUsrName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtDB);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtPort);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtHost);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 407);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(221, 348);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "Connect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(376, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(277, 281);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(192, 26);
            this.txtPwd.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(142, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "MySQL Password";
            // 
            // txtUsrName
            // 
            this.txtUsrName.Location = new System.Drawing.Point(277, 245);
            this.txtUsrName.Name = "txtUsrName";
            this.txtUsrName.Size = new System.Drawing.Size(192, 26);
            this.txtUsrName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "MySQL UserName";
            // 
            // txtDB
            // 
            this.txtDB.Location = new System.Drawing.Point(277, 205);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(192, 26);
            this.txtDB.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "MySQL Database";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(277, 167);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(192, 26);
            this.txtPort.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "MySQL Port";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(277, 129);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(192, 26);
            this.txtHost.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "MySQL Host";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Blue;
            this.lblStatus.Location = new System.Drawing.Point(248, 95);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 19);
            this.lblStatus.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Configuration Serveur ";
            // 
            // Server_Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 407);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Server_Status";
            this.Text = "Server_Status";
            this.Load += new System.EventHandler(this.Server_Status_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUsrName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStatus;
    }
}