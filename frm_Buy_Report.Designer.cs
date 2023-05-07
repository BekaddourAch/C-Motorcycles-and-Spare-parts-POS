namespace Disdriver
{
    partial class frm_Buy_Report
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Buy_Report));
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dpTo = new System.Windows.Forms.DateTimePicker();
            this.dpfrom = new System.Windows.Forms.DateTimePicker();
            this.txtFactNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxForniss = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.clmorder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFourn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQtt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotFact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmqttRest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmqttMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotRest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaveFact = new DevExpress.XtraEditors.SimpleButton();
            this.panel17 = new System.Windows.Forms.Panel();
            this.title1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.panel14.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.panel17.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.panel13);
            this.panel14.Controls.Add(this.panel1);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel14.Location = new System.Drawing.Point(0, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(1271, 560);
            this.panel14.TabIndex = 15;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(57)))));
            this.panel13.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(16, 560);
            this.panel13.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.dpTo);
            this.panel1.Controls.Add(this.dpfrom);
            this.panel1.Controls.Add(this.txtFactNum);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbxForniss);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dgvReport);
            this.panel1.Controls.Add(this.simpleButton2);
            this.panel1.Controls.Add(this.btnSaveFact);
            this.panel1.Controls.Add(this.panel17);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1271, 560);
            this.panel1.TabIndex = 1;
            // 
            // dpTo
            // 
            this.dpTo.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpTo.Location = new System.Drawing.Point(73, 47);
            this.dpTo.Margin = new System.Windows.Forms.Padding(4);
            this.dpTo.Name = "dpTo";
            this.dpTo.Size = new System.Drawing.Size(144, 26);
            this.dpTo.TabIndex = 22;
            // 
            // dpfrom
            // 
            this.dpfrom.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpfrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpfrom.Location = new System.Drawing.Point(277, 47);
            this.dpfrom.Margin = new System.Windows.Forms.Padding(4);
            this.dpfrom.Name = "dpfrom";
            this.dpfrom.Size = new System.Drawing.Size(144, 26);
            this.dpfrom.TabIndex = 22;
            // 
            // txtFactNum
            // 
            this.txtFactNum.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFactNum.Location = new System.Drawing.Point(628, 46);
            this.txtFactNum.Margin = new System.Windows.Forms.Padding(4);
            this.txtFactNum.Name = "txtFactNum";
            this.txtFactNum.Size = new System.Drawing.Size(67, 30);
            this.txtFactNum.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(1016, 41);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Fournisseur";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(57)))));
            this.panel2.Location = new System.Drawing.Point(1255, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(16, 556);
            this.panel2.TabIndex = 11;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.White;
            this.radioButton2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(1019, 60);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(99, 20);
            this.radioButton2.TabIndex = 23;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "تحديد المورد";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.Click += new System.EventHandler(this.radioButton2_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.White;
            this.radioButton1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(1147, 60);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(100, 20);
            this.radioButton1.TabIndex = 23;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "كل الموردين";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(705, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Num Facture";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(705, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم الفاتورة  ";
            // 
            // cbxForniss
            // 
            this.cbxForniss.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxForniss.FormattingEnabled = true;
            this.cbxForniss.Location = new System.Drawing.Point(801, 49);
            this.cbxForniss.Margin = new System.Windows.Forms.Padding(4);
            this.cbxForniss.Name = "cbxForniss";
            this.cbxForniss.Size = new System.Drawing.Size(211, 27);
            this.cbxForniss.TabIndex = 4;
            this.cbxForniss.SelectionChangeCommitted += new System.EventHandler(this.cbxForniss_SelectionChangeCommitted);
            this.cbxForniss.TextChanged += new System.EventHandler(this.cbxForniss_TextChanged);
            this.cbxForniss.Click += new System.EventHandler(this.cbxForniss_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(212, 52);
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
            this.label22.Location = new System.Drawing.Point(417, 52);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(70, 19);
            this.label22.TabIndex = 21;
            this.label22.Text = " De من ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.Location = new System.Drawing.Point(1134, 41);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tous Fournisseurs";
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
            this.clmCode,
            this.clmFourn,
            this.clmProduct,
            this.clmDate,
            this.clmQtt,
            this.clmPrix,
            this.clmTotal,
            this.clmTotFact,
            this.clmPay,
            this.clmRest,
            this.clmqttRest,
            this.clmqttMin,
            this.clmTotRest});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReport.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReport.Location = new System.Drawing.Point(13, 92);
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
            this.dgvReport.Size = new System.Drawing.Size(1241, 464);
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
            // clmCode
            // 
            this.clmCode.HeaderText = "Code Facture";
            this.clmCode.Name = "clmCode";
            this.clmCode.ReadOnly = true;
            // 
            // clmFourn
            // 
            this.clmFourn.HeaderText = "Fournisseur";
            this.clmFourn.Name = "clmFourn";
            this.clmFourn.ReadOnly = true;
            // 
            // clmProduct
            // 
            this.clmProduct.FillWeight = 304.5685F;
            this.clmProduct.HeaderText = "Article";
            this.clmProduct.Name = "clmProduct";
            this.clmProduct.ReadOnly = true;
            // 
            // clmDate
            // 
            this.clmDate.HeaderText = "Date";
            this.clmDate.Name = "clmDate";
            this.clmDate.ReadOnly = true;
            // 
            // clmQtt
            // 
            this.clmQtt.FillWeight = 51.51206F;
            this.clmQtt.HeaderText = "Quantity";
            this.clmQtt.Name = "clmQtt";
            this.clmQtt.ReadOnly = true;
            // 
            // clmPrix
            // 
            this.clmPrix.FillWeight = 49.47513F;
            this.clmPrix.HeaderText = "Prix d\'achat";
            this.clmPrix.Name = "clmPrix";
            this.clmPrix.ReadOnly = true;
            // 
            // clmTotal
            // 
            this.clmTotal.FillWeight = 90.89967F;
            this.clmTotal.HeaderText = "Total";
            this.clmTotal.Name = "clmTotal";
            this.clmTotal.ReadOnly = true;
            // 
            // clmTotFact
            // 
            this.clmTotFact.HeaderText = "Total Facture";
            this.clmTotFact.Name = "clmTotFact";
            this.clmTotFact.ReadOnly = true;
            this.clmTotFact.Visible = false;
            // 
            // clmPay
            // 
            this.clmPay.HeaderText = "Payement";
            this.clmPay.Name = "clmPay";
            this.clmPay.ReadOnly = true;
            this.clmPay.Visible = false;
            // 
            // clmRest
            // 
            this.clmRest.HeaderText = "Le Reste";
            this.clmRest.Name = "clmRest";
            this.clmRest.ReadOnly = true;
            this.clmRest.Visible = false;
            // 
            // clmqttRest
            // 
            this.clmqttRest.HeaderText = "Qtt Reste";
            this.clmqttRest.Name = "clmqttRest";
            this.clmqttRest.ReadOnly = true;
            this.clmqttRest.Visible = false;
            // 
            // clmqttMin
            // 
            this.clmqttMin.HeaderText = "Qtt Min";
            this.clmqttMin.Name = "clmqttMin";
            this.clmqttMin.ReadOnly = true;
            // 
            // clmTotRest
            // 
            this.clmTotRest.HeaderText = "Total Qtt Reste";
            this.clmTotRest.Name = "clmTotRest";
            this.clmTotRest.ReadOnly = true;
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
            this.simpleButton2.Location = new System.Drawing.Point(20, 46);
            this.simpleButton2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(45, 27);
            this.simpleButton2.TabIndex = 12;
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btnSaveFact
            // 
            this.btnSaveFact.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(50)))));
            this.btnSaveFact.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveFact.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnSaveFact.Appearance.Options.UseBackColor = true;
            this.btnSaveFact.Appearance.Options.UseFont = true;
            this.btnSaveFact.Appearance.Options.UseForeColor = true;
            this.btnSaveFact.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnSaveFact.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveFact.ImageOptions.Image")));
            this.btnSaveFact.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSaveFact.Location = new System.Drawing.Point(498, 49);
            this.btnSaveFact.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnSaveFact.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveFact.Name = "btnSaveFact";
            this.btnSaveFact.Size = new System.Drawing.Size(122, 27);
            this.btnSaveFact.TabIndex = 12;
            this.btnSaveFact.Text = "Recherché";
            this.btnSaveFact.Click += new System.EventHandler(this.btnSaveFact_Click);
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.Black;
            this.panel17.Controls.Add(this.title1);
            this.panel17.Location = new System.Drawing.Point(13, 0);
            this.panel17.Margin = new System.Windows.Forms.Padding(4);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(1240, 43);
            this.panel17.TabIndex = 10;
            // 
            // title1
            // 
            this.title1.AutoSize = true;
            this.title1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title1.ForeColor = System.Drawing.Color.White;
            this.title1.Location = new System.Drawing.Point(1018, 9);
            this.title1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(216, 23);
            this.title1.TabIndex = 21;
            this.title1.Text = "تقرير المشتريات مفصل";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(114)))), ((int)(((byte)(196)))));
            this.panel3.Controls.Add(this.lblNombre);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Location = new System.Drawing.Point(664, 13);
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
            this.panel7.Location = new System.Drawing.Point(901, 13);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(317, 44);
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.btnDelete);
            this.panel4.Controls.Add(this.simpleButton1);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 560);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1271, 77);
            this.panel4.TabIndex = 14;
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Appearance.Options.UseBackColor = true;
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.Appearance.Options.UseForeColor = true;
            this.btnDelete.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(485, 13);
            this.btnDelete.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(136, 44);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Supprimer";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(50)))));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.simpleButton1.Location = new System.Drawing.Point(66, 14);
            this.simpleButton1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(179, 44);
            this.simpleButton1.TabIndex = 11;
            this.simpleButton1.Text = " طباعة التقرير";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // frm_Buy_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 637);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel4);
            this.Name = "frm_Buy_Report";
            this.Text = "frm_Buy_Report";
            this.Load += new System.EventHandler(this.frm_Buy_Report_Load);
            this.panel14.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.ComboBox cbxForniss;
        private System.Windows.Forms.TextBox txtFactNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvReport;
        private DevExpress.XtraEditors.SimpleButton btnSaveFact;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label title1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label22;
        public System.Windows.Forms.DateTimePicker dpTo;
        public System.Windows.Forms.DateTimePicker dpfrom;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmorder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFourn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQtt;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrix;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotFact;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRest;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmqttRest;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmqttMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotRest;
        private System.Windows.Forms.RadioButton radioButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}