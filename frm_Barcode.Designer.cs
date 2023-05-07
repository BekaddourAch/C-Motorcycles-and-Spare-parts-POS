namespace Disdriver
{
    partial class frm_Barcode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Barcode));
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrnt = new DevExpress.XtraEditors.SimpleButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblFactNumAuto = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblArticle = new System.Windows.Forms.Label();
            this.lblPrix = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtArticle = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.Label();
            this.txtPrix = new System.Windows.Forms.Label();
            this.lblShow = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtArticle);
            this.panel1.Controls.Add(this.txtBarcode);
            this.panel1.Controls.Add(this.txtPrix);
            this.panel1.Controls.Add(this.lblShow);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 408);
            this.panel1.TabIndex = 0;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(214, 153);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(158, 22);
            this.checkBox2.TabIndex = 14;
            this.checkBox2.Text = "عرض سعر السلعة";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Click += new System.EventHandler(this.checkBox2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(214, 125);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(156, 22);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "عرض أسم السلعة";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.simpleButton1);
            this.panel4.Controls.Add(this.btnPrnt);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 331);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(473, 77);
            this.panel4.TabIndex = 12;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(159)))), ((int)(((byte)(31)))));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.simpleButton1.Location = new System.Drawing.Point(145, 20);
            this.simpleButton1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(175, 44);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "معاينة و طباعة";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnPrnt
            // 
            this.btnPrnt.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(159)))), ((int)(((byte)(31)))));
            this.btnPrnt.Appearance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrnt.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnPrnt.Appearance.Options.UseBackColor = true;
            this.btnPrnt.Appearance.Options.UseFont = true;
            this.btnPrnt.Appearance.Options.UseForeColor = true;
            this.btnPrnt.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnPrnt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrnt.ImageOptions.Image")));
            this.btnPrnt.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnPrnt.Location = new System.Drawing.Point(145, 20);
            this.btnPrnt.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnPrnt.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrnt.Name = "btnPrnt";
            this.btnPrnt.Size = new System.Drawing.Size(175, 44);
            this.btnPrnt.TabIndex = 8;
            this.btnPrnt.Text = "طباعة مباشرة";
            this.btnPrnt.Click += new System.EventHandler(this.btnPrnt_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel5.Controls.Add(this.lblFactNumAuto);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.lblArticle);
            this.panel5.Controls.Add(this.lblPrix);
            this.panel5.Location = new System.Drawing.Point(13, 15);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(447, 98);
            this.panel5.TabIndex = 1;
            // 
            // lblFactNumAuto
            // 
            this.lblFactNumAuto.AutoSize = true;
            this.lblFactNumAuto.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFactNumAuto.ForeColor = System.Drawing.Color.Black;
            this.lblFactNumAuto.Location = new System.Drawing.Point(38, 29);
            this.lblFactNumAuto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFactNumAuto.Name = "lblFactNumAuto";
            this.lblFactNumAuto.Size = new System.Drawing.Size(0, 23);
            this.lblFactNumAuto.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 4);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Num Facture رقم الفاتورة  ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(292, 59);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "سعر السلعة";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(292, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "إسم السلعة";
            // 
            // lblArticle
            // 
            this.lblArticle.AutoSize = true;
            this.lblArticle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticle.ForeColor = System.Drawing.Color.Black;
            this.lblArticle.Location = new System.Drawing.Point(66, 35);
            this.lblArticle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArticle.Name = "lblArticle";
            this.lblArticle.Size = new System.Drawing.Size(95, 16);
            this.lblArticle.TabIndex = 10;
            this.lblArticle.Text = "Nouveau nom";
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.BackColor = System.Drawing.Color.Transparent;
            this.lblPrix.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrix.ForeColor = System.Drawing.Color.Black;
            this.lblPrix.Location = new System.Drawing.Point(75, 59);
            this.lblPrix.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(48, 16);
            this.lblPrix.TabIndex = 10;
            this.lblPrix.Text = "10000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(243, 344);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "عدد الملصقات";
            // 
            // txtArticle
            // 
            this.txtArticle.AutoSize = true;
            this.txtArticle.BackColor = System.Drawing.Color.White;
            this.txtArticle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArticle.ForeColor = System.Drawing.Color.Black;
            this.txtArticle.Location = new System.Drawing.Point(142, 276);
            this.txtArticle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtArticle.Name = "txtArticle";
            this.txtArticle.Size = new System.Drawing.Size(83, 14);
            this.txtArticle.TabIndex = 10;
            this.txtArticle.Text = "Nouveau nom";
            // 
            // txtBarcode
            // 
            this.txtBarcode.AutoSize = true;
            this.txtBarcode.BackColor = System.Drawing.Color.White;
            this.txtBarcode.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.ForeColor = System.Drawing.Color.Black;
            this.txtBarcode.Location = new System.Drawing.Point(200, 258);
            this.txtBarcode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(72, 16);
            this.txtBarcode.TabIndex = 10;
            this.txtBarcode.Text = "23203232";
            // 
            // txtPrix
            // 
            this.txtPrix.AutoSize = true;
            this.txtPrix.BackColor = System.Drawing.Color.White;
            this.txtPrix.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrix.ForeColor = System.Drawing.Color.Black;
            this.txtPrix.Location = new System.Drawing.Point(181, 296);
            this.txtPrix.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(116, 16);
            this.txtPrix.TabIndex = 10;
            this.txtPrix.Text = "Prix: 1000.00 DA";
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.BackColor = System.Drawing.Color.White;
            this.lblShow.Font = new System.Drawing.Font("Free 3 of 9 Extended", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShow.ForeColor = System.Drawing.Color.Black;
            this.lblShow.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblShow.Location = new System.Drawing.Point(116, 209);
            this.lblShow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShow.MinimumSize = new System.Drawing.Size(250, 110);
            this.lblShow.Name = "lblShow";
            this.lblShow.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblShow.Size = new System.Drawing.Size(250, 110);
            this.lblShow.TabIndex = 10;
            this.lblShow.Text = "azerty";
            this.lblShow.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(272, 189);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "ملصق الباركود";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Tahoma", 18.25F);
            this.numericUpDown1.Location = new System.Drawing.Point(116, 334);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 37);
            this.numericUpDown1.TabIndex = 13;
            // 
            // frm_Barcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 408);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_Barcode";
            this.Text = "b";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblArticle;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.SimpleButton btnPrnt;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblFactNumAuto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtPrix;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.Label txtArticle;
        private System.Windows.Forms.Label txtBarcode;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}