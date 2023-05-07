namespace Disdriver
{
    partial class frm_transactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_transactions));
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnGet = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.txtMont = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblMont = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxCaise = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtRemq = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.btnGet);
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 419);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(507, 66);
            this.panel4.TabIndex = 5;
            // 
            // btnGet
            // 
            this.btnGet.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(159)))), ((int)(((byte)(31)))));
            this.btnGet.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGet.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnGet.Appearance.Options.UseBackColor = true;
            this.btnGet.Appearance.Options.UseFont = true;
            this.btnGet.Appearance.Options.UseForeColor = true;
            this.btnGet.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnGet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGet.ImageOptions.Image")));
            this.btnGet.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnGet.Location = new System.Drawing.Point(82, 1);
            this.btnGet.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(117, 65);
            this.btnGet.TabIndex = 5;
            this.btnGet.Text = "سحب\r\nRetrait";
            this.btnGet.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(50)))));
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Appearance.Options.UseBackColor = true;
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Appearance.Options.UseForeColor = true;
            this.btnAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(294, 1);
            this.btnAdd.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 65);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "دفع\r\nPayer";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtMont
            // 
            this.txtMont.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMont.Location = new System.Drawing.Point(139, 166);
            this.txtMont.Name = "txtMont";
            this.txtMont.Size = new System.Drawing.Size(219, 30);
            this.txtMont.TabIndex = 15;
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(139, 214);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(219, 26);
            this.dtpDate.TabIndex = 14;
            this.dtpDate.Value = new System.DateTime(2020, 7, 26, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(383, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "بتاريخ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(48, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Daté Le";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(37)))));
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.txtNom);
            this.panel2.Controls.Add(this.txtMont);
            this.panel2.Controls.Add(this.dtpDate);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.txtRemq);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(507, 419);
            this.panel2.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(84)))), ((int)(((byte)(157)))));
            this.panel5.Controls.Add(this.lblMont);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.cbxCaise);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(0, 46);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(507, 104);
            this.panel5.TabIndex = 17;
            // 
            // lblMont
            // 
            this.lblMont.AutoSize = true;
            this.lblMont.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMont.ForeColor = System.Drawing.Color.White;
            this.lblMont.Location = new System.Drawing.Point(34, 71);
            this.lblMont.Name = "lblMont";
            this.lblMont.Size = new System.Drawing.Size(144, 21);
            this.lblMont.TabIndex = 10;
            this.lblMont.Text = "3250000.00 DA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(301, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "رصيد الخزينة المحددة هو";
            // 
            // cbxCaise
            // 
            this.cbxCaise.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxCaise.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxCaise.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCaise.ForeColor = System.Drawing.Color.Black;
            this.cbxCaise.FormattingEnabled = true;
            this.cbxCaise.Location = new System.Drawing.Point(114, 29);
            this.cbxCaise.Name = "cbxCaise";
            this.cbxCaise.Size = new System.Drawing.Size(276, 26);
            this.cbxCaise.TabIndex = 8;
            this.cbxCaise.DropDownClosed += new System.EventHandler(this.cbxCaise_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(111, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Choisissez la caisse";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(301, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "أختر الخزينة";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(507, 47);
            this.panel3.TabIndex = 16;
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(139, 261);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(219, 26);
            this.txtNom.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(383, 319);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 18);
            this.label14.TabIndex = 10;
            this.label14.Text = "ملاحظات";
            // 
            // txtRemq
            // 
            this.txtRemq.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemq.Location = new System.Drawing.Point(139, 319);
            this.txtRemq.Multiline = true;
            this.txtRemq.Name = "txtRemq";
            this.txtRemq.Size = new System.Drawing.Size(219, 53);
            this.txtRemq.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(384, 264);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 18);
            this.label10.TabIndex = 10;
            this.label10.Text = "سبب العملية";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(61, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Notes";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(41, 264);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 18);
            this.label9.TabIndex = 10;
            this.label9.Text = "La raison";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(384, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "المبلغ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(45, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Montant";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 485);
            this.panel1.TabIndex = 1;
            // 
            // frm_transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 485);
            this.Controls.Add(this.panel1);
            this.Name = "frm_transactions";
            this.Text = "frm_transactions";
            this.Load += new System.EventHandler(this.frm_transactions_Load);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.SimpleButton btnGet;
        private System.Windows.Forms.TextBox txtMont;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtRemq;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMont;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxCaise;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
    }
}