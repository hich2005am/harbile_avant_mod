namespace DSM.View.Client
{
    partial class Transporteur_view
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
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions8 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions9 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions10 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transporteur_view));
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions11 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions12 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions13 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions14 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            this.gdClient = new DevExpress.XtraGrid.GridControl();
            this.gvClient = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColID_CL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCNIE_CL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colADR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.Utils.Behaviors.Common.PersistenceBehavior.Create(typeof(DevExpress.Utils.BehaviorSource.PersistenceBehaviorSourceForControl), "design\\transporteur\\grid.xml", DevExpress.Utils.Behaviors.Common.Storage.File, DevExpress.Utils.DefaultBoolean.True)))});
            this.gdClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdClient.Location = new System.Drawing.Point(0, 0);
            this.gdClient.LookAndFeel.SkinName = "VS2010";
            this.gdClient.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.gdClient.MainView = this.gvClient;
            this.gdClient.Name = "gdClient";
            this.gdClient.Size = new System.Drawing.Size(1138, 542);
            this.gdClient.TabIndex = 12;
            this.gdClient.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvClient});
            this.gdClient.Load += new System.EventHandler(this.gdClient_Load);
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
            this.gvClient.ColumnPanelRowHeight = 45;
            this.gvClient.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColID_CL,
            this.colNom,
            this.colCNIE_CL,
            this.colADR,
            this.gridColumn5,
            this.gridColumn1});
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
            this.gvClient.RowHeight = 40;
            this.gvClient.ViewCaption = "TRANSPORTEURS";
            this.gvClient.PrintInitialize += new DevExpress.XtraGrid.Views.Base.PrintInitializeEventHandler(this.gvClient_PrintInitialize);
            // 
            // ColID_CL
            // 
            this.ColID_CL.Caption = "N° TRANSPORTEUR";
            this.ColID_CL.FieldName = "ID_TR";
            this.ColID_CL.Name = "ColID_CL";
            this.ColID_CL.Visible = true;
            this.ColID_CL.VisibleIndex = 0;
            this.ColID_CL.Width = 183;
            // 
            // colNom
            // 
            this.colNom.Caption = "NOM TRANSPORTEUR";
            this.colNom.FieldName = "Nom_TR";
            this.colNom.Name = "colNom";
            this.colNom.Visible = true;
            this.colNom.VisibleIndex = 1;
            this.colNom.Width = 193;
            // 
            // colCNIE_CL
            // 
            this.colCNIE_CL.Caption = "CNIE";
            this.colCNIE_CL.FieldName = "CNIE_TR";
            this.colCNIE_CL.Name = "colCNIE_CL";
            this.colCNIE_CL.Visible = true;
            this.colCNIE_CL.VisibleIndex = 2;
            this.colCNIE_CL.Width = 160;
            // 
            // colADR
            // 
            this.colADR.Caption = "Adresse";
            this.colADR.FieldName = "Adr_TR";
            this.colADR.Name = "colADR";
            this.colADR.Visible = true;
            this.colADR.VisibleIndex = 4;
            this.colADR.Width = 160;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Tel";
            this.gridColumn5.FieldName = "Tel_TR";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            this.gridColumn5.Width = 160;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Note";
            this.gridColumn1.FieldName = "Note_TR";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 5;
            this.gridColumn1.Width = 113;
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
            windowsUIButtonImageOptions8.ImageUri.Uri = "Show;GrayScaled";
            windowsUIButtonImageOptions9.ImageUri.Uri = "AddItem;Size32x32;GrayScaled";
            windowsUIButtonImageOptions10.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonImageOptions10.Image")));
            windowsUIButtonImageOptions10.ImageUri.Uri = "Delete;Size32x32;GrayScaled";
            windowsUIButtonImageOptions11.ImageUri.Uri = "Edit;Size32x32;GrayScaled";
            windowsUIButtonImageOptions12.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonImageOptions12.Image")));
            windowsUIButtonImageOptions13.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonImageOptions13.Image")));
            windowsUIButtonImageOptions14.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonImageOptions14.Image")));
            this.windowsUIButtonPanel1.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("VUE", true, windowsUIButtonImageOptions8),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("NOUVEAU", true, windowsUIButtonImageOptions9),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("SUPRIMER", true, windowsUIButtonImageOptions10),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("MODIFIER", true, windowsUIButtonImageOptions11),
            new DevExpress.XtraBars.Docking2010.WindowsUISeparator(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("EXPORTER", true, windowsUIButtonImageOptions12),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("IMPRIMER", true, windowsUIButtonImageOptions13),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("FILTRE", true, windowsUIButtonImageOptions14)});
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
            // Transporteur_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gdClient);
            this.Controls.Add(this.panelControl1);
            this.Name = "Transporteur_view";
            this.Size = new System.Drawing.Size(1138, 630);
            this.Load += new System.EventHandler(this.Client_view_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvClient)).EndInit();
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
        private DevExpress.XtraEditors.PanelControl panelControl1;
        public DevExpress.XtraGrid.GridControl gdClient;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanel1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}