namespace Yonetim
{
    partial class frmKullanicilar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKullanicilar));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            this.btnlistele = new DevExpress.XtraEditors.SimpleButton();
            this.btnKsil = new DevExpress.XtraEditors.SimpleButton();
            this.btnkbilgileri = new DevExpress.XtraEditors.SimpleButton();
            this.btnKullaniciEkle = new DevExpress.XtraEditors.SimpleButton();
            this.grdCntrlkullanicilar = new DevExpress.XtraGrid.GridControl();
            this.grdwvkullanicilar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdCntrlkullanicilar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdwvkullanicilar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnlistele
            // 
            this.btnlistele.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnlistele.Image = ((System.Drawing.Image)(resources.GetObject("btnlistele.Image")));
            this.btnlistele.Location = new System.Drawing.Point(459, 371);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(109, 46);
            this.btnlistele.TabIndex = 25;
            this.btnlistele.Text = "Listele";
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // btnKsil
            // 
            this.btnKsil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKsil.Image = ((System.Drawing.Image)(resources.GetObject("btnKsil.Image")));
            this.btnKsil.Location = new System.Drawing.Point(574, 371);
            this.btnKsil.Name = "btnKsil";
            this.btnKsil.Size = new System.Drawing.Size(109, 46);
            this.btnKsil.TabIndex = 24;
            this.btnKsil.Text = "Kullanıcı Sil";
            this.btnKsil.Click += new System.EventHandler(this.btnKsil_Click);
            // 
            // btnkbilgileri
            // 
            this.btnkbilgileri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnkbilgileri.Image = ((System.Drawing.Image)(resources.GetObject("btnkbilgileri.Image")));
            this.btnkbilgileri.Location = new System.Drawing.Point(2, 371);
            this.btnkbilgileri.Name = "btnkbilgileri";
            this.btnkbilgileri.Size = new System.Drawing.Size(122, 46);
            this.btnkbilgileri.TabIndex = 22;
            this.btnkbilgileri.Text = "Kullanici Bilgileri";
            this.btnkbilgileri.Click += new System.EventHandler(this.btnkbilgileri_Click);
            // 
            // btnKullaniciEkle
            // 
            this.btnKullaniciEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKullaniciEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnKullaniciEkle.Image")));
            this.btnKullaniciEkle.Location = new System.Drawing.Point(689, 371);
            this.btnKullaniciEkle.Name = "btnKullaniciEkle";
            this.btnKullaniciEkle.Size = new System.Drawing.Size(109, 46);
            this.btnKullaniciEkle.TabIndex = 23;
            this.btnKullaniciEkle.Text = "Kullanıcı Ekle";
            // 
            // grdCntrlkullanicilar
            // 
            this.grdCntrlkullanicilar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdCntrlkullanicilar.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdCntrlkullanicilar.EmbeddedNavigator.AccessibleName = "";
            gridLevelNode2.RelationName = "Level1";
            this.grdCntrlkullanicilar.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            this.grdCntrlkullanicilar.Location = new System.Drawing.Point(2, 1);
            this.grdCntrlkullanicilar.MainView = this.grdwvkullanicilar;
            this.grdCntrlkullanicilar.Name = "grdCntrlkullanicilar";
            this.grdCntrlkullanicilar.Size = new System.Drawing.Size(799, 368);
            this.grdCntrlkullanicilar.TabIndex = 21;
            this.grdCntrlkullanicilar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdwvkullanicilar});
            // 
            // grdwvkullanicilar
            // 
            this.grdwvkullanicilar.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.grdwvkullanicilar.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.grdwvkullanicilar.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.grdwvkullanicilar.GridControl = this.grdCntrlkullanicilar;
            this.grdwvkullanicilar.GroupPanelText = "Kullanıcılar";
            this.grdwvkullanicilar.Name = "grdwvkullanicilar";
            this.grdwvkullanicilar.OptionsBehavior.Editable = false;
            this.grdwvkullanicilar.OptionsBehavior.ReadOnly = true;
            this.grdwvkullanicilar.OptionsCustomization.AllowColumnMoving = false;
            this.grdwvkullanicilar.OptionsCustomization.AllowColumnResizing = false;
            this.grdwvkullanicilar.OptionsCustomization.AllowFilter = false;
            this.grdwvkullanicilar.OptionsMenu.EnableColumnMenu = false;
            this.grdwvkullanicilar.OptionsMenu.EnableFooterMenu = false;
            this.grdwvkullanicilar.OptionsMenu.EnableGroupPanelMenu = false;
            this.grdwvkullanicilar.OptionsMenu.ShowAddNewSummaryItem = DevExpress.Utils.DefaultBoolean.False;
            this.grdwvkullanicilar.OptionsMenu.ShowAutoFilterRowItem = false;
            this.grdwvkullanicilar.OptionsMenu.ShowDateTimeGroupIntervalItems = false;
            this.grdwvkullanicilar.OptionsMenu.ShowGroupSortSummaryItems = false;
            this.grdwvkullanicilar.OptionsView.ShowDetailButtons = false;
            this.grdwvkullanicilar.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.grdwvkullanicilar.OptionsView.ShowIndicator = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "AdSoyad";
            this.gridColumn1.FieldName = "adsoyad";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Telefon";
            this.gridColumn2.FieldName = "telefon";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "TC No";
            this.gridColumn3.FieldName = "tcno";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Görevi";
            this.gridColumn4.FieldName = "gorevi";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Kullanıcı Adı";
            this.gridColumn5.FieldName = "kadi";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // frmKullanicilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 419);
            this.Controls.Add(this.btnlistele);
            this.Controls.Add(this.btnKsil);
            this.Controls.Add(this.btnkbilgileri);
            this.Controls.Add(this.btnKullaniciEkle);
            this.Controls.Add(this.grdCntrlkullanicilar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKullanicilar";
            this.Text = "frmKullanicilar";
            this.Load += new System.EventHandler(this.frmKullanicilar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCntrlkullanicilar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdwvkullanicilar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnlistele;
        private DevExpress.XtraEditors.SimpleButton btnKsil;
        private DevExpress.XtraEditors.SimpleButton btnkbilgileri;
        private DevExpress.XtraEditors.SimpleButton btnKullaniciEkle;
        private DevExpress.XtraGrid.GridControl grdCntrlkullanicilar;
        private DevExpress.XtraGrid.Views.Grid.GridView grdwvkullanicilar;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;

    }
}