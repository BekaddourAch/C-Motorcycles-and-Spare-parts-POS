namespace Disdriver
{
    partial class frm_edit_status
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_edit_status));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbx_file_state = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_infos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.lblMoto_id = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.txtNomAr = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNSerie = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.lblMoto_id);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label42);
            this.panel1.Controls.Add(this.txtNomAr);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.txtNSerie);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.txt_infos);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cbx_file_state);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 499);
            this.panel1.TabIndex = 0;
            // 
            // cbx_file_state
            // 
            this.cbx_file_state.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_file_state.FormattingEnabled = true;
            this.cbx_file_state.Items.AddRange(new object[] {
            "قيد الانجاز",
            "ناقص",
            "جاهز",
            "مستلم"});
            this.cbx_file_state.Location = new System.Drawing.Point(126, 151);
            this.cbx_file_state.Name = "cbx_file_state";
            this.cbx_file_state.Size = new System.Drawing.Size(274, 31);
            this.cbx_file_state.TabIndex = 1;
            this.cbx_file_state.Text = "قيد الانجاز";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(355, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 18);
            this.label9.TabIndex = 2;
            this.label9.Text = "حالة ملف شراء الدراجة";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(159)))), ((int)(((byte)(31)))));
            this.label1.Location = new System.Drawing.Point(426, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "حالة الملف";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_infos
            // 
            this.txt_infos.Location = new System.Drawing.Point(22, 218);
            this.txt_infos.Multiline = true;
            this.txt_infos.Name = "txt_infos";
            this.txt_infos.Size = new System.Drawing.Size(499, 227);
            this.txt_infos.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(159)))), ((int)(((byte)(31)))));
            this.label2.Location = new System.Drawing.Point(233, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "معلومات اخرى + معلومات مستلم الملف";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(50)))));
            this.btnSave.Appearance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnSave.Appearance.Options.UseBackColor = true;
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Appearance.Options.UseForeColor = true;
            this.btnSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(194, 451);
            this.btnSave.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 36);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "حفظ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblMoto_id
            // 
            this.lblMoto_id.AutoSize = true;
            this.lblMoto_id.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoto_id.ForeColor = System.Drawing.Color.Transparent;
            this.lblMoto_id.Location = new System.Drawing.Point(126, 18);
            this.lblMoto_id.Name = "lblMoto_id";
            this.lblMoto_id.Size = new System.Drawing.Size(25, 20);
            this.lblMoto_id.TabIndex = 26;
            this.lblMoto_id.Text = "00";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(170, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 20);
            this.label14.TabIndex = 27;
            this.label14.Text = "رقم الدراجة";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.ForeColor = System.Drawing.Color.White;
            this.label42.Location = new System.Drawing.Point(416, 59);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(94, 18);
            this.label42.TabIndex = 28;
            this.label42.Text = "الإسم بالعربية";
            // 
            // txtNomAr
            // 
            this.txtNomAr.Enabled = false;
            this.txtNomAr.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomAr.Location = new System.Drawing.Point(125, 59);
            this.txtNomAr.Name = "txtNomAr";
            this.txtNomAr.Size = new System.Drawing.Size(275, 26);
            this.txtNomAr.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(417, 102);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 18);
            this.label15.TabIndex = 30;
            this.label15.Text = "الرقم التسلسلي";
            // 
            // txtNSerie
            // 
            this.txtNSerie.Enabled = false;
            this.txtNSerie.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNSerie.ForeColor = System.Drawing.Color.Red;
            this.txtNSerie.Location = new System.Drawing.Point(125, 102);
            this.txtNSerie.Name = "txtNSerie";
            this.txtNSerie.Size = new System.Drawing.Size(275, 27);
            this.txtNSerie.TabIndex = 31;
            this.txtNSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frm_edit_status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 499);
            this.Controls.Add(this.panel1);
            this.Name = "frm_edit_status";
            this.Text = "frm_edit_status";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        public DevExpress.XtraEditors.SimpleButton btnSave;
        public System.Windows.Forms.TextBox txt_infos;
        public System.Windows.Forms.Label lblMoto_id;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label42;
        public System.Windows.Forms.TextBox txtNomAr;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.TextBox txtNSerie;
        public System.Windows.Forms.ComboBox cbx_file_state;
    }
}