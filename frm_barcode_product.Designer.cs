namespace Disdriver
{
    partial class frm_barcode_product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_barcode_product));
            this.label6 = new System.Windows.Forms.Label();
            this.lblPrix = new System.Windows.Forms.Label();
            this.btnRandBarCode = new System.Windows.Forms.Button();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblArticle = new System.Windows.Forms.Label();
            this.lblShow = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFactNumAuto = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSaveBar = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvBarcode = new System.Windows.Forms.DataGridView();
            this.txtCadbarAdd = new System.Windows.Forms.TextBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.clmorder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarcode)).BeginInit();
            this.SuspendLayout();
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
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrix.ForeColor = System.Drawing.Color.Black;
            this.lblPrix.Location = new System.Drawing.Point(66, 59);
            this.lblPrix.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(40, 16);
            this.lblPrix.TabIndex = 10;
            this.lblPrix.Text = "1000";
            // 
            // btnRandBarCode
            // 
            this.btnRandBarCode.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandBarCode.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRandBarCode.Location = new System.Drawing.Point(130, 175);
            this.btnRandBarCode.Name = "btnRandBarCode";
            this.btnRandBarCode.Size = new System.Drawing.Size(204, 54);
            this.btnRandBarCode.TabIndex = 0;
            this.btnRandBarCode.Text = "عشوائي  Barcode توليد رقم ";
            this.btnRandBarCode.UseVisualStyleBackColor = true;
            this.btnRandBarCode.Click += new System.EventHandler(this.btnRandBarCode_Click);
            // 
            // txtBarcode
            // 
            this.txtBarcode.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.ForeColor = System.Drawing.Color.Black;
            this.txtBarcode.Location = new System.Drawing.Point(130, 126);
            this.txtBarcode.Margin = new System.Windows.Forms.Padding(4);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(212, 36);
            this.txtBarcode.TabIndex = 9;
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
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.BackColor = System.Drawing.Color.White;
            this.lblShow.Font = new System.Drawing.Font("Barcode 39", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShow.ForeColor = System.Drawing.Color.Black;
            this.lblShow.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblShow.Location = new System.Drawing.Point(112, 241);
            this.lblShow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShow.MinimumSize = new System.Drawing.Size(250, 110);
            this.lblShow.Name = "lblShow";
            this.lblShow.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblShow.Size = new System.Drawing.Size(250, 110);
            this.lblShow.TabIndex = 10;
            this.lblShow.Text = "100010";
            this.lblShow.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(357, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "رقم الباركود";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.label4.Location = new System.Drawing.Point(334, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "معلومات السلعة";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel5.Controls.Add(this.lblFactNumAuto);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.lblPrix);
            this.panel5.Controls.Add(this.lblArticle);
            this.panel5.Location = new System.Drawing.Point(13, 5);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(447, 98);
            this.panel5.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 423);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(839, 77);
            this.panel4.TabIndex = 12;
            // 
            // btnSaveBar
            // 
            this.btnSaveBar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(159)))), ((int)(((byte)(31)))));
            this.btnSaveBar.Appearance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveBar.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnSaveBar.Appearance.Options.UseBackColor = true;
            this.btnSaveBar.Appearance.Options.UseFont = true;
            this.btnSaveBar.Appearance.Options.UseForeColor = true;
            this.btnSaveBar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnSaveBar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveBar.ImageOptions.Image")));
            this.btnSaveBar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSaveBar.Location = new System.Drawing.Point(148, 371);
            this.btnSaveBar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnSaveBar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveBar.Name = "btnSaveBar";
            this.btnSaveBar.Size = new System.Drawing.Size(175, 44);
            this.btnSaveBar.TabIndex = 8;
            this.btnSaveBar.Text = "حفظ تعداد الباركود";
            this.btnSaveBar.Click += new System.EventHandler(this.btnSaveBar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSaveBar);
            this.panel1.Controls.Add(this.dgvBarcode);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.lblShow);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnRandBarCode);
            this.panel1.Controls.Add(this.txtCadbarAdd);
            this.panel1.Controls.Add(this.txtBarcode);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(839, 500);
            this.panel1.TabIndex = 1;
            // 
            // dgvBarcode
            // 
            this.dgvBarcode.AllowUserToAddRows = false;
            this.dgvBarcode.AllowUserToDeleteRows = false;
            this.dgvBarcode.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBarcode.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(37)))));
            this.dgvBarcode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBarcode.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmorder,
            this.clmNum});
            this.dgvBarcode.Location = new System.Drawing.Point(468, 84);
            this.dgvBarcode.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBarcode.MultiSelect = false;
            this.dgvBarcode.Name = "dgvBarcode";
            this.dgvBarcode.ReadOnly = true;
            this.dgvBarcode.RowHeadersVisible = false;
            this.dgvBarcode.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(37)))));
            this.dgvBarcode.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBarcode.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBarcode.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.dgvBarcode.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBarcode.Size = new System.Drawing.Size(358, 331);
            this.dgvBarcode.TabIndex = 22;
            this.dgvBarcode.TabStop = false;
            // 
            // txtCadbarAdd
            // 
            this.txtCadbarAdd.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadbarAdd.ForeColor = System.Drawing.Color.Black;
            this.txtCadbarAdd.Location = new System.Drawing.Point(468, 4);
            this.txtCadbarAdd.Margin = new System.Windows.Forms.Padding(4);
            this.txtCadbarAdd.Name = "txtCadbarAdd";
            this.txtCadbarAdd.Size = new System.Drawing.Size(203, 36);
            this.txtCadbarAdd.TabIndex = 9;
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
            this.simpleButton1.Location = new System.Drawing.Point(673, 44);
            this.simpleButton1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(104, 36);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "إضافة";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // clmorder
            // 
            this.clmorder.FillWeight = 5F;
            this.clmorder.HeaderText = "#";
            this.clmorder.Name = "clmorder";
            this.clmorder.ReadOnly = true;
            // 
            // clmNum
            // 
            this.clmNum.FillWeight = 20F;
            this.clmNum.HeaderText = "Barcode";
            this.clmNum.Name = "clmNum";
            this.clmNum.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(679, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "إضافة باركود اخر للسلعة";
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
            this.btnDelete.Location = new System.Drawing.Point(517, 44);
            this.btnDelete.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 35);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frm_barcode_product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 500);
            this.Controls.Add(this.panel1);
            this.Name = "frm_barcode_product";
            this.Text = "frm_barcode_product";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarcode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.Button btnRandBarCode;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblArticle;
        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFactNumAuto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private DevExpress.XtraEditors.SimpleButton btnSaveBar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmorder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNum;
        private System.Windows.Forms.TextBox txtCadbarAdd;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
    }
}