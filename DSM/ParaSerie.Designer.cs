namespace DSM
{
    partial class ParaSerie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParaSerie));
            this.dtDu = new DevExpress.XtraEditors.DateEdit();
            this.rdChoix = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pnlDate = new DevExpress.XtraEditors.PanelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dtAu = new DevExpress.XtraEditors.DateEdit();
            this.BtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.BtnAnnuler = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtDu.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdChoix.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDate)).BeginInit();
            this.pnlDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtAu.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dtDu
            // 
            this.dtDu.EditValue = null;
            this.dtDu.Location = new System.Drawing.Point(118, 17);
            this.dtDu.Name = "dtDu";
            this.dtDu.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDu.Properties.Appearance.Options.UseFont = true;
            this.dtDu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDu.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDu.Size = new System.Drawing.Size(229, 32);
            this.dtDu.TabIndex = 0;
            // 
            // rdChoix
            // 
            this.rdChoix.Location = new System.Drawing.Point(1, 41);
            this.rdChoix.Name = "rdChoix";
            this.rdChoix.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdChoix.Properties.Appearance.Options.UseFont = true;
            this.rdChoix.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Par anne"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Par saison")});
            this.rdChoix.Size = new System.Drawing.Size(148, 118);
            this.rdChoix.TabIndex = 1;
            this.rdChoix.SelectedIndexChanged += new System.EventHandler(this.rdChoix_SelectedIndexChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(137, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(302, 22);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = " Incrémentation automatique numéro";
            // 
            // pnlDate
            // 
            this.pnlDate.Controls.Add(this.labelControl3);
            this.pnlDate.Controls.Add(this.labelControl2);
            this.pnlDate.Controls.Add(this.dtAu);
            this.pnlDate.Controls.Add(this.dtDu);
            this.pnlDate.Location = new System.Drawing.Point(155, 41);
            this.pnlDate.Name = "pnlDate";
            this.pnlDate.Size = new System.Drawing.Size(449, 118);
            this.pnlDate.TabIndex = 3;
            this.pnlDate.Visible = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(32, 71);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(67, 22);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Date Au";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(32, 24);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(68, 22);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Date Du";
            // 
            // dtAu
            // 
            this.dtAu.EditValue = null;
            this.dtAu.Location = new System.Drawing.Point(118, 68);
            this.dtAu.Name = "dtAu";
            this.dtAu.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtAu.Properties.Appearance.Options.UseFont = true;
            this.dtAu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtAu.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtAu.Size = new System.Drawing.Size(229, 32);
            this.dtAu.TabIndex = 1;
            // 
            // BtnSave
            // 
            this.BtnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Appearance.Options.UseFont = true;
            this.BtnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.ImageOptions.Image")));
            this.BtnSave.Location = new System.Drawing.Point(83, 165);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(156, 34);
            this.BtnSave.TabIndex = 9;
            this.BtnSave.Text = "ENREGESTRER";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnAnnuler
            // 
            this.BtnAnnuler.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnnuler.Appearance.Options.UseFont = true;
            this.BtnAnnuler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAnnuler.ImageOptions.Image")));
            this.BtnAnnuler.Location = new System.Drawing.Point(345, 165);
            this.BtnAnnuler.Name = "BtnAnnuler";
            this.BtnAnnuler.Size = new System.Drawing.Size(157, 34);
            this.BtnAnnuler.TabIndex = 8;
            this.BtnAnnuler.Text = "ANNULER";
            this.BtnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // ParaSerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 207);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnAnnuler);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.rdChoix);
            this.Controls.Add(this.pnlDate);
            this.Name = "ParaSerie";
            this.Text = "ParaSerie";
            this.Load += new System.EventHandler(this.ParaSerie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtDu.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdChoix.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDate)).EndInit();
            this.pnlDate.ResumeLayout(false);
            this.pnlDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtAu.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtAu.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit dtDu;
        private DevExpress.XtraEditors.RadioGroup rdChoix;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl pnlDate;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dtAu;
        private DevExpress.XtraEditors.SimpleButton BtnSave;
        private DevExpress.XtraEditors.SimpleButton BtnAnnuler;
    }
}