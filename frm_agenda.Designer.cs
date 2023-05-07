namespace Disdriver
{
    partial class frm_agenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_agenda));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timeEdit1 = new DevExpress.XtraEditors.TimeEdit();
            this.dpDate = new System.Windows.Forms.DateTimePicker();
            this.txtActivit = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit1.Properties)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNum);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.timeEdit1);
            this.panel1.Controls.Add(this.dpDate);
            this.panel1.Controls.Add(this.txtActivit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 371);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "L\'Activité";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtNum
            // 
            this.txtNum.AutoSize = true;
            this.txtNum.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum.ForeColor = System.Drawing.Color.White;
            this.txtNum.Location = new System.Drawing.Point(471, 20);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(65, 18);
            this.txtNum.TabIndex = 11;
            this.txtNum.Text = "La Date";
            this.txtNum.Click += new System.EventHandler(this.txtNum_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(306, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "L\'heur";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "La Date";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timeEdit1
            // 
            this.timeEdit1.EditValue = new System.DateTime(2020, 12, 6, 0, 0, 0, 0);
            this.timeEdit1.Location = new System.Drawing.Point(377, 62);
            this.timeEdit1.Name = "timeEdit1";
            this.timeEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeEdit1.Properties.Appearance.Options.UseFont = true;
            this.timeEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeEdit1.Properties.Mask.EditMask = "t";
            this.timeEdit1.Size = new System.Drawing.Size(76, 30);
            this.timeEdit1.TabIndex = 10;
            this.timeEdit1.EditValueChanged += new System.EventHandler(this.timeEdit1_EditValueChanged);
            // 
            // dpDate
            // 
            this.dpDate.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpDate.Location = new System.Drawing.Point(102, 63);
            this.dpDate.Margin = new System.Windows.Forms.Padding(4);
            this.dpDate.Name = "dpDate";
            this.dpDate.Size = new System.Drawing.Size(171, 26);
            this.dpDate.TabIndex = 9;
            this.dpDate.ValueChanged += new System.EventHandler(this.dpDate_ValueChanged);
            // 
            // txtActivit
            // 
            this.txtActivit.Location = new System.Drawing.Point(102, 111);
            this.txtActivit.Multiline = true;
            this.txtActivit.Name = "txtActivit";
            this.txtActivit.Size = new System.Drawing.Size(351, 116);
            this.txtActivit.TabIndex = 0;
            this.txtActivit.TextChanged += new System.EventHandler(this.txtActivit_TextChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.btnSave);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 294);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(548, 77);
            this.panel4.TabIndex = 17;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(50)))));
            this.btnSave.Appearance.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnSave.Appearance.Options.UseBackColor = true;
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Appearance.Options.UseForeColor = true;
            this.btnSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(174, 14);
            this.btnSave.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(202, 44);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.Click += new System.EventHandler(this.btnSaveFact_Click);
            // 
            // frm_agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 371);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "frm_agenda";
            this.Text = "frm_agenda";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit1.Properties)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtActivit;
        private DevExpress.XtraEditors.TimeEdit timeEdit1;
        public System.Windows.Forms.DateTimePicker dpDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.Label txtNum;
    }
}