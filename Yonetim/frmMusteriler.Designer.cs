namespace Yonetim
{
    partial class frmMusteriler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMusteriler));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.btnmusteribilgi = new DevExpress.XtraEditors.SimpleButton();
            this.btnlistele = new DevExpress.XtraEditors.SimpleButton();
            this.btnmsil = new DevExpress.XtraEditors.SimpleButton();
            this.btnmusteriekle = new DevExpress.XtraEditors.SimpleButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grdCntrlmusteriler = new DevExpress.XtraGrid.GridControl();
            this.grdwvmusteriler = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdCntrlmusteriler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdwvmusteriler)).BeginInit();
            this.SuspendLayout();
            // 
            // btnmusteribilgi
            // 
            this.btnmusteribilgi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnmusteribilgi.Image = ((System.Drawing.Image)(resources.GetObject("btnmusteribilgi.Image")));
            this.btnmusteribilgi.Location = new System.Drawing.Point(2, 371);
            this.btnmusteribilgi.Name = "btnmusteribilgi";
            this.btnmusteribilgi.Size = new System.Drawing.Size(124, 46);
            this.btnmusteribilgi.TabIndex = 22;
            this.btnmusteribilgi.Text = "Müşteri Bilgileri";
            this.btnmusteribilgi.Click += new System.EventHandler(this.btnmusteribilgi_Click);
            // 
            // btnlistele
            // 
            this.btnlistele.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnlistele.Image = ((System.Drawing.Image)(resources.GetObject("btnlistele.Image")));
            this.btnlistele.Location = new System.Drawing.Point(459, 371);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(109, 46);
            this.btnlistele.TabIndex = 21;
            this.btnlistele.Text = "Listele";
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // btnmsil
            // 
            this.btnmsil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmsil.Image = ((System.Drawing.Image)(resources.GetObject("btnmsil.Image")));
            this.btnmsil.Location = new System.Drawing.Point(574, 371);
            this.btnmsil.Name = "btnmsil";
            this.btnmsil.Size = new System.Drawing.Size(109, 46);
            this.btnmsil.TabIndex = 20;
            this.btnmsil.Text = "Müşteri Sil";
            this.btnmsil.Click += new System.EventHandler(this.btnmsil_Click);
            // 
            // btnmusteriekle
            // 
            this.btnmusteriekle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmusteriekle.Image = ((System.Drawing.Image)(resources.GetObject("btnmusteriekle.Image")));
            this.btnmusteriekle.Location = new System.Drawing.Point(681, 371);
            this.btnmusteriekle.Name = "btnmusteriekle";
            this.btnmusteriekle.Size = new System.Drawing.Size(109, 46);
            this.btnmusteriekle.TabIndex = 19;
            this.btnmusteriekle.Text = "Müşteri Ekle";
            this.btnmusteriekle.Click += new System.EventHandler(this.btnmusteriekle_Click);
            // 
            // grdCntrlmusteriler
            // 
            this.grdCntrlmusteriler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdCntrlmusteriler.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdCntrlmusteriler.EmbeddedNavigator.AccessibleName = "";
            gridLevelNode1.RelationName = "Level1";
            this.grdCntrlmusteriler.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.grdCntrlmusteriler.Location = new System.Drawing.Point(2, 1);
            this.grdCntrlmusteriler.MainView = this.grdwvmusteriler;
            this.grdCntrlmusteriler.Name = "grdCntrlmusteriler";
            this.grdCntrlmusteriler.Size = new System.Drawing.Size(799, 368);
            this.grdCntrlmusteriler.TabIndex = 23;
            this.grdCntrlmusteriler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdwvmusteriler});
            // 
            // grdwvmusteriler
            // 
            this.grdwvmusteriler.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.grdwvmusteriler.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn6,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.grdwvmusteriler.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.grdwvmusteriler.GridControl = this.grdCntrlmusteriler;
            this.grdwvmusteriler.GroupPanelText = "Müşteriler";
            this.grdwvmusteriler.Name = "grdwvmusteriler";
            this.grdwvmusteriler.OptionsBehavior.Editable = false;
            this.grdwvmusteriler.OptionsBehavior.ReadOnly = true;
            this.grdwvmusteriler.OptionsCustomization.AllowColumnMoving = false;
            this.grdwvmusteriler.OptionsCustomization.AllowColumnResizing = false;
            this.grdwvmusteriler.OptionsCustomization.AllowFilter = false;
            this.grdwvmusteriler.OptionsMenu.EnableColumnMenu = false;
            this.grdwvmusteriler.OptionsMenu.EnableFooterMenu = false;
            this.grdwvmusteriler.OptionsMenu.EnableGroupPanelMenu = false;
            this.grdwvmusteriler.OptionsMenu.ShowAddNewSummaryItem = DevExpress.Utils.DefaultBoolean.False;
            this.grdwvmusteriler.OptionsMenu.ShowAutoFilterRowItem = false;
            this.grdwvmusteriler.OptionsMenu.ShowDateTimeGroupIntervalItems = false;
            this.grdwvmusteriler.OptionsMenu.ShowGroupSortSummaryItems = false;
            this.grdwvmusteriler.OptionsView.ShowDetailButtons = false;
            this.grdwvmusteriler.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.grdwvmusteriler.OptionsView.ShowIndicator = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Firma Adı";
            this.gridColumn1.FieldName = "firmaadi";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Firma Tel";
            this.gridColumn6.FieldName = "firmatel";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Yetkili";
            this.gridColumn2.FieldName = "yetkili";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Yetkili Tel";
            this.gridColumn3.FieldName = "yetkilitel";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Adres";
            this.gridColumn4.FieldName = "adres";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Müşteri Notu";
            this.gridColumn5.FieldName = "mnotu";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            // 
            // frmMusteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 419);
            this.Controls.Add(this.grdCntrlmusteriler);
            this.Controls.Add(this.btnmusteribilgi);
            this.Controls.Add(this.btnlistele);
            this.Controls.Add(this.btnmsil);
            this.Controls.Add(this.btnmusteriekle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMusteriler";
            this.Text = "Müşteri Listesi";
            this.Load += new System.EventHandler(this.frmMusteriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCntrlmusteriler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdwvmusteriler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnmusteribilgi;
        private DevExpress.XtraEditors.SimpleButton btnlistele;
        private DevExpress.XtraEditors.SimpleButton btnmsil;
        private DevExpress.XtraEditors.SimpleButton btnmusteriekle;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraGrid.GridControl grdCntrlmusteriler;
        private DevExpress.XtraGrid.Views.Grid.GridView grdwvmusteriler;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;


    }
}