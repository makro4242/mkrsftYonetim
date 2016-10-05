namespace Yonetim
{
    partial class frmLisanslar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLisanslar));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dateltarihi = new System.Windows.Forms.DateTimePicker();
            this.txtfirmaadi = new DevExpress.XtraEditors.SearchControl();
            this.txtino = new DevExpress.XtraEditors.SearchControl();
            this.txtadsoyad = new DevExpress.XtraEditors.SearchControl();
            this.txtlanahtari = new DevExpress.XtraEditors.SearchControl();
            this.txtprojeadi = new DevExpress.XtraEditors.SearchControl();
            this.btnLisansbilgi = new DevExpress.XtraEditors.SimpleButton();
            this.btnlistele = new DevExpress.XtraEditors.SimpleButton();
            this.btnLsil = new DevExpress.XtraEditors.SimpleButton();
            this.btnLisansEkle = new DevExpress.XtraEditors.SimpleButton();
            this.grdCntrlLisanslar = new DevExpress.XtraGrid.GridControl();
            this.grdwvLisanslar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtfirmaadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtino.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtadsoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtlanahtari.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtprojeadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCntrlLisanslar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdwvLisanslar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl1.Controls.Add(this.dateltarihi);
            this.groupControl1.Controls.Add(this.txtfirmaadi);
            this.groupControl1.Controls.Add(this.txtino);
            this.groupControl1.Controls.Add(this.txtadsoyad);
            this.groupControl1.Controls.Add(this.txtlanahtari);
            this.groupControl1.Controls.Add(this.txtprojeadi);
            this.groupControl1.Location = new System.Drawing.Point(1, 1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(241, 368);
            this.groupControl1.TabIndex = 30;
            this.groupControl1.Text = "Arama";
            // 
            // dateltarihi
            // 
            this.dateltarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateltarihi.Location = new System.Drawing.Point(5, 129);
            this.dateltarihi.Name = "dateltarihi";
            this.dateltarihi.Size = new System.Drawing.Size(231, 21);
            this.dateltarihi.TabIndex = 4;
            // 
            // txtfirmaadi
            // 
            this.txtfirmaadi.Location = new System.Drawing.Point(5, 26);
            this.txtfirmaadi.Name = "txtfirmaadi";
            this.txtfirmaadi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtfirmaadi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.txtfirmaadi.Properties.NullValuePrompt = "Firma Adı";
            this.txtfirmaadi.Size = new System.Drawing.Size(231, 20);
            this.txtfirmaadi.TabIndex = 0;
            // 
            // txtino
            // 
            this.txtino.Location = new System.Drawing.Point(5, 156);
            this.txtino.Name = "txtino";
            this.txtino.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtino.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.txtino.Properties.NullValuePrompt = "İşlemci No";
            this.txtino.Size = new System.Drawing.Size(231, 20);
            this.txtino.TabIndex = 5;
            // 
            // txtadsoyad
            // 
            this.txtadsoyad.Location = new System.Drawing.Point(5, 104);
            this.txtadsoyad.Name = "txtadsoyad";
            this.txtadsoyad.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtadsoyad.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.txtadsoyad.Properties.NullValuePrompt = "Ad Soyad";
            this.txtadsoyad.Size = new System.Drawing.Size(231, 20);
            this.txtadsoyad.TabIndex = 3;
            // 
            // txtlanahtari
            // 
            this.txtlanahtari.Location = new System.Drawing.Point(5, 78);
            this.txtlanahtari.Name = "txtlanahtari";
            this.txtlanahtari.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtlanahtari.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.txtlanahtari.Properties.NullValuePrompt = "Lisans Anahtarı";
            this.txtlanahtari.Size = new System.Drawing.Size(231, 20);
            this.txtlanahtari.TabIndex = 2;
            // 
            // txtprojeadi
            // 
            this.txtprojeadi.Location = new System.Drawing.Point(5, 52);
            this.txtprojeadi.Name = "txtprojeadi";
            this.txtprojeadi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtprojeadi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.txtprojeadi.Properties.NullValuePrompt = "Proje Adı";
            this.txtprojeadi.Size = new System.Drawing.Size(231, 20);
            this.txtprojeadi.TabIndex = 1;
            // 
            // btnLisansbilgi
            // 
            this.btnLisansbilgi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLisansbilgi.Image = ((System.Drawing.Image)(resources.GetObject("btnLisansbilgi.Image")));
            this.btnLisansbilgi.Location = new System.Drawing.Point(8, 371);
            this.btnLisansbilgi.Name = "btnLisansbilgi";
            this.btnLisansbilgi.Size = new System.Drawing.Size(109, 46);
            this.btnLisansbilgi.TabIndex = 29;
            this.btnLisansbilgi.Text = "Lisans Bilgileri";
            this.btnLisansbilgi.Click += new System.EventHandler(this.btnLisansbilgi_Click);
            // 
            // btnlistele
            // 
            this.btnlistele.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnlistele.Image = ((System.Drawing.Image)(resources.GetObject("btnlistele.Image")));
            this.btnlistele.Location = new System.Drawing.Point(462, 371);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(109, 46);
            this.btnlistele.TabIndex = 28;
            this.btnlistele.Text = "Listele";
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // btnLsil
            // 
            this.btnLsil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLsil.Image = ((System.Drawing.Image)(resources.GetObject("btnLsil.Image")));
            this.btnLsil.Location = new System.Drawing.Point(577, 371);
            this.btnLsil.Name = "btnLsil";
            this.btnLsil.Size = new System.Drawing.Size(109, 46);
            this.btnLsil.TabIndex = 27;
            this.btnLsil.Text = "Lisans Sil";
            this.btnLsil.Click += new System.EventHandler(this.btnLsil_Click);
            // 
            // btnLisansEkle
            // 
            this.btnLisansEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLisansEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnLisansEkle.Image")));
            this.btnLisansEkle.Location = new System.Drawing.Point(692, 371);
            this.btnLisansEkle.Name = "btnLisansEkle";
            this.btnLisansEkle.Size = new System.Drawing.Size(109, 46);
            this.btnLisansEkle.TabIndex = 26;
            this.btnLisansEkle.Text = "Lisans Ekle";
            this.btnLisansEkle.Click += new System.EventHandler(this.btnLisansEkle_Click);
            // 
            // grdCntrlLisanslar
            // 
            this.grdCntrlLisanslar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdCntrlLisanslar.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdCntrlLisanslar.EmbeddedNavigator.AccessibleName = "";
            gridLevelNode2.RelationName = "Level1";
            this.grdCntrlLisanslar.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            this.grdCntrlLisanslar.Location = new System.Drawing.Point(248, 1);
            this.grdCntrlLisanslar.MainView = this.grdwvLisanslar;
            this.grdCntrlLisanslar.Name = "grdCntrlLisanslar";
            this.grdCntrlLisanslar.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox1});
            this.grdCntrlLisanslar.Size = new System.Drawing.Size(553, 368);
            this.grdCntrlLisanslar.TabIndex = 25;
            this.grdCntrlLisanslar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdwvLisanslar});
            // 
            // grdwvLisanslar
            // 
            this.grdwvLisanslar.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.grdwvLisanslar.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn5});
            this.grdwvLisanslar.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.grdwvLisanslar.GridControl = this.grdCntrlLisanslar;
            this.grdwvLisanslar.GroupPanelText = "Lisans Anahtarları";
            this.grdwvLisanslar.Name = "grdwvLisanslar";
            this.grdwvLisanslar.OptionsBehavior.Editable = false;
            this.grdwvLisanslar.OptionsBehavior.ReadOnly = true;
            this.grdwvLisanslar.OptionsCustomization.AllowColumnMoving = false;
            this.grdwvLisanslar.OptionsCustomization.AllowColumnResizing = false;
            this.grdwvLisanslar.OptionsCustomization.AllowFilter = false;
            this.grdwvLisanslar.OptionsMenu.EnableColumnMenu = false;
            this.grdwvLisanslar.OptionsMenu.EnableFooterMenu = false;
            this.grdwvLisanslar.OptionsMenu.EnableGroupPanelMenu = false;
            this.grdwvLisanslar.OptionsMenu.ShowAddNewSummaryItem = DevExpress.Utils.DefaultBoolean.False;
            this.grdwvLisanslar.OptionsMenu.ShowAutoFilterRowItem = false;
            this.grdwvLisanslar.OptionsMenu.ShowDateTimeGroupIntervalItems = false;
            this.grdwvLisanslar.OptionsMenu.ShowGroupSortSummaryItems = false;
            this.grdwvLisanslar.OptionsView.ShowDetailButtons = false;
            this.grdwvLisanslar.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.grdwvLisanslar.OptionsView.ShowIndicator = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Firma Adi";
            this.gridColumn1.FieldName = "firmaadi";
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
            this.gridColumn3.Caption = "Lisans Anahtarı";
            this.gridColumn3.FieldName = "lisansanahtari";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Ad Soyad";
            this.gridColumn4.FieldName = "adsoyad";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Lisans Tarihi";
            this.gridColumn6.FieldName = "lisanstarihi";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "PC NO";
            this.gridColumn7.FieldName = "islemcino";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 5;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Durum";
            this.gridColumn5.ColumnEdit = this.repositoryItemImageComboBox1;
            this.gridColumn5.FieldName = "lisansdurumu";
            this.gridColumn5.MaxWidth = 100;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 6;
            this.gridColumn5.Width = 60;
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Uygun", false, 1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Kullanılıyor", true, 0)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            // 
            // frmLisanslar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 419);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.btnLisansbilgi);
            this.Controls.Add(this.btnlistele);
            this.Controls.Add(this.btnLsil);
            this.Controls.Add(this.btnLisansEkle);
            this.Controls.Add(this.grdCntrlLisanslar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLisanslar";
            this.Text = "frmLisanslar";
            this.Load += new System.EventHandler(this.frmLisanslar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtfirmaadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtino.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtadsoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtlanahtari.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtprojeadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCntrlLisanslar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdwvLisanslar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DateTimePicker dateltarihi;
        private DevExpress.XtraEditors.SearchControl txtfirmaadi;
        private DevExpress.XtraEditors.SearchControl txtino;
        private DevExpress.XtraEditors.SearchControl txtadsoyad;
        private DevExpress.XtraEditors.SearchControl txtlanahtari;
        private DevExpress.XtraEditors.SearchControl txtprojeadi;
        private DevExpress.XtraEditors.SimpleButton btnLisansbilgi;
        private DevExpress.XtraEditors.SimpleButton btnlistele;
        private DevExpress.XtraEditors.SimpleButton btnLsil;
        private DevExpress.XtraEditors.SimpleButton btnLisansEkle;
        private DevExpress.XtraGrid.GridControl grdCntrlLisanslar;
        private DevExpress.XtraGrid.Views.Grid.GridView grdwvLisanslar;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;

    }
}