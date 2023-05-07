namespace Disdriver
{
    partial class frm_report_caisse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_report_caisse));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.clmorder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel17 = new System.Windows.Forms.Panel();
            this.title1 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkButton3 = new DevExpress.XtraEditors.CheckButton();
            this.checkButton2 = new DevExpress.XtraEditors.CheckButton();
            this.checkButton1 = new DevExpress.XtraEditors.CheckButton();
            this.cbxCaise = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dpTo = new System.Windows.Forms.DateTimePicker();
            this.dpfrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.panel17.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.btnPrint);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 507);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1204, 77);
            this.panel4.TabIndex = 18;
            // 
            // btnPrint
            // 
            this.btnPrint.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(50)))));
            this.btnPrint.Appearance.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Appearance.Options.UseBackColor = true;
            this.btnPrint.Appearance.Options.UseFont = true;
            this.btnPrint.Appearance.Options.UseForeColor = true;
            this.btnPrint.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.ImageOptions.Image")));
            this.btnPrint.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(225, 14);
            this.btnPrint.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(173, 43);
            this.btnPrint.TabIndex = 11;
            this.btnPrint.Text = "EXCEL";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(114)))), ((int)(((byte)(196)))));
            this.panel3.Controls.Add(this.lblNombre);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Location = new System.Drawing.Point(429, 13);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(229, 44);
            this.panel3.TabIndex = 11;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(105, 11);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(34, 23);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "00";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(4, 11);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 23);
            this.label14.TabIndex = 2;
            this.label14.Text = "Nombre";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel7.Controls.Add(this.lblTotal);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Location = new System.Drawing.Point(719, 13);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(409, 44);
            this.panel7.TabIndex = 10;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTotal.Location = new System.Drawing.Point(72, 12);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 23);
            this.lblTotal.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(5, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Total";
            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(37)))));
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmorder,
            this.clmNum,
            this.Column2,
            this.Column1,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReport.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReport.Location = new System.Drawing.Point(13, 105);
            this.dgvReport.Margin = new System.Windows.Forms.Padding(4);
            this.dgvReport.MultiSelect = false;
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.RowHeadersVisible = false;
            this.dgvReport.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(37)))));
            this.dgvReport.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvReport.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvReport.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.dgvReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReport.Size = new System.Drawing.Size(1178, 394);
            this.dgvReport.TabIndex = 20;
            this.dgvReport.TabStop = false;
            // 
            // clmorder
            // 
            this.clmorder.FillWeight = 36.40267F;
            this.clmorder.HeaderText = "#";
            this.clmorder.Name = "clmorder";
            this.clmorder.ReadOnly = true;
            // 
            // clmNum
            // 
            this.clmNum.FillWeight = 67.14191F;
            this.clmNum.HeaderText = "Num";
            this.clmNum.Name = "clmNum";
            this.clmNum.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Montant";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "La date";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "La Raison";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Les Remarques";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.Black;
            this.panel17.Controls.Add(this.title1);
            this.panel17.Location = new System.Drawing.Point(13, 0);
            this.panel17.Margin = new System.Windows.Forms.Padding(4);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(1178, 43);
            this.panel17.TabIndex = 10;
            // 
            // title1
            // 
            this.title1.AutoSize = true;
            this.title1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title1.ForeColor = System.Drawing.Color.White;
            this.title1.Location = new System.Drawing.Point(1031, 9);
            this.title1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(143, 23);
            this.title1.TabIndex = 21;
            this.title1.Text = "تقرير الحسابات";
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.panel1);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel14.Location = new System.Drawing.Point(0, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(1204, 584);
            this.panel14.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.checkButton3);
            this.panel1.Controls.Add(this.checkButton2);
            this.panel1.Controls.Add(this.checkButton1);
            this.panel1.Controls.Add(this.cbxCaise);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dpTo);
            this.panel1.Controls.Add(this.dpfrom);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.dgvReport);
            this.panel1.Controls.Add(this.simpleButton2);
            this.panel1.Controls.Add(this.panel17);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1204, 584);
            this.panel1.TabIndex = 1;
            // 
            // checkButton3
            // 
            this.checkButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkButton3.Appearance.Options.UseFont = true;
            this.checkButton3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.checkButton3.Location = new System.Drawing.Point(527, 70);
            this.checkButton3.Name = "checkButton3";
            this.checkButton3.Size = new System.Drawing.Size(85, 27);
            this.checkButton3.TabIndex = 27;
            this.checkButton3.Text = "كل العمليات";
            this.checkButton3.CheckedChanged += new System.EventHandler(this.checkButton3_CheckedChanged);
            // 
            // checkButton2
            // 
            this.checkButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkButton2.Appearance.Options.UseFont = true;
            this.checkButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.checkButton2.Location = new System.Drawing.Point(636, 70);
            this.checkButton2.Name = "checkButton2";
            this.checkButton2.Size = new System.Drawing.Size(85, 27);
            this.checkButton2.TabIndex = 27;
            this.checkButton2.Text = "السحب";
            this.checkButton2.CheckedChanged += new System.EventHandler(this.checkButton2_CheckedChanged);
            // 
            // checkButton1
            // 
            this.checkButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkButton1.Appearance.Options.UseFont = true;
            this.checkButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.checkButton1.Location = new System.Drawing.Point(743, 70);
            this.checkButton1.Name = "checkButton1";
            this.checkButton1.Size = new System.Drawing.Size(85, 27);
            this.checkButton1.TabIndex = 28;
            this.checkButton1.Text = "المدفوعات";
            this.checkButton1.CheckedChanged += new System.EventHandler(this.checkButton1_CheckedChanged);
            // 
            // cbxCaise
            // 
            this.cbxCaise.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxCaise.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxCaise.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCaise.ForeColor = System.Drawing.Color.Black;
            this.cbxCaise.FormattingEnabled = true;
            this.cbxCaise.Location = new System.Drawing.Point(891, 72);
            this.cbxCaise.Name = "cbxCaise";
            this.cbxCaise.Size = new System.Drawing.Size(300, 26);
            this.cbxCaise.TabIndex = 25;
            this.cbxCaise.DropDownClosed += new System.EventHandler(this.cbxCaise_DropDownClosed);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(888, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 18);
            this.label5.TabIndex = 23;
            this.label5.Text = "Choisissez la caisse";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1102, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "أختر الخزينة";
            // 
            // dpTo
            // 
            this.dpTo.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpTo.Location = new System.Drawing.Point(71, 70);
            this.dpTo.Margin = new System.Windows.Forms.Padding(4);
            this.dpTo.Name = "dpTo";
            this.dpTo.Size = new System.Drawing.Size(144, 26);
            this.dpTo.TabIndex = 22;
            // 
            // dpfrom
            // 
            this.dpfrom.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpfrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpfrom.Location = new System.Drawing.Point(275, 70);
            this.dpfrom.Margin = new System.Windows.Forms.Padding(4);
            this.dpfrom.Name = "dpfrom";
            this.dpfrom.Size = new System.Drawing.Size(144, 26);
            this.dpfrom.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(210, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = " à الى ";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(416, 75);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(70, 19);
            this.label22.TabIndex = 21;
            this.label22.Text = " De من ";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(50)))));
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Appearance.Options.UseForeColor = true;
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.simpleButton2.Location = new System.Drawing.Point(13, 69);
            this.simpleButton2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(45, 27);
            this.simpleButton2.TabIndex = 12;
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // frm_report_caisse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 584);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel14);
            this.Name = "frm_report_caisse";
            this.Text = "frm_report_caisse";
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label title1;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DateTimePicker dpTo;
        public System.Windows.Forms.DateTimePicker dpfrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label22;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.ComboBox cbxCaise;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.CheckButton checkButton2;
        private DevExpress.XtraEditors.CheckButton checkButton1;
        private DevExpress.XtraEditors.CheckButton checkButton3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmorder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}