namespace Disdriver
{
    partial class frm_Depnc_Mang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Depnc_Mang));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDeponce = new System.Windows.Forms.DataGridView();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmuser_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nudPrice = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeponce)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvDeponce);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 510);
            this.panel1.TabIndex = 0;
            // 
            // dgvDeponce
            // 
            this.dgvDeponce.AllowUserToAddRows = false;
            this.dgvDeponce.AllowUserToDeleteRows = false;
            this.dgvDeponce.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeponce.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(37)))));
            this.dgvDeponce.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeponce.ColumnHeadersVisible = false;
            this.dgvDeponce.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmId,
            this.clmTypeId,
            this.clmtype,
            this.clm_notes,
            this.clm_price,
            this.clm_date,
            this.clmuser_id});
            this.dgvDeponce.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDeponce.Location = new System.Drawing.Point(0, 145);
            this.dgvDeponce.MultiSelect = false;
            this.dgvDeponce.Name = "dgvDeponce";
            this.dgvDeponce.ReadOnly = true;
            this.dgvDeponce.RowHeadersVisible = false;
            this.dgvDeponce.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(37)))));
            this.dgvDeponce.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDeponce.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDeponce.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(156)))), ((int)(((byte)(30)))));
            this.dgvDeponce.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeponce.Size = new System.Drawing.Size(950, 302);
            this.dgvDeponce.TabIndex = 7;
            this.dgvDeponce.TabStop = false;
            this.dgvDeponce.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvDepon_MouseClick);
            // 
            // clmId
            // 
            this.clmId.HeaderText = "Numero";
            this.clmId.Name = "clmId";
            this.clmId.ReadOnly = true;
            // 
            // clmTypeId
            // 
            this.clmTypeId.HeaderText = "TypeID";
            this.clmTypeId.Name = "clmTypeId";
            this.clmTypeId.ReadOnly = true;
            this.clmTypeId.Visible = false;
            // 
            // clmtype
            // 
            this.clmtype.HeaderText = "Type";
            this.clmtype.Name = "clmtype";
            this.clmtype.ReadOnly = true;
            // 
            // clm_notes
            // 
            this.clm_notes.HeaderText = "notes";
            this.clm_notes.Name = "clm_notes";
            this.clm_notes.ReadOnly = true;
            // 
            // clm_price
            // 
            this.clm_price.HeaderText = "Montant";
            this.clm_price.Name = "clm_price";
            this.clm_price.ReadOnly = true;
            // 
            // clm_date
            // 
            this.clm_date.HeaderText = "Date";
            this.clm_date.Name = "clm_date";
            this.clm_date.ReadOnly = true;
            // 
            // clmuser_id
            // 
            this.clmuser_id.HeaderText = "user";
            this.clmuser_id.Name = "clmuser_id";
            this.clmuser_id.ReadOnly = true;
            this.clmuser_id.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(37)))));
            this.panel2.Controls.Add(this.nudPrice);
            this.panel2.Controls.Add(this.dtpDate);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtNote);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cbxType);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(950, 145);
            this.panel2.TabIndex = 6;
            // 
            // nudPrice
            // 
            this.nudPrice.Location = new System.Drawing.Point(144, 24);
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(188, 21);
            this.nudPrice.TabIndex = 15;
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(144, 71);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(188, 21);
            this.dtpDate.TabIndex = 14;
            this.dtpDate.Value = new System.DateTime(2020, 7, 26, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(347, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "التاريخ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(87, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Date";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(610, 68);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(213, 53);
            this.txtNote.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(839, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "ملاحظات";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(543, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Notes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(347, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "المبلغ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(73, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Montant";
            // 
            // cbxType
            // 
            this.cbxType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(610, 25);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(213, 21);
            this.cbxType.TabIndex = 8;
            this.cbxType.Click += new System.EventHandler(this.cbxType_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(839, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "نوع المصروفات";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(542, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Type";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.btnNew);
            this.panel4.Controls.Add(this.btnDelete);
            this.panel4.Controls.Add(this.btnSave);
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Controls.Add(this.txtID);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 447);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(950, 63);
            this.panel4.TabIndex = 5;
            // 
            // btnNew
            // 
            this.btnNew.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(159)))), ((int)(((byte)(31)))));
            this.btnNew.Appearance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnNew.Appearance.Options.UseBackColor = true;
            this.btnNew.Appearance.Options.UseFont = true;
            this.btnNew.Appearance.Options.UseForeColor = true;
            this.btnNew.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.ImageOptions.Image")));
            this.btnNew.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(412, 15);
            this.btnNew.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(117, 36);
            this.btnNew.TabIndex = 8;
            this.btnNew.Text = "Nouveau";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
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
            this.btnDelete.Location = new System.Drawing.Point(816, 15);
            this.btnDelete.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 36);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSave.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnSave.Appearance.Options.UseBackColor = true;
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Appearance.Options.UseForeColor = true;
            this.btnSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(680, 15);
            this.btnSave.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 36);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Modifier";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnAdd.Location = new System.Drawing.Point(548, 15);
            this.btnAdd.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 36);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(112, 24);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(84, 21);
            this.txtID.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(34, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Number";
            // 
            // frm_Depnc_Mang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 510);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "frm_Depnc_Mang";
            this.Text = "frm_Depnc_Mang";
            this.Load += new System.EventHandler(this.frm_Depnc_Mang_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeponce)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvDeponce;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_notes;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmuser_id;
        private System.Windows.Forms.TextBox nudPrice;
        private System.Windows.Forms.Label label9;
    }
}