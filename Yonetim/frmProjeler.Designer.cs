namespace Yonetim
{
    partial class frmProjeler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProjeler));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            this.btnlistele = new DevExpress.XtraEditors.SimpleButton();
            this.btnProjesil = new DevExpress.XtraEditors.SimpleButton();
            this.btnProjeekle = new DevExpress.XtraEditors.SimpleButton();
            this.grdCntrlProjeler = new DevExpress.XtraGrid.GridControl();
            this.grdwvProjeler = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdCntrlProjeler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdwvProjeler)).BeginInit();
            this.SuspendLayout();
            // 
            // btnlistele
            // 
            this.btnlistele.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnlistele.Image = ((System.Drawing.Image)(resources.GetObject("btnlistele.Image")));
            this.btnlistele.Location = new System.Drawing.Point(462, 371);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(109, 46);
            this.btnlistele.TabIndex = 23;
            this.btnlistele.Text = "Listele";
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // btnProjesil
            // 
            this.btnProjesil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProjesil.Image = ((System.Drawing.Image)(resources.GetObject("btnProjesil.Image")));
            this.btnProjesil.Location = new System.Drawing.Point(577, 371);
            this.btnProjesil.Name = "btnProjesil";
            this.btnProjesil.Size = new System.Drawing.Size(109, 46);
            this.btnProjesil.TabIndex = 22;
            this.btnProjesil.Text = "Proje Sil";
            this.btnProjesil.Click += new System.EventHandler(this.btnProjesil_Click);
            // 
            // btnProjeekle
            // 
            this.btnProjeekle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProjeekle.Image = ((System.Drawing.Image)(resources.GetObject("btnProjeekle.Image")));
            this.btnProjeekle.Location = new System.Drawing.Point(692, 371);
            this.btnProjeekle.Name = "btnProjeekle";
            this.btnProjeekle.Size = new System.Drawing.Size(109, 46);
            this.btnProjeekle.TabIndex = 21;
            this.btnProjeekle.Text = "Proje Ekle";
            this.btnProjeekle.Click += new System.EventHandler(this.btnProjeekle_Click);
            // 
            // grdCntrlProjeler
            // 
            this.grdCntrlProjeler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdCntrlProjeler.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdCntrlProjeler.EmbeddedNavigator.AccessibleName = "";
            gridLevelNode2.RelationName = "Level1";
            this.grdCntrlProjeler.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            this.grdCntrlProjeler.Location = new System.Drawing.Point(2, 1);
            this.grdCntrlProjeler.MainView = this.grdwvProjeler;
            this.grdCntrlProjeler.Name = "grdCntrlProjeler";
            this.grdCntrlProjeler.Size = new System.Drawing.Size(799, 368);
            this.grdCntrlProjeler.TabIndex = 20;
            this.grdCntrlProjeler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdwvProjeler});
            // 
            // grdwvProjeler
            // 
            this.grdwvProjeler.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.grdwvProjeler.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.grdwvProjeler.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.grdwvProjeler.GridControl = this.grdCntrlProjeler;
            this.grdwvProjeler.GroupPanelText = "Proje Tanımları";
            this.grdwvProjeler.Name = "grdwvProjeler";
            this.grdwvProjeler.OptionsBehavior.Editable = false;
            this.grdwvProjeler.OptionsBehavior.ReadOnly = true;
            this.grdwvProjeler.OptionsCustomization.AllowColumnMoving = false;
            this.grdwvProjeler.OptionsCustomization.AllowColumnResizing = false;
            this.grdwvProjeler.OptionsCustomization.AllowFilter = false;
            this.grdwvProjeler.OptionsMenu.EnableColumnMenu = false;
            this.grdwvProjeler.OptionsMenu.EnableFooterMenu = false;
            this.grdwvProjeler.OptionsMenu.EnableGroupPanelMenu = false;
            this.grdwvProjeler.OptionsMenu.ShowAddNewSummaryItem = DevExpress.Utils.DefaultBoolean.False;
            this.grdwvProjeler.OptionsMenu.ShowAutoFilterRowItem = false;
            this.grdwvProjeler.OptionsMenu.ShowDateTimeGroupIntervalItems = false;
            this.grdwvProjeler.OptionsMenu.ShowGroupSortSummaryItems = false;
            this.grdwvProjeler.OptionsView.ShowDetailButtons = false;
            this.grdwvProjeler.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.grdwvProjeler.OptionsView.ShowIndicator = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Proje Kodu";
            this.gridColumn1.FieldName = "pkodu";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Proje Adı";
            this.gridColumn2.FieldName = "padi";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Versiyon Adı";
            this.gridColumn3.FieldName = "vadi";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Proje Sorumlusu";
            this.gridColumn4.FieldName = "psorumlusu";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Kayıt Tarihi";
            this.gridColumn5.FieldName = "ktarihi";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "FTP Klasörü";
            this.gridColumn6.FieldName = "ftpkadi";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // frmProjeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 419);
            this.Controls.Add(this.btnlistele);
            this.Controls.Add(this.btnProjesil);
            this.Controls.Add(this.btnProjeekle);
            this.Controls.Add(this.grdCntrlProjeler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProjeler";
            this.Text = "frmProjeler";
            this.Load += new System.EventHandler(this.frmProjeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCntrlProjeler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdwvProjeler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnlistele;
        private DevExpress.XtraEditors.SimpleButton btnProjesil;
        private DevExpress.XtraEditors.SimpleButton btnProjeekle;
        private DevExpress.XtraGrid.GridControl grdCntrlProjeler;
        private DevExpress.XtraGrid.Views.Grid.GridView grdwvProjeler;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;


    }
}