namespace Yonetim
{
    partial class frmAnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaForm));
            this.pnlana = new DevExpress.XtraEditors.PanelControl();
            this.btnProjeTanm = new DevExpress.XtraEditors.SimpleButton();
            this.btnProjeler = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.nvbarcntrAna = new DevExpress.XtraNavBar.NavBarControl();
            this.nvbargrpVersiyonlar = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroupControlContainer2 = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.btnProjeListesi = new DevExpress.XtraEditors.SimpleButton();
            this.btnProjeTanimla = new DevExpress.XtraEditors.SimpleButton();
            this.navBarGroupControlContainer1 = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.btnmusteriler = new DevExpress.XtraEditors.SimpleButton();
            this.btnmusteriekle = new DevExpress.XtraEditors.SimpleButton();
            this.navBarGroupControlContainer3 = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.btnsqlSorguları = new DevExpress.XtraEditors.SimpleButton();
            this.btnguncellemeler = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncellemeTanim = new DevExpress.XtraEditors.SimpleButton();
            this.navBarGroupControlContainer4 = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.btnLisanslar = new DevExpress.XtraEditors.SimpleButton();
            this.btnLisansEkle = new DevExpress.XtraEditors.SimpleButton();
            this.navBarGroupControlContainer5 = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.btnklistesi = new DevExpress.XtraEditors.SimpleButton();
            this.btnkullaniciekle = new DevExpress.XtraEditors.SimpleButton();
            this.nvbrGrupfirmalar = new DevExpress.XtraNavBar.NavBarGroup();
            this.nvbrgrpLisans = new DevExpress.XtraNavBar.NavBarGroup();
            this.nvbrgrupGuncelleme = new DevExpress.XtraNavBar.NavBarGroup();
            this.nvbrgrpKullanici = new DevExpress.XtraNavBar.NavBarGroup();
            ((System.ComponentModel.ISupportInitialize)(this.pnlana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nvbarcntrAna)).BeginInit();
            this.nvbarcntrAna.SuspendLayout();
            this.navBarGroupControlContainer2.SuspendLayout();
            this.navBarGroupControlContainer1.SuspendLayout();
            this.navBarGroupControlContainer3.SuspendLayout();
            this.navBarGroupControlContainer4.SuspendLayout();
            this.navBarGroupControlContainer5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlana
            // 
            this.pnlana.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlana.Location = new System.Drawing.Point(205, 3);
            this.pnlana.Name = "pnlana";
            this.pnlana.Size = new System.Drawing.Size(838, 462);
            this.pnlana.TabIndex = 3;
            // 
            // btnProjeTanm
            // 
            this.btnProjeTanm.Image = ((System.Drawing.Image)(resources.GetObject("btnProjeTanm.Image")));
            this.btnProjeTanm.Location = new System.Drawing.Point(3, 3);
            this.btnProjeTanm.Name = "btnProjeTanm";
            this.btnProjeTanm.Size = new System.Drawing.Size(182, 46);
            this.btnProjeTanm.TabIndex = 1;
            // 
            // btnProjeler
            // 
            this.btnProjeler.Image = ((System.Drawing.Image)(resources.GetObject("btnProjeler.Image")));
            this.btnProjeler.Location = new System.Drawing.Point(3, 55);
            this.btnProjeler.Name = "btnProjeler";
            this.btnProjeler.Size = new System.Drawing.Size(182, 46);
            this.btnProjeler.TabIndex = 1;
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelControl1.Controls.Add(this.nvbarcntrAna);
            this.panelControl1.Location = new System.Drawing.Point(-1, 3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(200, 463);
            this.panelControl1.TabIndex = 1;
            // 
            // nvbarcntrAna
            // 
            this.nvbarcntrAna.ActiveGroup = this.nvbrGrupfirmalar;
            this.nvbarcntrAna.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.nvbarcntrAna.Controls.Add(this.navBarGroupControlContainer1);
            this.nvbarcntrAna.Controls.Add(this.navBarGroupControlContainer2);
            this.nvbarcntrAna.Controls.Add(this.navBarGroupControlContainer3);
            this.nvbarcntrAna.Controls.Add(this.navBarGroupControlContainer4);
            this.nvbarcntrAna.Controls.Add(this.navBarGroupControlContainer5);
            this.nvbarcntrAna.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.nvbrGrupfirmalar,
            this.nvbargrpVersiyonlar,
            this.nvbrgrpLisans,
            this.nvbrgrupGuncelleme,
            this.nvbrgrpKullanici});
            this.nvbarcntrAna.Location = new System.Drawing.Point(5, 9);
            this.nvbarcntrAna.Name = "nvbarcntrAna";
            this.nvbarcntrAna.OptionsNavPane.ExpandedWidth = 190;
            this.nvbarcntrAna.OptionsNavPane.ShowExpandButton = false;
            this.nvbarcntrAna.OptionsNavPane.ShowOverflowButton = false;
            this.nvbarcntrAna.OptionsNavPane.ShowOverflowPanel = false;
            this.nvbarcntrAna.OptionsNavPane.ShowSplitter = false;
            this.nvbarcntrAna.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.nvbarcntrAna.Size = new System.Drawing.Size(190, 449);
            this.nvbarcntrAna.TabIndex = 1;
            this.nvbarcntrAna.Text = "navBarControl1";
            // 
            // nvbargrpVersiyonlar
            // 
            this.nvbargrpVersiyonlar.Caption = "Projeler";
            this.nvbargrpVersiyonlar.ControlContainer = this.navBarGroupControlContainer2;
            this.nvbargrpVersiyonlar.GroupClientHeight = 80;
            this.nvbargrpVersiyonlar.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer;
            this.nvbargrpVersiyonlar.LargeImage = ((System.Drawing.Image)(resources.GetObject("nvbargrpVersiyonlar.LargeImage")));
            this.nvbargrpVersiyonlar.Name = "nvbargrpVersiyonlar";
            this.nvbargrpVersiyonlar.ItemChanged += new System.EventHandler(this.nvbargrpVersiyonlar_ItemChanged);
            // 
            // navBarGroupControlContainer2
            // 
            this.navBarGroupControlContainer2.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.navBarGroupControlContainer2.Appearance.Options.UseBackColor = true;
            this.navBarGroupControlContainer2.Controls.Add(this.btnProjeListesi);
            this.navBarGroupControlContainer2.Controls.Add(this.btnProjeTanimla);
            this.navBarGroupControlContainer2.Name = "navBarGroupControlContainer2";
            this.navBarGroupControlContainer2.Size = new System.Drawing.Size(190, 186);
            this.navBarGroupControlContainer2.TabIndex = 1;
            // 
            // btnProjeListesi
            // 
            this.btnProjeListesi.Image = ((System.Drawing.Image)(resources.GetObject("btnProjeListesi.Image")));
            this.btnProjeListesi.Location = new System.Drawing.Point(3, 55);
            this.btnProjeListesi.Name = "btnProjeListesi";
            this.btnProjeListesi.Size = new System.Drawing.Size(182, 46);
            this.btnProjeListesi.TabIndex = 1;
            this.btnProjeListesi.Text = "Proje Listesi";
            this.btnProjeListesi.Click += new System.EventHandler(this.btnProjeListesi_Click);
            // 
            // btnProjeTanimla
            // 
            this.btnProjeTanimla.Image = ((System.Drawing.Image)(resources.GetObject("btnProjeTanimla.Image")));
            this.btnProjeTanimla.Location = new System.Drawing.Point(3, 3);
            this.btnProjeTanimla.Name = "btnProjeTanimla";
            this.btnProjeTanimla.Size = new System.Drawing.Size(182, 46);
            this.btnProjeTanimla.TabIndex = 1;
            this.btnProjeTanimla.Text = "Proje Tanımla";
            this.btnProjeTanimla.Click += new System.EventHandler(this.btnProjeTanimla_Click);
            // 
            // navBarGroupControlContainer1
            // 
            this.navBarGroupControlContainer1.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.navBarGroupControlContainer1.Appearance.Options.UseBackColor = true;
            this.navBarGroupControlContainer1.Controls.Add(this.btnmusteriler);
            this.navBarGroupControlContainer1.Controls.Add(this.btnmusteriekle);
            this.navBarGroupControlContainer1.Name = "navBarGroupControlContainer1";
            this.navBarGroupControlContainer1.Size = new System.Drawing.Size(190, 186);
            this.navBarGroupControlContainer1.TabIndex = 0;
            // 
            // btnmusteriler
            // 
            this.btnmusteriler.Image = ((System.Drawing.Image)(resources.GetObject("btnmusteriler.Image")));
            this.btnmusteriler.Location = new System.Drawing.Point(5, 55);
            this.btnmusteriler.Name = "btnmusteriler";
            this.btnmusteriler.Size = new System.Drawing.Size(182, 46);
            this.btnmusteriler.TabIndex = 0;
            this.btnmusteriler.Text = "Müşteri Listesi";
            this.btnmusteriler.Click += new System.EventHandler(this.btnmusteriler_Click);
            // 
            // btnmusteriekle
            // 
            this.btnmusteriekle.Image = ((System.Drawing.Image)(resources.GetObject("btnmusteriekle.Image")));
            this.btnmusteriekle.Location = new System.Drawing.Point(5, 3);
            this.btnmusteriekle.Name = "btnmusteriekle";
            this.btnmusteriekle.Size = new System.Drawing.Size(182, 46);
            this.btnmusteriekle.TabIndex = 0;
            this.btnmusteriekle.Text = "Müşteri Ekle";
            this.btnmusteriekle.Click += new System.EventHandler(this.btnmusteriekle_Click);
            // 
            // navBarGroupControlContainer3
            // 
            this.navBarGroupControlContainer3.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.navBarGroupControlContainer3.Appearance.Options.UseBackColor = true;
            this.navBarGroupControlContainer3.Controls.Add(this.btnsqlSorguları);
            this.navBarGroupControlContainer3.Controls.Add(this.btnguncellemeler);
            this.navBarGroupControlContainer3.Controls.Add(this.btnGuncellemeTanim);
            this.navBarGroupControlContainer3.Name = "navBarGroupControlContainer3";
            this.navBarGroupControlContainer3.Size = new System.Drawing.Size(190, 186);
            this.navBarGroupControlContainer3.TabIndex = 2;
            // 
            // btnsqlSorguları
            // 
            this.btnsqlSorguları.Image = ((System.Drawing.Image)(resources.GetObject("btnsqlSorguları.Image")));
            this.btnsqlSorguları.Location = new System.Drawing.Point(2, 55);
            this.btnsqlSorguları.Name = "btnsqlSorguları";
            this.btnsqlSorguları.Size = new System.Drawing.Size(182, 46);
            this.btnsqlSorguları.TabIndex = 3;
            this.btnsqlSorguları.Text = "Sql Sorguları";
            // 
            // btnguncellemeler
            // 
            this.btnguncellemeler.Image = ((System.Drawing.Image)(resources.GetObject("btnguncellemeler.Image")));
            this.btnguncellemeler.Location = new System.Drawing.Point(2, 106);
            this.btnguncellemeler.Name = "btnguncellemeler";
            this.btnguncellemeler.Size = new System.Drawing.Size(182, 46);
            this.btnguncellemeler.TabIndex = 2;
            this.btnguncellemeler.Text = "Versiyon Listesi";
            // 
            // btnGuncellemeTanim
            // 
            this.btnGuncellemeTanim.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncellemeTanim.Image")));
            this.btnGuncellemeTanim.Location = new System.Drawing.Point(2, 3);
            this.btnGuncellemeTanim.Name = "btnGuncellemeTanim";
            this.btnGuncellemeTanim.Size = new System.Drawing.Size(182, 46);
            this.btnGuncellemeTanim.TabIndex = 2;
            this.btnGuncellemeTanim.Text = "Versiyon Tanımla";
            // 
            // navBarGroupControlContainer4
            // 
            this.navBarGroupControlContainer4.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.navBarGroupControlContainer4.Appearance.Options.UseBackColor = true;
            this.navBarGroupControlContainer4.Controls.Add(this.btnLisanslar);
            this.navBarGroupControlContainer4.Controls.Add(this.btnLisansEkle);
            this.navBarGroupControlContainer4.Name = "navBarGroupControlContainer4";
            this.navBarGroupControlContainer4.Size = new System.Drawing.Size(190, 186);
            this.navBarGroupControlContainer4.TabIndex = 3;
            // 
            // btnLisanslar
            // 
            this.btnLisanslar.Image = ((System.Drawing.Image)(resources.GetObject("btnLisanslar.Image")));
            this.btnLisanslar.Location = new System.Drawing.Point(5, 55);
            this.btnLisanslar.Name = "btnLisanslar";
            this.btnLisanslar.Size = new System.Drawing.Size(182, 46);
            this.btnLisanslar.TabIndex = 2;
            this.btnLisanslar.Text = "Lisans Listeleri";
            // 
            // btnLisansEkle
            // 
            this.btnLisansEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnLisansEkle.Image")));
            this.btnLisansEkle.Location = new System.Drawing.Point(5, 3);
            this.btnLisansEkle.Name = "btnLisansEkle";
            this.btnLisansEkle.Size = new System.Drawing.Size(182, 46);
            this.btnLisansEkle.TabIndex = 2;
            this.btnLisansEkle.Text = "Lisans Tanımla";
            // 
            // navBarGroupControlContainer5
            // 
            this.navBarGroupControlContainer5.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.navBarGroupControlContainer5.Appearance.Options.UseBackColor = true;
            this.navBarGroupControlContainer5.Controls.Add(this.btnklistesi);
            this.navBarGroupControlContainer5.Controls.Add(this.btnkullaniciekle);
            this.navBarGroupControlContainer5.Name = "navBarGroupControlContainer5";
            this.navBarGroupControlContainer5.Size = new System.Drawing.Size(190, 186);
            this.navBarGroupControlContainer5.TabIndex = 4;
            // 
            // btnklistesi
            // 
            this.btnklistesi.Image = ((System.Drawing.Image)(resources.GetObject("btnklistesi.Image")));
            this.btnklistesi.Location = new System.Drawing.Point(1, 55);
            this.btnklistesi.Name = "btnklistesi";
            this.btnklistesi.Size = new System.Drawing.Size(182, 46);
            this.btnklistesi.TabIndex = 3;
            this.btnklistesi.Text = "Kullanıcı Listesi";
            // 
            // btnkullaniciekle
            // 
            this.btnkullaniciekle.Image = ((System.Drawing.Image)(resources.GetObject("btnkullaniciekle.Image")));
            this.btnkullaniciekle.Location = new System.Drawing.Point(1, 3);
            this.btnkullaniciekle.Name = "btnkullaniciekle";
            this.btnkullaniciekle.Size = new System.Drawing.Size(182, 46);
            this.btnkullaniciekle.TabIndex = 3;
            this.btnkullaniciekle.Text = "Kullanıcı Ekle";
            // 
            // nvbrGrupfirmalar
            // 
            this.nvbrGrupfirmalar.Caption = "Müşteriler";
            this.nvbrGrupfirmalar.ControlContainer = this.navBarGroupControlContainer1;
            this.nvbrGrupfirmalar.Expanded = true;
            this.nvbrGrupfirmalar.GroupClientHeight = 155;
            this.nvbrGrupfirmalar.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer;
            this.nvbrGrupfirmalar.LargeImage = ((System.Drawing.Image)(resources.GetObject("nvbrGrupfirmalar.LargeImage")));
            this.nvbrGrupfirmalar.Name = "nvbrGrupfirmalar";
            this.nvbrGrupfirmalar.ItemChanged += new System.EventHandler(this.nvbrGrupfirmalar_ItemChanged);
            // 
            // nvbrgrpLisans
            // 
            this.nvbrgrpLisans.Caption = "Lisanslar";
            this.nvbrgrpLisans.ControlContainer = this.navBarGroupControlContainer4;
            this.nvbrgrpLisans.GroupClientHeight = 80;
            this.nvbrgrpLisans.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer;
            this.nvbrgrpLisans.LargeImage = ((System.Drawing.Image)(resources.GetObject("nvbrgrpLisans.LargeImage")));
            this.nvbrgrpLisans.Name = "nvbrgrpLisans";
            // 
            // nvbrgrupGuncelleme
            // 
            this.nvbrgrupGuncelleme.Caption = "Güncellemeler";
            this.nvbrgrupGuncelleme.ControlContainer = this.navBarGroupControlContainer3;
            this.nvbrgrupGuncelleme.GroupClientHeight = 186;
            this.nvbrgrupGuncelleme.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer;
            this.nvbrgrupGuncelleme.LargeImage = ((System.Drawing.Image)(resources.GetObject("nvbrgrupGuncelleme.LargeImage")));
            this.nvbrgrupGuncelleme.Name = "nvbrgrupGuncelleme";
            // 
            // nvbrgrpKullanici
            // 
            this.nvbrgrpKullanici.Caption = "Kullanıcılar";
            this.nvbrgrpKullanici.ControlContainer = this.navBarGroupControlContainer5;
            this.nvbrgrpKullanici.GroupClientHeight = 80;
            this.nvbrgrpKullanici.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer;
            this.nvbrgrpKullanici.LargeImage = ((System.Drawing.Image)(resources.GetObject("nvbrgrpKullanici.LargeImage")));
            this.nvbrgrpKullanici.Name = "nvbrgrpKullanici";
            // 
            // frmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 468);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.pnlana);
            this.Name = "frmAnaForm";
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.frmAnaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nvbarcntrAna)).EndInit();
            this.nvbarcntrAna.ResumeLayout(false);
            this.navBarGroupControlContainer2.ResumeLayout(false);
            this.navBarGroupControlContainer1.ResumeLayout(false);
            this.navBarGroupControlContainer3.ResumeLayout(false);
            this.navBarGroupControlContainer4.ResumeLayout(false);
            this.navBarGroupControlContainer5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlana;
        private DevExpress.XtraEditors.SimpleButton btnProjeTanm;
        private DevExpress.XtraEditors.SimpleButton btnProjeler;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraNavBar.NavBarControl nvbarcntrAna;
        private DevExpress.XtraNavBar.NavBarGroup nvbrGrupfirmalar;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer1;
        private DevExpress.XtraEditors.SimpleButton btnmusteriler;
        private DevExpress.XtraEditors.SimpleButton btnmusteriekle;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer2;
        private DevExpress.XtraEditors.SimpleButton btnProjeListesi;
        private DevExpress.XtraEditors.SimpleButton btnProjeTanimla;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer3;
        private DevExpress.XtraEditors.SimpleButton btnsqlSorguları;
        private DevExpress.XtraEditors.SimpleButton btnguncellemeler;
        private DevExpress.XtraEditors.SimpleButton btnGuncellemeTanim;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer4;
        private DevExpress.XtraEditors.SimpleButton btnLisanslar;
        private DevExpress.XtraEditors.SimpleButton btnLisansEkle;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer5;
        private DevExpress.XtraEditors.SimpleButton btnklistesi;
        private DevExpress.XtraEditors.SimpleButton btnkullaniciekle;
        private DevExpress.XtraNavBar.NavBarGroup nvbargrpVersiyonlar;
        private DevExpress.XtraNavBar.NavBarGroup nvbrgrpLisans;
        private DevExpress.XtraNavBar.NavBarGroup nvbrgrupGuncelleme;
        private DevExpress.XtraNavBar.NavBarGroup nvbrgrpKullanici;

    }
}