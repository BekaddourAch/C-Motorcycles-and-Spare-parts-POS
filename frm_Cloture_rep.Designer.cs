namespace Disdriver
{
    partial class frm_Cloture_rep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Cloture_rep));
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.clmorder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clotured = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sold_ouvert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sold_cloture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.differnce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.retrait = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raison = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.retour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.title1 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cbxMonths = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSearchMonth = new DevExpress.XtraEditors.SimpleButton();
            this.panel9 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnSearchDate = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
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
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(37)))));
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmorder,
            this.clotured,
            this.total_day,
            this.sold_ouvert,
            this.sold_cloture,
            this.differnce,
            this.retrait,
            this.raison,
            this.remarque,
            this.retour,
            this.date_start,
            this.date_fin,
            this.user_id});
            this.dgvReport.Location = new System.Drawing.Point(22, 92);
            this.dgvReport.Margin = new System.Windows.Forms.Padding(4);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.RowHeadersVisible = false;
            this.dgvReport.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(37)))));
            this.dgvReport.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvReport.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvReport.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.dgvReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReport.Size = new System.Drawing.Size(1225, 436);
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
            // clotured
            // 
            this.clotured.HeaderText = "clotured";
            this.clotured.Name = "clotured";
            this.clotured.ReadOnly = true;
            this.clotured.Visible = false;
            // 
            // total_day
            // 
            this.total_day.HeaderText = "Le Payement";
            this.total_day.Name = "total_day";
            this.total_day.ReadOnly = true;
            // 
            // sold_ouvert
            // 
            this.sold_ouvert.HeaderText = "sold d\'ouvertir";
            this.sold_ouvert.Name = "sold_ouvert";
            this.sold_ouvert.ReadOnly = true;
            // 
            // sold_cloture
            // 
            this.sold_cloture.HeaderText = "Sold de cloture";
            this.sold_cloture.Name = "sold_cloture";
            this.sold_cloture.ReadOnly = true;
            // 
            // differnce
            // 
            this.differnce.HeaderText = "Différence";
            this.differnce.Name = "differnce";
            this.differnce.ReadOnly = true;
            // 
            // retrait
            // 
            this.retrait.HeaderText = "Le Retrait";
            this.retrait.Name = "retrait";
            this.retrait.ReadOnly = true;
            // 
            // raison
            // 
            this.raison.HeaderText = "Motife";
            this.raison.Name = "raison";
            this.raison.ReadOnly = true;
            // 
            // remarque
            // 
            this.remarque.HeaderText = "Remarque";
            this.remarque.Name = "remarque";
            this.remarque.ReadOnly = true;
            // 
            // retour
            // 
            this.retour.HeaderText = "Total Retour";
            this.retour.Name = "retour";
            this.retour.ReadOnly = true;
            // 
            // date_start
            // 
            this.date_start.HeaderText = "Date début";
            this.date_start.Name = "date_start";
            this.date_start.ReadOnly = true;
            // 
            // date_fin
            // 
            this.date_fin.HeaderText = "date fin";
            this.date_fin.Name = "date_fin";
            this.date_fin.ReadOnly = true;
            // 
            // user_id
            // 
            this.user_id.HeaderText = "Utilisateur";
            this.user_id.Name = "user_id";
            this.user_id.ReadOnly = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.simpleButton1);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 540);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1273, 77);
            this.panel4.TabIndex = 18;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel8.Controls.Add(this.label6);
            this.panel8.Controls.Add(this.lblTotal);
            this.panel8.Location = new System.Drawing.Point(729, 13);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(255, 51);
            this.panel8.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(69, 1);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "اجمالي المداخيل";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTotal.Location = new System.Drawing.Point(46, 19);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 23);
            this.lblTotal.TabIndex = 2;
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
            this.simpleButton1.Location = new System.Drawing.Point(22, 14);
            this.simpleButton1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(173, 44);
            this.simpleButton1.TabIndex = 11;
            this.simpleButton1.Text = " طباعة التقرير";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(114)))), ((int)(((byte)(196)))));
            this.panel3.Controls.Add(this.lblNombre);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Location = new System.Drawing.Point(421, 13);
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
            this.title1.Size = new System.Drawing.Size(180, 23);
            this.title1.TabIndex = 21;
            this.title1.Text = "تقرير العمل اليومي";
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.panel13);
            this.panel14.Controls.Add(this.panel1);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel14.Location = new System.Drawing.Point(0, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(1273, 617);
            this.panel14.TabIndex = 19;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(57)))));
            this.panel13.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(16, 617);
            this.panel13.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dgvReport);
            this.panel1.Controls.Add(this.panel17);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1273, 617);
            this.panel1.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(37)))));
            this.panel6.Controls.Add(this.cbxMonths);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.btnSearchMonth);
            this.panel6.Location = new System.Drawing.Point(16, 43);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(555, 42);
            this.panel6.TabIndex = 27;
            // 
            // cbxMonths
            // 
            this.cbxMonths.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMonths.Items.AddRange(new object[] {
            "Janvier",
            "Février",
            "Mars",
            "Avril",
            "Mai",
            "Juin",
            "Juillet",
            "Août",
            "Septembre",
            "Octobre",
            "Novembre",
            "Décembre"});
            this.cbxMonths.Location = new System.Drawing.Point(65, 4);
            this.cbxMonths.Margin = new System.Windows.Forms.Padding(4);
            this.cbxMonths.Name = "cbxMonths";
            this.cbxMonths.Size = new System.Drawing.Size(189, 27);
            this.cbxMonths.TabIndex = 25;
            this.cbxMonths.Text = "choisissez le mois";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(274, 8);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(238, 19);
            this.label10.TabIndex = 24;
            this.label10.Text = "عرض تقرير العمل حسب الشهر\r\n";
            // 
            // btnSearchMonth
            // 
            this.btnSearchMonth.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(50)))));
            this.btnSearchMonth.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchMonth.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnSearchMonth.Appearance.Options.UseBackColor = true;
            this.btnSearchMonth.Appearance.Options.UseFont = true;
            this.btnSearchMonth.Appearance.Options.UseForeColor = true;
            this.btnSearchMonth.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnSearchMonth.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchMonth.ImageOptions.Image")));
            this.btnSearchMonth.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSearchMonth.Location = new System.Drawing.Point(12, 5);
            this.btnSearchMonth.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnSearchMonth.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchMonth.Name = "btnSearchMonth";
            this.btnSearchMonth.Size = new System.Drawing.Size(45, 27);
            this.btnSearchMonth.TabIndex = 12;
            this.btnSearchMonth.Click += new System.EventHandler(this.btnSearchMonth_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(37)))));
            this.panel9.Controls.Add(this.dateTimePicker1);
            this.panel9.Controls.Add(this.btnSearchDate);
            this.panel9.Controls.Add(this.label5);
            this.panel9.Controls.Add(this.label7);
            this.panel9.Controls.Add(this.dateTimePicker2);
            this.panel9.Location = new System.Drawing.Point(597, 43);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(650, 42);
            this.panel9.TabIndex = 26;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(296, 6);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(144, 26);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // btnSearchDate
            // 
            this.btnSearchDate.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(50)))));
            this.btnSearchDate.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchDate.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnSearchDate.Appearance.Options.UseBackColor = true;
            this.btnSearchDate.Appearance.Options.UseFont = true;
            this.btnSearchDate.Appearance.Options.UseForeColor = true;
            this.btnSearchDate.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnSearchDate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchDate.ImageOptions.Image")));
            this.btnSearchDate.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSearchDate.Location = new System.Drawing.Point(24, 5);
            this.btnSearchDate.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnSearchDate.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchDate.Name = "btnSearchDate";
            this.btnSearchDate.Size = new System.Drawing.Size(45, 27);
            this.btnSearchDate.TabIndex = 12;
            this.btnSearchDate.Click += new System.EventHandler(this.btnSearchDate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(448, 13);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 21;
            this.label5.Text = " De من ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(227, 13);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 19);
            this.label7.TabIndex = 21;
            this.label7.Text = " à الى ";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(77, 6);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(144, 26);
            this.dateTimePicker2.TabIndex = 22;
            // 
            // frm_Cloture_rep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 617);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel14);
            this.Name = "frm_Cloture_rep";
            this.Text = "frm_Cloture_rep";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotal;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label title1;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel9;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        private DevExpress.XtraEditors.SimpleButton btnSearchDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmorder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clotured;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_day;
        private System.Windows.Forms.DataGridViewTextBoxColumn sold_ouvert;
        private System.Windows.Forms.DataGridViewTextBoxColumn sold_cloture;
        private System.Windows.Forms.DataGridViewTextBoxColumn differnce;
        private System.Windows.Forms.DataGridViewTextBoxColumn retrait;
        private System.Windows.Forms.DataGridViewTextBoxColumn raison;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarque;
        private System.Windows.Forms.DataGridViewTextBoxColumn retour;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_start;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_fin;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_id;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.SimpleButton btnSearchMonth;
        private System.Windows.Forms.ComboBox cbxMonths;
    }
}