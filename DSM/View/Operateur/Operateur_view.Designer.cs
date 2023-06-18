namespace DSM.View.Client
{
    partial class Operateur_view
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
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions5 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions6 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions7 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions8 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            this.gdFournisseur = new DevExpress.XtraGrid.GridControl();
            this.gvFournisseur = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColID_FR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCNIE_FR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colADR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.windowsUIButtonPanel1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.gdFournisseur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFournisseur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gdFournisseur
            // 
            this.gdFournisseur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdFournisseur.Location = new System.Drawing.Point(0, 0);
            this.gdFournisseur.LookAndFeel.SkinName = "VS2010";
            this.gdFournisseur.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.gdFournisseur.MainView = this.gvFournisseur;
            this.gdFournisseur.Name = "gdFournisseur";
            this.gdFournisseur.Size = new System.Drawing.Size(1138, 542);
            this.gdFournisseur.TabIndex = 12;
            this.gdFournisseur.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvFournisseur});
            this.gdFournisseur.Load += new System.EventHandler(this.gdFournisseur_Load);
            // 
            // gvFournisseur
            // 
            this.gvFournisseur.Appearance.HeaderPanel.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvFournisseur.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvFournisseur.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvFournisseur.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvFournisseur.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvFournisseur.Appearance.Row.Options.UseFont = true;
            this.gvFournisseur.Appearance.Row.Options.UseTextOptions = true;
            this.gvFournisseur.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvFournisseur.Appearance.ViewCaption.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Bold);
            this.gvFournisseur.Appearance.ViewCaption.Options.UseFont = true;
            this.gvFournisseur.AppearancePrint.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvFournisseur.AppearancePrint.HeaderPanel.Options.UseFont = true;
            this.gvFournisseur.AppearancePrint.HeaderPanel.Options.UseTextOptions = true;
            this.gvFournisseur.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvFournisseur.AppearancePrint.Row.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvFournisseur.AppearancePrint.Row.Options.UseFont = true;
            this.gvFournisseur.AppearancePrint.Row.Options.UseTextOptions = true;
            this.gvFournisseur.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvFournisseur.ColumnPanelRowHeight = 45;
            this.gvFournisseur.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColID_FR,
            this.colNom,
            this.colCNIE_FR,
            this.colADR,
            this.gridColumn5,
            this.colType,
            this.gridColumn1});
            this.gvFournisseur.GridControl = this.gdFournisseur;
            this.gvFournisseur.Name = "gvFournisseur";
            this.gvFournisseur.OptionsBehavior.Editable = false;
            this.gvFournisseur.OptionsCustomization.AllowGroup = false;
            this.gvFournisseur.OptionsNavigation.AutoFocusNewRow = true;
            this.gvFournisseur.OptionsNavigation.EnterMoveNextColumn = true;
            this.gvFournisseur.OptionsPrint.PrintFooter = false;
            this.gvFournisseur.OptionsPrint.PrintGroupFooter = false;
            this.gvFournisseur.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvFournisseur.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gvFournisseur.OptionsView.ShowFooter = true;
            this.gvFournisseur.OptionsView.ShowGroupPanel = false;
            this.gvFournisseur.OptionsView.ShowIndicator = false;
            this.gvFournisseur.OptionsView.ShowViewCaption = true;
            this.gvFournisseur.RowHeight = 40;
            this.gvFournisseur.ViewCaption = "OPERATEURS";
            this.gvFournisseur.PrintInitialize += new DevExpress.XtraGrid.Views.Base.PrintInitializeEventHandler(this.gvFournisseur_PrintInitialize);
            // 
            // ColID_FR
            // 
            this.ColID_FR.Caption = "N° operateur";
            this.ColID_FR.FieldName = "ID_Op";
            this.ColID_FR.Name = "ColID_FR";
            this.ColID_FR.Visible = true;
            this.ColID_FR.VisibleIndex = 0;
            this.ColID_FR.Width = 101;
            // 
            // colNom
            // 
            this.colNom.Caption = "Nom et prenom";
            this.colNom.FieldName = "Nom_Op";
            this.colNom.Name = "colNom";
            this.colNom.Visible = true;
            this.colNom.VisibleIndex = 2;
            this.colNom.Width = 138;
            // 
            // colCNIE_FR
            // 
            this.colCNIE_FR.Caption = "utilisateur";
            this.colCNIE_FR.FieldName = "User_Op";
            this.colCNIE_FR.Name = "colCNIE_FR";
            this.colCNIE_FR.Visible = true;
            this.colCNIE_FR.VisibleIndex = 1;
            this.colCNIE_FR.Width = 115;
            // 
            // colADR
            // 
            this.colADR.Caption = "Type OPERATEUR";
            this.colADR.FieldName = "Type_Op";
            this.colADR.Name = "colADR";
            this.colADR.Visible = true;
            this.colADR.VisibleIndex = 4;
            this.colADR.Width = 115;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "mot passe";
            this.gridColumn5.FieldName = "Password_Op";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            this.gridColumn5.Width = 115;
            // 
            // colType
            // 
            this.colType.Caption = "ETAT";
            this.colType.FieldName = "Etat_Op";
            this.colType.Name = "colType";
            this.colType.Visible = true;
            this.colType.VisibleIndex = 5;
            this.colType.Width = 118;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Role OPERATEUR";
            this.gridColumn1.FieldName = "Role_Op";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 6;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.windowsUIButtonPanel1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 542);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1138, 88);
            this.panelControl1.TabIndex = 0;
            // 
            // windowsUIButtonPanel1
            // 
            this.windowsUIButtonPanel1.AppearanceButton.Hovered.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.windowsUIButtonPanel1.AppearanceButton.Hovered.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.windowsUIButtonPanel1.AppearanceButton.Hovered.Options.UseFont = true;
            this.windowsUIButtonPanel1.AppearanceButton.Normal.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowsUIButtonPanel1.AppearanceButton.Normal.Options.UseFont = true;
            this.windowsUIButtonPanel1.AppearanceButton.Pressed.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.windowsUIButtonPanel1.AppearanceButton.Pressed.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.windowsUIButtonPanel1.AppearanceButton.Pressed.Options.UseFont = true;
            this.windowsUIButtonPanel1.ButtonInterval = 50;
            windowsUIButtonImageOptions5.ImageUri.Uri = "Show;GrayScaled";
            windowsUIButtonImageOptions6.ImageUri.Uri = "AddItem;Size32x32;GrayScaled";
            windowsUIButtonImageOptions7.ImageUri.Uri = "Delete;Size32x32;GrayScaled";
            windowsUIButtonImageOptions8.ImageUri.Uri = "Edit;Size32x32;GrayScaled";
            this.windowsUIButtonPanel1.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("VUE", true, windowsUIButtonImageOptions5),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("NOUVEAU", true, windowsUIButtonImageOptions6),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("SUPRIMER", true, windowsUIButtonImageOptions7),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("MODIFIER", true, windowsUIButtonImageOptions8),
            new DevExpress.XtraBars.Docking2010.WindowsUISeparator(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("EXPORTER", DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("IMPRIMER", DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("FILTRE", DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton)});
            this.windowsUIButtonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.windowsUIButtonPanel1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowsUIButtonPanel1.Location = new System.Drawing.Point(2, 2);
            this.windowsUIButtonPanel1.Name = "windowsUIButtonPanel1";
            this.windowsUIButtonPanel1.ShowPeekFormOnItemHover = true;
            this.windowsUIButtonPanel1.Size = new System.Drawing.Size(1134, 84);
            this.windowsUIButtonPanel1.TabIndex = 8;
            this.windowsUIButtonPanel1.Text = "windowsUIButtonPanel1";
            this.windowsUIButtonPanel1.UseButtonBackgroundImages = false;
            this.windowsUIButtonPanel1.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.windowsUIButtonPanel1_ButtonClick);
            // 
            // Operateur_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gdFournisseur);
            this.Controls.Add(this.panelControl1);
            this.Name = "Operateur_view";
            this.Size = new System.Drawing.Size(1138, 630);
            this.Load += new System.EventHandler(this.Client_view_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdFournisseur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFournisseur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.Views.Grid.GridView gvFournisseur;
        private DevExpress.XtraGrid.Columns.GridColumn ColID_FR;
        private DevExpress.XtraGrid.Columns.GridColumn colNom;
        private DevExpress.XtraGrid.Columns.GridColumn colCNIE_FR;
        private DevExpress.XtraGrid.Columns.GridColumn colADR;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn colType;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        public DevExpress.XtraGrid.GridControl gdFournisseur;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanel1;
    }
}