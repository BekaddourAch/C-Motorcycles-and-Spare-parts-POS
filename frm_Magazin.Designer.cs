namespace Disdriver
{
    partial class frm_Magazin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Magazin));
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvEmpl = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textMagDesc = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvMag = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtNomMag = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpl)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMag)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(37)))));
            this.panel7.Controls.Add(this.panel3);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.textMagDesc);
            this.panel7.Controls.Add(this.panel2);
            this.panel7.Controls.Add(this.panel4);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.txtNum);
            this.panel7.Controls.Add(this.txtNomMag);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(966, 487);
            this.panel7.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvEmpl);
            this.panel3.Location = new System.Drawing.Point(490, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(459, 381);
            this.panel3.TabIndex = 6;
            // 
            // dgvEmpl
            // 
            this.dgvEmpl.AllowUserToAddRows = false;
            this.dgvEmpl.AllowUserToDeleteRows = false;
            this.dgvEmpl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmpl.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(37)))));
            this.dgvEmpl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpl.ColumnHeadersVisible = false;
            this.dgvEmpl.Location = new System.Drawing.Point(3, 14);
            this.dgvEmpl.MultiSelect = false;
            this.dgvEmpl.Name = "dgvEmpl";
            this.dgvEmpl.ReadOnly = true;
            this.dgvEmpl.RowHeadersVisible = false;
            this.dgvEmpl.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(37)))));
            this.dgvEmpl.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEmpl.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvEmpl.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(156)))), ((int)(((byte)(30)))));
            this.dgvEmpl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpl.Size = new System.Drawing.Size(453, 364);
            this.dgvEmpl.TabIndex = 1;
            this.dgvEmpl.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Description du magasin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(387, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "وصف المخزن";
            // 
            // textMagDesc
            // 
            this.textMagDesc.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMagDesc.Location = new System.Drawing.Point(180, 93);
            this.textMagDesc.Multiline = true;
            this.textMagDesc.Name = "textMagDesc";
            this.textMagDesc.Size = new System.Drawing.Size(200, 49);
            this.textMagDesc.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvMag);
            this.panel2.Location = new System.Drawing.Point(12, 149);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(463, 269);
            this.panel2.TabIndex = 5;
            // 
            // dgvMag
            // 
            this.dgvMag.AllowUserToAddRows = false;
            this.dgvMag.AllowUserToDeleteRows = false;
            this.dgvMag.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMag.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(37)))));
            this.dgvMag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMag.ColumnHeadersVisible = false;
            this.dgvMag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMag.Location = new System.Drawing.Point(0, 0);
            this.dgvMag.MultiSelect = false;
            this.dgvMag.Name = "dgvMag";
            this.dgvMag.ReadOnly = true;
            this.dgvMag.RowHeadersVisible = false;
            this.dgvMag.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(37)))));
            this.dgvMag.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMag.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMag.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(156)))), ((int)(((byte)(30)))));
            this.dgvMag.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMag.Size = new System.Drawing.Size(463, 269);
            this.dgvMag.TabIndex = 1;
            this.dgvMag.TabStop = false;
            this.dgvMag.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvMag_MouseClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.simpleButton1);
            this.panel4.Controls.Add(this.btnNew);
            this.panel4.Controls.Add(this.btnDelete);
            this.panel4.Controls.Add(this.btnSave);
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 424);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(966, 63);
            this.panel4.TabIndex = 4;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(166)))), ((int)(((byte)(179)))));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.simpleButton1.Location = new System.Drawing.Point(560, 15);
            this.simpleButton1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(166, 36);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "Emplacements";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
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
            this.btnNew.Location = new System.Drawing.Point(19, 15);
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
            this.btnDelete.Location = new System.Drawing.Point(423, 15);
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
            this.btnSave.Location = new System.Drawing.Point(287, 15);
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
            this.btnAdd.Location = new System.Drawing.Point(155, 15);
            this.btnAdd.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 36);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numéro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nom du magasin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(426, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "الرقــم";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(387, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "إسم المخزن";
            // 
            // txtNum
            // 
            this.txtNum.Enabled = false;
            this.txtNum.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum.Location = new System.Drawing.Point(180, 23);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(154, 26);
            this.txtNum.TabIndex = 3;
            // 
            // txtNomMag
            // 
            this.txtNomMag.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomMag.Location = new System.Drawing.Point(180, 56);
            this.txtNomMag.Name = "txtNomMag";
            this.txtNomMag.Size = new System.Drawing.Size(200, 26);
            this.txtNomMag.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(966, 487);
            this.panel1.TabIndex = 1;
            // 
            // frm_Magazin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 487);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "frm_Magazin";
            this.Text = "frm_Magazin";
            this.Load += new System.EventHandler(this.frm_Magazin_Load);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpl)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMag)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvMag;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtNomMag;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textMagDesc;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvEmpl;
    }
}