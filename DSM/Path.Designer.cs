namespace DSM
{
    partial class Path
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Path));
            this.txtSauvgarde = new DevExpress.XtraEditors.ButtonEdit();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.txtDatabase = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.BtnAnnuler = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.chActiveSauvgarde = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSauvgarde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatabase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chActiveSauvgarde.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSauvgarde
            // 
            this.behaviorManager1.SetBehaviors(this.txtSauvgarde, new DevExpress.Utils.Behaviors.Behavior[] {
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.Utils.Behaviors.Common.FileIconBehavior.Create(typeof(DevExpress.XtraEditors.Behaviors.FileIconBehaviorSourceForTextEdit), DevExpress.Utils.Behaviors.Common.FileIconSize.Small, null, null))),
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.Utils.Behaviors.Common.OpenFolderBehavior.Create(typeof(DevExpress.XtraEditors.Behaviors.OpenFolderBehaviorSourceForButtonEdit), true, DevExpress.Utils.Behaviors.Common.FileIconSize.Medium, ((System.Drawing.Image)(resources.GetObject("txtSauvgarde.Behaviors"))), null, DevExpress.Utils.Behaviors.Common.CompletionMode.Directories, null)))});
            this.txtSauvgarde.Location = new System.Drawing.Point(122, 12);
            this.txtSauvgarde.Name = "txtSauvgarde";
            this.txtSauvgarde.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSauvgarde.Properties.Appearance.Options.UseFont = true;
            this.txtSauvgarde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtSauvgarde.Size = new System.Drawing.Size(475, 28);
            this.txtSauvgarde.TabIndex = 0;
            this.txtSauvgarde.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.Sauvgarde_ButtonPressed);
            // 
            // txtDatabase
            // 
            this.behaviorManager1.SetBehaviors(this.txtDatabase, new DevExpress.Utils.Behaviors.Behavior[] {
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.Utils.Behaviors.Common.OpenFileBehavior.Create(typeof(DevExpress.XtraEditors.Behaviors.OpenFileBehaviorSourceForButtonEdit), true, DevExpress.Utils.Behaviors.Common.FileIconSize.Medium, ((System.Drawing.Image)(resources.GetObject("txtDatabase.Behaviors"))), null, DevExpress.Utils.Behaviors.Common.CompletionMode.FilesAndDirectories, ".accdb")))});
            this.txtDatabase.Location = new System.Drawing.Point(122, 70);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatabase.Properties.Appearance.Options.UseFont = true;
            this.txtDatabase.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtDatabase.Size = new System.Drawing.Size(475, 28);
            this.txtDatabase.TabIndex = 2;
            this.txtDatabase.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.BD_ButtonPressed);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(6, 78);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(95, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Base de donne";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(6, 20);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 16);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Sauvgarde";
            // 
            // BtnAnnuler
            // 
            this.BtnAnnuler.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnnuler.Appearance.Options.UseFont = true;
            this.BtnAnnuler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAnnuler.ImageOptions.Image")));
            this.BtnAnnuler.Location = new System.Drawing.Point(372, 145);
            this.BtnAnnuler.Name = "BtnAnnuler";
            this.BtnAnnuler.Size = new System.Drawing.Size(157, 34);
            this.BtnAnnuler.TabIndex = 6;
            this.BtnAnnuler.Text = "ANNULER";
            this.BtnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Appearance.Options.UseFont = true;
            this.BtnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.ImageOptions.Image")));
            this.BtnSave.Location = new System.Drawing.Point(97, 145);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(156, 34);
            this.BtnSave.TabIndex = 7;
            this.BtnSave.Text = "ENREGESTRER";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "accdb";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Access 2007 (*.accdb)|*accdb";
            // 
            // chActiveSauvgarde
            // 
            this.chActiveSauvgarde.Location = new System.Drawing.Point(12, 116);
            this.chActiveSauvgarde.Name = "chActiveSauvgarde";
            this.chActiveSauvgarde.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chActiveSauvgarde.Properties.Appearance.Options.UseFont = true;
            this.chActiveSauvgarde.Properties.Caption = "Active Sauvgarde";
            this.chActiveSauvgarde.Size = new System.Drawing.Size(249, 23);
            this.chActiveSauvgarde.TabIndex = 8;
            this.chActiveSauvgarde.CheckedChanged += new System.EventHandler(this.chActiveSauvgarde_CheckedChanged);
            // 
            // Path
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 185);
            this.Controls.Add(this.chActiveSauvgarde);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnAnnuler);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtDatabase);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtSauvgarde);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Path";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XtraForm2";
            this.Load += new System.EventHandler(this.Path_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSauvgarde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatabase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chActiveSauvgarde.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ButtonEdit txtSauvgarde;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ButtonEdit txtDatabase;
        private DevExpress.XtraEditors.SimpleButton BtnAnnuler;
        private DevExpress.XtraEditors.SimpleButton BtnSave;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevExpress.XtraEditors.CheckEdit chActiveSauvgarde;
    }
}