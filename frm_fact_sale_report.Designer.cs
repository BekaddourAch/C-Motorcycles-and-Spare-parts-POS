namespace Disdriver
{
    partial class frm_fact_sale_report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_fact_sale_report));
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblBenifice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
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
            this.panel17 = new System.Windows.Forms.Panel();
            this.title1 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.clmNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotFact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaveFact = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.simpleButton4);
            this.panel4.Controls.Add(this.btnDelete);
            this.panel4.Controls.Add(this.simpleButton3);
            this.panel4.Controls.Add(this.simpleButton1);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 551);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1272, 77);
            this.panel4.TabIndex = 18;
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
            this.btnDelete.Location = new System.Drawing.Point(179, 13);
            this.btnDelete.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(155, 44);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "حذف فاتورة البيع";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.simpleButton3.Appearance.Options.UseBackColor = true;
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.Appearance.Options.UseForeColor = true;
            this.simpleButton3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.simpleButton3.Location = new System.Drawing.Point(342, 13);
            this.simpleButton3.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.simpleButton3.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(176, 44);
            this.simpleButton3.TabIndex = 11;
            this.simpleButton3.Text = "التعديل على الفاتورة";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
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
            this.simpleButton1.Location = new System.Drawing.Point(13, 13);
            this.simpleButton1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(158, 44);
            this.simpleButton1.TabIndex = 11;
            this.simpleButton1.Text = " طباعة التقرير";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel7.Controls.Add(this.lblBenifice);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.lblTotal);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Location = new System.Drawing.Point(719, 13);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(540, 44);
            this.panel7.TabIndex = 10;
            // 
            // lblBenifice
            // 
            this.lblBenifice.AutoSize = true;
            this.lblBenifice.BackColor = System.Drawing.Color.Transparent;
            this.lblBenifice.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBenifice.ForeColor = System.Drawing.Color.Black;
            this.lblBenifice.Location = new System.Drawing.Point(349, 14);
            this.lblBenifice.Name = "lblBenifice";
            this.lblBenifice.Size = new System.Drawing.Size(0, 19);
            this.lblBenifice.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(265, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dettes";
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(114)))), ((int)(((byte)(196)))));
            this.panel3.Controls.Add(this.lblNombre);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Location = new System.Drawing.Point(10, 0);
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
            // dpTo
            // 
            this.dpTo.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpTo.Location = new System.Drawing.Point(73, 50);
            this.dpTo.Margin = new System.Windows.Forms.Padding(4);
            this.dpTo.Name = "dpTo";
            this.dpTo.Size = new System.Drawing.Size(144, 26);
            this.dpTo.TabIndex = 22;
            // 
            // dpfrom
            // 
            this.dpfrom.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpfrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpfrom.Location = new System.Drawing.Point(277, 50);
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
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Client";
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
            this.radioButton2.Size = new System.Drawing.Size(98, 20);
            this.radioButton2.TabIndex = 23;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "تحديد الزبون";
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
            this.radioButton1.Size = new System.Drawing.Size(86, 20);
            this.radioButton1.TabIndex = 23;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "كل الزبائن";
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
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(212, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = " à الى ";
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.Black;
            this.panel17.Controls.Add(this.title1);
            this.panel17.Controls.Add(this.panel3);
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
            this.title1.Size = new System.Drawing.Size(189, 23);
            this.title1.TabIndex = 21;
            this.title1.Text = "تقرير فواتير المبيعات";
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.panel13);
            this.panel14.Controls.Add(this.panel1);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel14.Location = new System.Drawing.Point(0, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(1272, 628);
            this.panel14.TabIndex = 19;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(57)))));
            this.panel13.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(16, 628);
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
            this.panel1.Size = new System.Drawing.Size(1272, 628);
            this.panel1.TabIndex = 1;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(417, 55);
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
            this.label7.Size = new System.Drawing.Size(111, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tous Les Clients";
            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(37)))));
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmNum,
            this.Column4,
            this.clmDate,
            this.Column1,
            this.clmTotFact,
            this.clmPay,
            this.clmRest,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column7});
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
            // clmNum
            // 
            this.clmNum.FillWeight = 67.14191F;
            this.clmNum.HeaderText = "Num";
            this.clmNum.Name = "clmNum";
            this.clmNum.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Code Facture";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // clmDate
            // 
            this.clmDate.HeaderText = "Date";
            this.clmDate.Name = "clmDate";
            this.clmDate.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Le Client";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // clmTotFact
            // 
            this.clmTotFact.HeaderText = "Total Facture";
            this.clmTotFact.Name = "clmTotFact";
            this.clmTotFact.ReadOnly = true;
            // 
            // clmPay
            // 
            this.clmPay.HeaderText = "Payement";
            this.clmPay.Name = "clmPay";
            this.clmPay.ReadOnly = true;
            // 
            // clmRest
            // 
            this.clmRest.HeaderText = "Le Reste";
            this.clmRest.Name = "clmRest";
            this.clmRest.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Date Dette ";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "payem";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Remarque";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "tim";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Agent";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
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
            this.simpleButton2.Location = new System.Drawing.Point(20, 49);
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
            // simpleButton4
            // 
            this.simpleButton4.Appearance.BackColor = System.Drawing.Color.Orange;
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.simpleButton4.Appearance.Options.UseBackColor = true;
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.Appearance.Options.UseForeColor = true;
            this.simpleButton4.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.simpleButton4.Location = new System.Drawing.Point(536, 13);
            this.simpleButton4.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.simpleButton4.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(147, 44);
            this.simpleButton4.TabIndex = 23;
            this.simpleButton4.Text = "عرض الفاتورة";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // frm_fact_sale_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 628);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel14);
            this.Name = "frm_fact_sale_report";
            this.Text = "frm_fact_report";
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblBenifice;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.DateTimePicker dpTo;
        public System.Windows.Forms.DateTimePicker dpfrom;
        private System.Windows.Forms.TextBox txtFactNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxForniss;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label title1;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvReport;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btnSaveFact;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotFact;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRest;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
    }
}