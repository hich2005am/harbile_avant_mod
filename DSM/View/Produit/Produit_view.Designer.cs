namespace DSM.View.Client
{
    partial class Produit_view
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
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions2 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions3 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produit_view));
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions4 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions5 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions6 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions7 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            this.gdClient = new DevExpress.XtraGrid.GridControl();
            this.gvClient = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColID_CL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCNIE_CL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.colADR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.windowsUIButtonPanel1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gdClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gdClient
            // 
            this.behaviorManager1.SetBehaviors(this.gdClient, new DevExpress.Utils.Behaviors.Behavior[] {
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.Utils.Behaviors.Common.PersistenceBehavior.Create(typeof(DevExpress.Utils.BehaviorSource.PersistenceBehaviorSourceForControl), "design\\produit\\grid.xml", DevExpress.Utils.Behaviors.Common.Storage.File, DevExpress.Utils.DefaultBoolean.Default)))});
            this.gdClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdClient.Location = new System.Drawing.Point(0, 0);
            this.gdClient.LookAndFeel.SkinName = "VS2010";
            this.gdClient.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.gdClient.MainView = this.gvClient;
            this.gdClient.Name = "gdClient";
            this.gdClient.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1});
            this.gdClient.Size = new System.Drawing.Size(1138, 542);
            this.gdClient.TabIndex = 12;
            this.gdClient.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvClient});
            this.gdClient.Load += new System.EventHandler(this.gdClient_Load);
            this.gdClient.Click += new System.EventHandler(this.gdClient_Click);
            // 
            // gvClient
            // 
            this.gvClient.Appearance.HeaderPanel.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvClient.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvClient.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvClient.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvClient.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvClient.Appearance.Row.Options.UseFont = true;
            this.gvClient.Appearance.Row.Options.UseTextOptions = true;
            this.gvClient.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvClient.Appearance.ViewCaption.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Bold);
            this.gvClient.Appearance.ViewCaption.Options.UseFont = true;
            this.gvClient.AppearancePrint.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvClient.AppearancePrint.HeaderPanel.Options.UseFont = true;
            this.gvClient.AppearancePrint.HeaderPanel.Options.UseTextOptions = true;
            this.gvClient.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvClient.AppearancePrint.Row.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvClient.AppearancePrint.Row.Options.UseFont = true;
            this.gvClient.AppearancePrint.Row.Options.UseTextOptions = true;
            this.gvClient.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvClient.ColumnPanelRowHeight = 50;
            this.gvClient.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColID_CL,
            this.colNom,
            this.colCNIE_CL,
            this.colADR,
            this.gridColumn5,
            this.colType,
            this.gridColumn1});
            this.gvClient.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvClient.GridControl = this.gdClient;
            this.gvClient.Name = "gvClient";
            this.gvClient.OptionsBehavior.Editable = false;
            this.gvClient.OptionsCustomization.AllowGroup = false;
            this.gvClient.OptionsNavigation.AutoFocusNewRow = true;
            this.gvClient.OptionsNavigation.EnterMoveNextColumn = true;
            this.gvClient.OptionsPrint.PrintFooter = false;
            this.gvClient.OptionsPrint.PrintGroupFooter = false;
            this.gvClient.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvClient.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gvClient.OptionsView.ShowFooter = true;
            this.gvClient.OptionsView.ShowGroupPanel = false;
            this.gvClient.OptionsView.ShowIndicator = false;
            this.gvClient.OptionsView.ShowViewCaption = true;
            this.gvClient.RowHeight = 60;
            this.gvClient.ViewCaption = "PRODUITS";
            this.gvClient.PrintInitialize += new DevExpress.XtraGrid.Views.Base.PrintInitializeEventHandler(this.gvClient_PrintInitialize);
            // 
            // ColID_CL
            // 
            this.ColID_CL.Caption = "N° PRODUIT";
            this.ColID_CL.FieldName = "ID_PDT";
            this.ColID_CL.Name = "ColID_CL";
            this.ColID_CL.Visible = true;
            this.ColID_CL.VisibleIndex = 0;
            this.ColID_CL.Width = 196;
            // 
            // colNom
            // 
            this.colNom.Caption = "NOM PRODUIT";
            this.colNom.FieldName = "Designe_PDT";
            this.colNom.Name = "colNom";
            this.colNom.Visible = true;
            this.colNom.VisibleIndex = 1;
            this.colNom.Width = 267;
            // 
            // colCNIE_CL
            // 
            this.colCNIE_CL.AppearanceCell.Options.UseTextOptions = true;
            this.colCNIE_CL.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colCNIE_CL.Caption = "DESCRIPTION";
            this.colCNIE_CL.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colCNIE_CL.FieldName = "description_PDT";
            this.colCNIE_CL.Name = "colCNIE_CL";
            this.colCNIE_CL.Visible = true;
            this.colCNIE_CL.VisibleIndex = 4;
            this.colCNIE_CL.Width = 273;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // colADR
            // 
            this.colADR.Caption = "PRIX UNITAIRE";
            this.colADR.DisplayFormat.FormatString = "{0:n2} UT/Tonne";
            this.colADR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colADR.FieldName = "prixUnitaire_PDT";
            this.colADR.Name = "colADR";
            this.colADR.Visible = true;
            this.colADR.VisibleIndex = 3;
            this.colADR.Width = 203;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Word;
            this.gridColumn5.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.gridColumn5.Caption = "QUANTITE Initial";
            this.gridColumn5.DisplayFormat.FormatString = "{0:n0} Kg";
            this.gridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn5.FieldName = "QtInitial_PDT";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            this.gridColumn5.Width = 197;
            // 
            // colType
            // 
            this.colType.Caption = "Fax";
            this.colType.FieldName = "Fax_CL";
            this.colType.Name = "colType";
            this.colType.Width = 118;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Note";
            this.gridColumn1.FieldName = "Note_CL";
            this.gridColumn1.Name = "gridColumn1";
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
            windowsUIButtonImageOptions1.ImageUri.Uri = "Show;GrayScaled";
            windowsUIButtonImageOptions2.ImageUri.Uri = "AddItem;Size32x32;GrayScaled";
            windowsUIButtonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonImageOptions3.Image")));
            windowsUIButtonImageOptions3.ImageUri.Uri = "Delete;Size32x32;GrayScaled";
            windowsUIButtonImageOptions4.ImageUri.Uri = "Edit;Size32x32;GrayScaled";
            windowsUIButtonImageOptions5.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonImageOptions5.Image")));
            windowsUIButtonImageOptions6.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonImageOptions6.Image")));
            windowsUIButtonImageOptions7.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonImageOptions7.Image")));
            this.windowsUIButtonPanel1.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("VUE", true, windowsUIButtonImageOptions1),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("NOUVEAU", true, windowsUIButtonImageOptions2),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("SUPRIMER", true, windowsUIButtonImageOptions3),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("MODIFIER", true, windowsUIButtonImageOptions4),
            new DevExpress.XtraBars.Docking2010.WindowsUISeparator(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("EXPORTER", true, windowsUIButtonImageOptions5),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("IMPRIMER", true, windowsUIButtonImageOptions6),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("FILTRE", true, windowsUIButtonImageOptions7)});
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
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1});
            this.accordionControl1.Location = new System.Drawing.Point(0, 0);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.Size = new System.Drawing.Size(192, 290);
            this.accordionControl1.TabIndex = 11;
            this.accordionControl1.Text = "accordionControl1";
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "Element1";
            // 
            // dockManager1
            // 
            this.dockManager1.DockingOptions.ShowCloseButton = false;
            this.dockManager1.DockModeVS2005FadeSpeed = 1500;
            this.dockManager1.Form = this;
            this.dockManager1.HiddenPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl"});
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float;
            this.dockPanel1.FloatLocation = new System.Drawing.Point(332, 135);
            this.dockPanel1.FloatSize = new System.Drawing.Size(200, 320);
            this.dockPanel1.FloatVertical = true;
            this.dockPanel1.ID = new System.Guid("82e3fbd1-08e7-4159-aa66-ea7f2dd78633");
            this.dockPanel1.Location = new System.Drawing.Point(-32768, -32768);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel1.SavedIndex = 0;
            this.dockPanel1.Size = new System.Drawing.Size(200, 320);
            this.dockPanel1.Text = "dockPanel1";
            this.dockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.accordionControl1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 26);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(192, 290);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // Produit_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gdClient);
            this.Controls.Add(this.panelControl1);
            this.Name = "Produit_view";
            this.Size = new System.Drawing.Size(1138, 630);
            this.Load += new System.EventHandler(this.Client_view_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.Views.Grid.GridView gvClient;
        private DevExpress.XtraGrid.Columns.GridColumn ColID_CL;
        private DevExpress.XtraGrid.Columns.GridColumn colNom;
        private DevExpress.XtraGrid.Columns.GridColumn colCNIE_CL;
        private DevExpress.XtraGrid.Columns.GridColumn colADR;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn colType;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        public DevExpress.XtraGrid.GridControl gdClient;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanel1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}