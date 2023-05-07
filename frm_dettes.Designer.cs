namespace Disdriver
{
    partial class frm_dettes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_dettes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNomFr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDette = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.title2 = new System.Windows.Forms.Label();
            this.title1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblFactNum = new System.Windows.Forms.Label();
            this.lblTotFact = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtApay = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.lblRest = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dpToDette = new System.Windows.Forms.DateTimePicker();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvPayedDettes = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_dette = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montant_payer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reste_dette = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_payemnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvDettes = new System.Windows.Forms.DataGridView();
            this.clmorder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDetteFact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIspayed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDateToPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayedDettes)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDettes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AllowUserToDeleteRows = false;
            this.dgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(37)))));
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.ColumnHeadersVisible = false;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmID,
            this.clmNomFr,
            this.clmDette});
            this.dgvCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomer.Location = new System.Drawing.Point(0, 84);
            this.dgvCustomer.MultiSelect = false;
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.RowHeadersVisible = false;
            this.dgvCustomer.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(37)))));
            this.dgvCustomer.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCustomer.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCustomer.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(156)))), ((int)(((byte)(30)))));
            this.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomer.Size = new System.Drawing.Size(352, 510);
            this.dgvCustomer.TabIndex = 0;
            this.dgvCustomer.TabStop = false;
            this.dgvCustomer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvCustomer_MouseClick);
            // 
            // clmID
            // 
            this.clmID.HeaderText = "Num";
            this.clmID.Name = "clmID";
            this.clmID.ReadOnly = true;
            this.clmID.Visible = false;
            // 
            // clmNomFr
            // 
            this.clmNomFr.HeaderText = "Nom Fr";
            this.clmNomFr.Name = "clmNomFr";
            this.clmNomFr.ReadOnly = true;
            // 
            // clmDette
            // 
            this.clmDette.HeaderText = "Dette";
            this.clmDette.Name = "clmDette";
            this.clmDette.ReadOnly = true;
            this.clmDette.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(57)))));
            this.panel2.Controls.Add(this.dgvCustomer);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(830, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 594);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.title2);
            this.panel3.Controls.Add(this.title1);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(352, 84);
            this.panel3.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(249, 41);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(89, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Rechercher";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // title2
            // 
            this.title2.AutoSize = true;
            this.title2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title2.ForeColor = System.Drawing.Color.White;
            this.title2.Location = new System.Drawing.Point(7, 9);
            this.title2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title2.Name = "title2";
            this.title2.Size = new System.Drawing.Size(111, 18);
            this.title2.TabIndex = 2;
            this.title2.Text = "Dettes clients";
            // 
            // title1
            // 
            this.title1.AutoSize = true;
            this.title1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title1.ForeColor = System.Drawing.Color.White;
            this.title1.Location = new System.Drawing.Point(227, 9);
            this.title1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(90, 18);
            this.title1.TabIndex = 2;
            this.title1.Text = "ديون الزبائن";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(10, 41);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(228, 26);
            this.txtSearch.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.dtpTo);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 528);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(830, 66);
            this.panel4.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Green;
            this.panel8.Controls.Add(this.lblFactNum);
            this.panel8.Controls.Add(this.lblTotFact);
            this.panel8.Controls.Add(this.label23);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Location = new System.Drawing.Point(404, 22);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(400, 31);
            this.panel8.TabIndex = 22;
            // 
            // lblFactNum
            // 
            this.lblFactNum.AutoSize = true;
            this.lblFactNum.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFactNum.ForeColor = System.Drawing.Color.White;
            this.lblFactNum.Location = new System.Drawing.Point(265, 7);
            this.lblFactNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFactNum.Name = "lblFactNum";
            this.lblFactNum.Size = new System.Drawing.Size(18, 18);
            this.lblFactNum.TabIndex = 2;
            this.lblFactNum.Text = "0";
            // 
            // lblTotFact
            // 
            this.lblTotFact.AutoSize = true;
            this.lblTotFact.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotFact.ForeColor = System.Drawing.Color.White;
            this.lblTotFact.Location = new System.Drawing.Point(4, 7);
            this.lblTotFact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotFact.Name = "lblTotFact";
            this.lblTotFact.Size = new System.Drawing.Size(68, 18);
            this.lblTotFact.TabIndex = 2;
            this.lblTotFact.Text = "0.00 DA";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(320, 7);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(77, 18);
            this.label23.TabIndex = 1;
            this.label23.Text = "رقم الفاتورة";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(169, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "مبلغ الفاتورة";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.label2.Location = new System.Drawing.Point(256, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "بتاريخ";
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(17, 17);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(113, 26);
            this.dtpTo.TabIndex = 20;
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(50)))));
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Appearance.Options.UseBackColor = true;
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Appearance.Options.UseForeColor = true;
            this.btnAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(17, 412);
            this.btnAdd.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 52);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "تسديد الدين";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 594);
            this.panel1.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(57)))));
            this.panel5.Controls.Add(this.panel10);
            this.panel5.Controls.Add(this.btnAdd);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(830, 594);
            this.panel5.TabIndex = 2;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Silver;
            this.panel10.Controls.Add(this.txtApay);
            this.panel10.Controls.Add(this.label21);
            this.panel10.Controls.Add(this.label22);
            this.panel10.Controls.Add(this.panel15);
            this.panel10.Controls.Add(this.label16);
            this.panel10.Controls.Add(this.dpToDette);
            this.panel10.Location = new System.Drawing.Point(157, 402);
            this.panel10.Margin = new System.Windows.Forms.Padding(4);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(376, 105);
            this.panel10.TabIndex = 22;
            // 
            // txtApay
            // 
            this.txtApay.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApay.Location = new System.Drawing.Point(12, 6);
            this.txtApay.Name = "txtApay";
            this.txtApay.Size = new System.Drawing.Size(176, 30);
            this.txtApay.TabIndex = 22;
            this.txtApay.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(243, 10);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(113, 19);
            this.label21.TabIndex = 11;
            this.label21.Text = "المبلغ المسدد";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(194, 77);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(171, 19);
            this.label22.TabIndex = 0;
            this.label22.Text = "تم تسديد المبلغ بتاريخ";
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.Gray;
            this.panel15.Controls.Add(this.label12);
            this.panel15.Controls.Add(this.lblRest);
            this.panel15.Location = new System.Drawing.Point(1, 39);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(375, 33);
            this.panel15.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(242, 8);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 19);
            this.label12.TabIndex = 0;
            this.label12.Text = "الباقي";
            // 
            // lblRest
            // 
            this.lblRest.AutoSize = true;
            this.lblRest.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRest.ForeColor = System.Drawing.Color.White;
            this.lblRest.Location = new System.Drawing.Point(8, 5);
            this.lblRest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRest.Name = "lblRest";
            this.lblRest.Size = new System.Drawing.Size(85, 23);
            this.lblRest.TabIndex = 2;
            this.lblRest.Text = "0.00 DA";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label16.Location = new System.Drawing.Point(195, 11);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 18);
            this.label16.TabIndex = 9;
            this.label16.Text = "DA";
            // 
            // dpToDette
            // 
            this.dpToDette.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpToDette.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpToDette.Location = new System.Drawing.Point(13, 75);
            this.dpToDette.Margin = new System.Windows.Forms.Padding(4);
            this.dpToDette.Name = "dpToDette";
            this.dpToDette.Size = new System.Drawing.Size(154, 26);
            this.dpToDette.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(114)))), ((int)(((byte)(196)))));
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Controls.Add(this.lblNombre);
            this.panel6.Location = new System.Drawing.Point(540, 402);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(242, 105);
            this.panel6.TabIndex = 21;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.panel9.Controls.Add(this.label14);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(242, 29);
            this.panel9.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(74, 5);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 18);
            this.label14.TabIndex = 2;
            this.label14.Text = "مجموع الديون";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(15, 58);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(85, 23);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "0.00 DA";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(37)))));
            this.panel7.Controls.Add(this.tabControl1);
            this.panel7.Location = new System.Drawing.Point(13, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(769, 387);
            this.panel7.TabIndex = 18;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(4, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(761, 378);
            this.tabControl1.TabIndex = 22;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvPayedDettes);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(753, 346);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "تقرير تسديد الديون";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvPayedDettes
            // 
            this.dgvPayedDettes.AllowUserToAddRows = false;
            this.dgvPayedDettes.AllowUserToDeleteRows = false;
            this.dgvPayedDettes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPayedDettes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(37)))));
            this.dgvPayedDettes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayedDettes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.total_dette,
            this.montant_payer,
            this.reste_dette,
            this.date_payemnt});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayedDettes.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPayedDettes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPayedDettes.Location = new System.Drawing.Point(3, 3);
            this.dgvPayedDettes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPayedDettes.MultiSelect = false;
            this.dgvPayedDettes.Name = "dgvPayedDettes";
            this.dgvPayedDettes.ReadOnly = true;
            this.dgvPayedDettes.RowHeadersVisible = false;
            this.dgvPayedDettes.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(37)))));
            this.dgvPayedDettes.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPayedDettes.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPayedDettes.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.dgvPayedDettes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayedDettes.Size = new System.Drawing.Size(747, 340);
            this.dgvPayedDettes.TabIndex = 22;
            this.dgvPayedDettes.TabStop = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 40.00523F;
            this.dataGridViewTextBoxColumn1.HeaderText = "#";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // total_dette
            // 
            this.total_dette.FillWeight = 110F;
            this.total_dette.HeaderText = "Les Dette";
            this.total_dette.Name = "total_dette";
            this.total_dette.ReadOnly = true;
            // 
            // montant_payer
            // 
            this.montant_payer.FillWeight = 110F;
            this.montant_payer.HeaderText = "a payé";
            this.montant_payer.Name = "montant_payer";
            this.montant_payer.ReadOnly = true;
            // 
            // reste_dette
            // 
            this.reste_dette.FillWeight = 110F;
            this.reste_dette.HeaderText = "Le Reste";
            this.reste_dette.Name = "reste_dette";
            this.reste_dette.ReadOnly = true;
            // 
            // date_payemnt
            // 
            this.date_payemnt.HeaderText = "Date de paiement";
            this.date_payemnt.Name = "date_payemnt";
            this.date_payemnt.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvDettes);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(753, 346);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "تقرير  الديون";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvDettes
            // 
            this.dgvDettes.AllowUserToAddRows = false;
            this.dgvDettes.AllowUserToDeleteRows = false;
            this.dgvDettes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDettes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(37)))));
            this.dgvDettes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDettes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmorder,
            this.clmNum,
            this.clmDetteFact,
            this.clmDate,
            this.clmIspayed,
            this.clmDateToPay});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDettes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDettes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDettes.Location = new System.Drawing.Point(3, 3);
            this.dgvDettes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDettes.MultiSelect = false;
            this.dgvDettes.Name = "dgvDettes";
            this.dgvDettes.ReadOnly = true;
            this.dgvDettes.RowHeadersVisible = false;
            this.dgvDettes.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(37)))));
            this.dgvDettes.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDettes.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDettes.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.dgvDettes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDettes.Size = new System.Drawing.Size(747, 340);
            this.dgvDettes.TabIndex = 22;
            this.dgvDettes.TabStop = false;
            // 
            // clmorder
            // 
            this.clmorder.FillWeight = 16.38672F;
            this.clmorder.HeaderText = "#";
            this.clmorder.Name = "clmorder";
            this.clmorder.ReadOnly = true;
            // 
            // clmNum
            // 
            this.clmNum.FillWeight = 20F;
            this.clmNum.HeaderText = "Facture";
            this.clmNum.Name = "clmNum";
            this.clmNum.ReadOnly = true;
            // 
            // clmDetteFact
            // 
            this.clmDetteFact.FillWeight = 50F;
            this.clmDetteFact.HeaderText = "Dettes";
            this.clmDetteFact.Name = "clmDetteFact";
            this.clmDetteFact.ReadOnly = true;
            // 
            // clmDate
            // 
            this.clmDate.FillWeight = 45.01516F;
            this.clmDate.HeaderText = "Date Dette";
            this.clmDate.Name = "clmDate";
            this.clmDate.ReadOnly = true;
            // 
            // clmIspayed
            // 
            this.clmIspayed.FillWeight = 36.43601F;
            this.clmIspayed.HeaderText = "payed";
            this.clmIspayed.Name = "clmIspayed";
            this.clmIspayed.ReadOnly = true;
            this.clmIspayed.Visible = false;
            // 
            // clmDateToPay
            // 
            this.clmDateToPay.FillWeight = 45.01516F;
            this.clmDateToPay.HeaderText = "Date de paiement";
            this.clmDateToPay.Name = "clmDateToPay";
            this.clmDateToPay.ReadOnly = true;
            // 
            // frm_dettes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 594);
            this.Controls.Add(this.panel1);
            this.Name = "frm_dettes";
            this.Text = "          ";
            this.Load += new System.EventHandler(this.frm_dettes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayedDettes)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDettes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        public System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblFactNum;
        private System.Windows.Forms.Label lblTotFact;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNomFr;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDette;
        private System.Windows.Forms.Label title2;
        private System.Windows.Forms.Label title1;
        private System.Windows.Forms.TextBox txtApay;
        private System.Windows.Forms.Label lblRest;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.DateTimePicker dpToDette;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvPayedDettes;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvDettes;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmorder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDetteFact;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIspayed;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDateToPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_dette;
        private System.Windows.Forms.DataGridViewTextBoxColumn montant_payer;
        private System.Windows.Forms.DataGridViewTextBoxColumn reste_dette;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_payemnt;
    }
}