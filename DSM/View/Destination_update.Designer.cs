namespace DSM.View
{
    partial class type_update
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(type_update));
            this.gdAttente_public = new DevExpress.XtraGrid.GridControl();
            this.gvAttente_public = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rpSup = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lblNum = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtNom = new DevExpress.XtraEditors.TextEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.BtnNV = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.BtnClose = new DevExpress.XtraEditors.SimpleButton();
            this.BtnAnnuler = new DevExpress.XtraEditors.SimpleButton();
            this.BtnModifier = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSup = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gdAttente_public)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAttente_public)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpSup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gdAttente_public
            // 
            this.gdAttente_public.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdAttente_public.Location = new System.Drawing.Point(200, 46);
            this.gdAttente_public.MainView = this.gvAttente_public;
            this.gdAttente_public.Name = "gdAttente_public";
            this.gdAttente_public.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rpSup});
            this.gdAttente_public.Size = new System.Drawing.Size(523, 349);
            this.gdAttente_public.TabIndex = 161;
            this.gdAttente_public.TabStop = false;
            this.gdAttente_public.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAttente_public});
            // 
            // gvAttente_public
            // 
            this.gvAttente_public.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvAttente_public.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvAttente_public.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvAttente_public.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvAttente_public.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvAttente_public.Appearance.Row.Options.UseFont = true;
            this.gvAttente_public.Appearance.Row.Options.UseTextOptions = true;
            this.gvAttente_public.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvAttente_public.Appearance.TopNewRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gvAttente_public.Appearance.TopNewRow.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvAttente_public.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvAttente_public.Appearance.TopNewRow.Options.UseFont = true;
            this.gvAttente_public.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNum,
            this.colNom,
            this.gridColumn12});
            this.gvAttente_public.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gvAttente_public.GridControl = this.gdAttente_public;
            this.gvAttente_public.Name = "gvAttente_public";
            this.gvAttente_public.NewItemRowText = "AJOUT LIGNE";
            this.gvAttente_public.OptionsView.ShowFooter = true;
            this.gvAttente_public.OptionsView.ShowGroupPanel = false;
            this.gvAttente_public.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colNum, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvAttente_public.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gvAttente_public_RowCellClick_1);
            this.gvAttente_public.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvAttente_public_FocusedRowChanged);
            // 
            // colNum
            // 
            this.colNum.Caption = "N°";
            this.colNum.FieldName = "ID_DS";
            this.colNum.Name = "colNum";
            this.colNum.OptionsColumn.AllowEdit = false;
            this.colNum.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colNum.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colNum.Visible = true;
            this.colNum.VisibleIndex = 0;
            this.colNum.Width = 77;
            // 
            // colNom
            // 
            this.colNom.Caption = "Nom";
            this.colNom.DisplayFormat.FormatString = "MM/dd/yyyy H:mm";
            this.colNom.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNom.FieldName = "Nom_DS";
            this.colNom.Name = "colNom";
            this.colNom.Visible = true;
            this.colNom.VisibleIndex = 1;
            this.colNom.Width = 147;
            // 
            // gridColumn12
            // 
            this.gridColumn12.ColumnEdit = this.rpSup;
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Width = 141;
            // 
            // rpSup
            // 
            this.rpSup.AutoHeight = false;
            this.rpSup.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "Supprimer", -1, true, false, false, editorButtonImageOptions1)});
            this.rpSup.Name = "rpSup";
            this.rpSup.NullText = "SUPPRIMER";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lblNum);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.txtNom);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(200, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(523, 46);
            this.panelControl1.TabIndex = 162;
            // 
            // lblNum
            // 
            this.lblNum.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.Appearance.Options.UseFont = true;
            this.lblNum.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.lblNum.Location = new System.Drawing.Point(98, 12);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(15, 27);
            this.lblNum.TabIndex = 6;
            this.lblNum.Text = "0";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 13);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(23, 23);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "N°";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(224, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 23);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Nom";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(299, 8);
            this.txtNom.Name = "txtNom";
            this.txtNom.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Properties.Appearance.Options.UseFont = true;
            this.txtNom.Properties.Appearance.Options.UseTextOptions = true;
            this.txtNom.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtNom.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtNom.Properties.ReadOnly = true;
            this.txtNom.Size = new System.Drawing.Size(214, 32);
            this.txtNom.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Enabled = false;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(7, 190);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(182, 42);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "ENREGESTRER";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // BtnNV
            // 
            this.BtnNV.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNV.Appearance.Options.UseFont = true;
            this.BtnNV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnNV.ImageOptions.Image")));
            this.BtnNV.Location = new System.Drawing.Point(5, 13);
            this.BtnNV.Name = "BtnNV";
            this.BtnNV.Size = new System.Drawing.Size(183, 42);
            this.BtnNV.TabIndex = 3;
            this.BtnNV.Text = "NOUVEAU";
            this.BtnNV.Click += new System.EventHandler(this.BtnNV_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.BtnClose);
            this.panelControl2.Controls.Add(this.BtnAnnuler);
            this.panelControl2.Controls.Add(this.BtnModifier);
            this.panelControl2.Controls.Add(this.BtnSup);
            this.panelControl2.Controls.Add(this.btnSave);
            this.panelControl2.Controls.Add(this.BtnNV);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(200, 395);
            this.panelControl2.TabIndex = 163;
            // 
            // BtnClose
            // 
            this.BtnClose.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Appearance.Options.UseFont = true;
            this.BtnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.ImageOptions.Image")));
            this.BtnClose.Location = new System.Drawing.Point(8, 308);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(182, 42);
            this.BtnClose.TabIndex = 7;
            this.BtnClose.Text = "Fermer";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnAnnuler
            // 
            this.BtnAnnuler.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnnuler.Appearance.Options.UseFont = true;
            this.BtnAnnuler.Enabled = false;
            this.BtnAnnuler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAnnuler.ImageOptions.Image")));
            this.BtnAnnuler.Location = new System.Drawing.Point(5, 132);
            this.BtnAnnuler.Name = "BtnAnnuler";
            this.BtnAnnuler.Size = new System.Drawing.Size(182, 42);
            this.BtnAnnuler.TabIndex = 6;
            this.BtnAnnuler.Text = "Annuler";
            this.BtnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // BtnModifier
            // 
            this.BtnModifier.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModifier.Appearance.Options.UseFont = true;
            this.BtnModifier.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnModifier.ImageOptions.Image")));
            this.BtnModifier.Location = new System.Drawing.Point(5, 71);
            this.BtnModifier.Name = "BtnModifier";
            this.BtnModifier.Size = new System.Drawing.Size(182, 42);
            this.BtnModifier.TabIndex = 5;
            this.BtnModifier.Text = "Modifier";
            this.BtnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // BtnSup
            // 
            this.BtnSup.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSup.Appearance.Options.UseFont = true;
            this.BtnSup.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSup.ImageOptions.Image")));
            this.BtnSup.Location = new System.Drawing.Point(8, 249);
            this.BtnSup.Name = "BtnSup";
            this.BtnSup.Size = new System.Drawing.Size(182, 42);
            this.BtnSup.TabIndex = 0;
            this.BtnSup.Text = "SUPPRIMER";
            this.BtnSup.Click += new System.EventHandler(this.BtnSup_Click);
            // 
            // type_update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 395);
            this.Controls.Add(this.gdAttente_public);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "type_update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.XtraForm2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdAttente_public)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAttente_public)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpSup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gdAttente_public;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAttente_public;
        private DevExpress.XtraGrid.Columns.GridColumn colNum;
        private DevExpress.XtraGrid.Columns.GridColumn colNom;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit rpSup;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton BtnNV;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtNom;
        private DevExpress.XtraEditors.LabelControl lblNum;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton BtnSup;
        private DevExpress.XtraEditors.SimpleButton BtnModifier;
        private DevExpress.XtraEditors.SimpleButton BtnAnnuler;
        private DevExpress.XtraEditors.SimpleButton BtnClose;
    }
}