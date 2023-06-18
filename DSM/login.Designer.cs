namespace DSM
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.BtnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.BtnFermer = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.txtMtp = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmxUser = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMtp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmxUser.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.Appearance.Image")));
            this.groupControl1.Appearance.Options.UseImage = true;
            this.groupControl1.Appearance.Options.UseTextOptions = true;
            this.groupControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.groupControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.BtnLogin);
            this.groupControl1.Controls.Add(this.BtnFermer);
            this.groupControl1.Controls.Add(this.pictureEdit1);
            this.groupControl1.Controls.Add(this.txtMtp);
            this.groupControl1.Controls.Add(this.cmxUser);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(477, 419);
            this.groupControl1.TabIndex = 14;
            this.groupControl1.Text = " DSM TECHNOLOGIE";
            // 
            // BtnLogin
            // 
            this.BtnLogin.Appearance.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.Appearance.Options.UseFont = true;
            this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnLogin.ImageOptions.Image")));
            this.BtnLogin.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.BtnLogin.Location = new System.Drawing.Point(246, 365);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.BtnLogin.Size = new System.Drawing.Size(218, 42);
            this.BtnLogin.TabIndex = 11;
            this.BtnLogin.Text = "LOGIN";
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnFermer
            // 
            this.BtnFermer.Appearance.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFermer.Appearance.Options.UseFont = true;
            this.BtnFermer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFermer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnFermer.ImageOptions.Image")));
            this.BtnFermer.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.BtnFermer.Location = new System.Drawing.Point(6, 365);
            this.BtnFermer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnFermer.Name = "BtnFermer";
            this.BtnFermer.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.BtnFermer.Size = new System.Drawing.Size(218, 42);
            this.BtnFermer.TabIndex = 4;
            this.BtnFermer.Text = "FERMER";
            this.BtnFermer.Click += new System.EventHandler(this.BtnFermer_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(5, 42);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEdit1.Size = new System.Drawing.Size(467, 213);
            this.pictureEdit1.TabIndex = 6;
            // 
            // txtMtp
            // 
            this.txtMtp.EditValue = "";
            this.txtMtp.Location = new System.Drawing.Point(12, 309);
            this.txtMtp.Name = "txtMtp";
            this.txtMtp.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMtp.Properties.Appearance.Options.UseFont = true;
            this.txtMtp.Properties.Appearance.Options.UseTextOptions = true;
            this.txtMtp.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtMtp.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.txtMtp.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, true, editorButtonImageOptions1)});
            this.txtMtp.Properties.PasswordChar = '*';
            this.txtMtp.Properties.UseSystemPasswordChar = true;
            this.txtMtp.Size = new System.Drawing.Size(452, 40);
            this.txtMtp.TabIndex = 10;
            this.txtMtp.EditValueChanged += new System.EventHandler(this.txtMtp_EditValueChanged);
            // 
            // cmxUser
            // 
            this.cmxUser.EditValue = "";
            this.cmxUser.Location = new System.Drawing.Point(12, 261);
            this.cmxUser.Name = "cmxUser";
            this.cmxUser.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmxUser.Properties.Appearance.Options.UseFont = true;
            this.cmxUser.Properties.Appearance.Options.UseTextOptions = true;
            this.cmxUser.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cmxUser.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmxUser.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cmxUser.Properties.AppearanceDropDown.Options.UseTextOptions = true;
            this.cmxUser.Properties.AppearanceDropDown.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cmxUser.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            editorButtonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions3.Image")));
            this.cmxUser.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, true, editorButtonImageOptions2),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, false, true, editorButtonImageOptions3)});
            this.cmxUser.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("User_Op", "Name5", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Center)});
            this.cmxUser.Properties.NullText = "";
            this.cmxUser.Properties.PopupSizeable = false;
            this.cmxUser.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.OnlyInPopup;
            this.cmxUser.Properties.ShowFooter = false;
            this.cmxUser.Properties.ShowHeader = false;
            this.cmxUser.Properties.ShowLines = false;
            this.cmxUser.Size = new System.Drawing.Size(452, 40);
            this.cmxUser.TabIndex = 9;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 419);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMtp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmxUser.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton BtnFermer;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.ComboBoxEdit txtMtp;
        private DevExpress.XtraEditors.SimpleButton BtnLogin;
        private DevExpress.XtraEditors.LookUpEdit cmxUser;
    }
}