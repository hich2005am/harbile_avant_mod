namespace DSM
{
    partial class proctection
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(proctection));
            DevExpress.Utils.Controls.SnapOptions snapOptions1 = new DevExpress.Utils.Controls.SnapOptions();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtRequestCode = new DevExpress.XtraEditors.TextEdit();
            this.BtnAnnuler = new DevExpress.XtraEditors.SimpleButton();
            this.BtnValide = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.tbPro = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.txtSerialNumber = new DevExpress.XtraEditors.MemoEdit();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtStatus = new DevExpress.XtraEditors.MemoEdit();
            this.txtSerial = new DevExpress.XtraEditors.TextEdit();
            this.BtnAnnulerEssai = new DevExpress.XtraEditors.SimpleButton();
            this.BtnValidEssai = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.privee = new DevExpress.XtraEditors.ToggleSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.txtRequestCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPro)).BeginInit();
            this.tbPro.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerialNumber.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.privee.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(3, 50);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(115, 23);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID PRODUIT";
            this.labelControl1.Visible = false;
            // 
            // txtRequestCode
            // 
            this.txtRequestCode.Location = new System.Drawing.Point(124, 47);
            this.txtRequestCode.Name = "txtRequestCode";
            this.txtRequestCode.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRequestCode.Properties.Appearance.Options.UseFont = true;
            this.txtRequestCode.Properties.ReadOnly = true;
            this.txtRequestCode.Size = new System.Drawing.Size(382, 26);
            this.txtRequestCode.TabIndex = 2;
            this.txtRequestCode.Visible = false;
            // 
            // BtnAnnuler
            // 
            this.BtnAnnuler.Appearance.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnnuler.Appearance.Options.UseFont = true;
            this.BtnAnnuler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAnnuler.ImageOptions.Image")));
            this.BtnAnnuler.Location = new System.Drawing.Point(335, 162);
            this.BtnAnnuler.Name = "BtnAnnuler";
            this.BtnAnnuler.Size = new System.Drawing.Size(147, 36);
            this.BtnAnnuler.TabIndex = 4;
            this.BtnAnnuler.Text = "FERMER";
            this.BtnAnnuler.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // BtnValide
            // 
            this.BtnValide.Appearance.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnValide.Appearance.Options.UseFont = true;
            this.BtnValide.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnValide.ImageOptions.Image")));
            this.BtnValide.Location = new System.Drawing.Point(114, 162);
            this.BtnValide.Name = "BtnValide";
            this.BtnValide.Size = new System.Drawing.Size(147, 36);
            this.BtnValide.TabIndex = 5;
            this.BtnValide.Text = "Valider";
            this.BtnValide.Click += new System.EventHandler(this.VALIDE_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(1, 90);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(39, 23);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "CLE";
            // 
            // tbPro
            // 
            this.tbPro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPro.Location = new System.Drawing.Point(0, 34);
            this.tbPro.Name = "tbPro";
            this.tbPro.SelectedTabPage = this.xtraTabPage1;
            this.tbPro.Size = new System.Drawing.Size(518, 233);
            this.tbPro.TabIndex = 8;
            this.tbPro.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.BtnValide);
            this.xtraTabPage1.Controls.Add(this.BtnAnnuler);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.txtRequestCode);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.txtSerialNumber);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(512, 205);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.Location = new System.Drawing.Point(124, 90);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerialNumber.Properties.Appearance.Options.UseFont = true;
            this.txtSerialNumber.Size = new System.Drawing.Size(382, 49);
            this.txtSerialNumber.TabIndex = 7;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.labelControl4);
            this.xtraTabPage2.Controls.Add(this.labelControl2);
            this.xtraTabPage2.Controls.Add(this.txtStatus);
            this.xtraTabPage2.Controls.Add(this.txtSerial);
            this.xtraTabPage2.Controls.Add(this.BtnAnnulerEssai);
            this.xtraTabPage2.Controls.Add(this.BtnValidEssai);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(512, 205);
            this.xtraTabPage2.Text = "xtraTabPage2";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(11, 71);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(77, 23);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Situation";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(11, 32);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(34, 23);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Cle ";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(107, 72);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Properties.Appearance.Options.UseFont = true;
            this.txtStatus.Properties.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(398, 61);
            this.txtStatus.TabIndex = 3;
            // 
            // txtSerial
            // 
            this.txtSerial.Location = new System.Drawing.Point(107, 29);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerial.Properties.Appearance.Options.UseFont = true;
            this.txtSerial.Size = new System.Drawing.Size(398, 26);
            this.txtSerial.TabIndex = 2;
            // 
            // BtnAnnulerEssai
            // 
            this.BtnAnnulerEssai.Appearance.Font = new System.Drawing.Font("Elephant", 9.75F);
            this.BtnAnnulerEssai.Appearance.Options.UseFont = true;
            this.BtnAnnulerEssai.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAnnulerEssai.ImageOptions.Image")));
            this.BtnAnnulerEssai.Location = new System.Drawing.Point(312, 162);
            this.BtnAnnulerEssai.Name = "BtnAnnulerEssai";
            this.BtnAnnulerEssai.Size = new System.Drawing.Size(147, 36);
            this.BtnAnnulerEssai.TabIndex = 1;
            this.BtnAnnulerEssai.Text = "FERMER";
            this.BtnAnnulerEssai.Click += new System.EventHandler(this.BtnAnnulerEssai_Click);
            // 
            // BtnValidEssai
            // 
            this.BtnValidEssai.Appearance.Font = new System.Drawing.Font("Elephant", 9.75F);
            this.BtnValidEssai.Appearance.Options.UseFont = true;
            this.BtnValidEssai.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnValidEssai.ImageOptions.Image")));
            this.BtnValidEssai.Location = new System.Drawing.Point(92, 162);
            this.BtnValidEssai.Name = "BtnValidEssai";
            this.BtnValidEssai.Size = new System.Drawing.Size(147, 36);
            this.BtnValidEssai.TabIndex = 0;
            this.BtnValidEssai.Text = "VALIDER";
            this.BtnValidEssai.Click += new System.EventHandler(this.BtnValidEssai_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.privee);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(518, 34);
            this.panelControl1.TabIndex = 2;
            // 
            // privee
            // 
            this.privee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.privee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.privee.Location = new System.Drawing.Point(2, 2);
            this.privee.Margin = new System.Windows.Forms.Padding(0);
            this.privee.Name = "privee";
            this.privee.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.privee.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.privee.Properties.Appearance.Options.UseBackColor = true;
            this.privee.Properties.Appearance.Options.UseFont = true;
            this.privee.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.privee.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.privee.Properties.OffText = "Clé de licence";
            this.privee.Properties.OnText = "clé d\'essaie";
            this.privee.Size = new System.Drawing.Size(514, 30);
            this.privee.TabIndex = 342;
            this.privee.Toggled += new System.EventHandler(this.privee_Toggled);
            // 
            // proctection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.behaviorManager1.SetBehaviors(this, new DevExpress.Utils.Behaviors.Behavior[] {
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.Utils.Behaviors.Common.SnapWindowBehavior.Create(typeof(DevExpress.Utils.BehaviorSource.SnapWindowBehaviorSourceForForm), snapOptions1)))});
            this.ClientSize = new System.Drawing.Size(518, 267);
            this.Controls.Add(this.tbPro);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "proctection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "proctection";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.proctection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtRequestCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPro)).EndInit();
            this.tbPro.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerialNumber.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.privee.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtRequestCode;
        private DevExpress.XtraEditors.SimpleButton BtnAnnuler;
        private DevExpress.XtraEditors.SimpleButton BtnValide;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraTab.XtraTabControl tbPro;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.ToggleSwitch privee;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.MemoEdit txtStatus;
        private DevExpress.XtraEditors.TextEdit txtSerial;
        private DevExpress.XtraEditors.SimpleButton BtnAnnulerEssai;
        private DevExpress.XtraEditors.SimpleButton BtnValidEssai;
        private DevExpress.XtraEditors.MemoEdit txtSerialNumber;
    }
}