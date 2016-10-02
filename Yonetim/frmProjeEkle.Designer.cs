namespace Yonetim
{
    partial class frmProjeEkle
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
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dtkayittarihi = new System.Windows.Forms.DateTimePicker();
            this.btnkaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtpsorumlusu = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtversiyonadi = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtftpkadi = new System.Windows.Forms.TextBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtpkodu = new System.Windows.Forms.TextBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtpadi = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Location = new System.Drawing.Point(12, 12);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(132, 23);
            this.labelControl6.TabIndex = 4;
            this.labelControl6.Text = "Proje Tanımla";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl1.Controls.Add(this.dtkayittarihi);
            this.groupControl1.Controls.Add(this.btnkaydet);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtpsorumlusu);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtversiyonadi);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtftpkadi);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.txtpkodu);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtpadi);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(3, 57);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(351, 264);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Versiyon Tanım Bilgileri";
            // 
            // dtkayittarihi
            // 
            this.dtkayittarihi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtkayittarihi.Location = new System.Drawing.Point(104, 145);
            this.dtkayittarihi.Name = "dtkayittarihi";
            this.dtkayittarihi.Size = new System.Drawing.Size(227, 21);
            this.dtkayittarihi.TabIndex = 5;
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(245, 199);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(86, 38);
            this.btnkaydet.TabIndex = 7;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Location = new System.Drawing.Point(10, 148);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(59, 14);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Kayıt Tarihi";
            // 
            // txtpsorumlusu
            // 
            this.txtpsorumlusu.Location = new System.Drawing.Point(104, 118);
            this.txtpsorumlusu.MaxLength = 100;
            this.txtpsorumlusu.Name = "txtpsorumlusu";
            this.txtpsorumlusu.Size = new System.Drawing.Size(227, 21);
            this.txtpsorumlusu.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Location = new System.Drawing.Point(10, 120);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(88, 14);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Proje Sorumlusu";
            // 
            // txtversiyonadi
            // 
            this.txtversiyonadi.Location = new System.Drawing.Point(104, 91);
            this.txtversiyonadi.MaxLength = 100;
            this.txtversiyonadi.Name = "txtversiyonadi";
            this.txtversiyonadi.Size = new System.Drawing.Size(227, 21);
            this.txtversiyonadi.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Location = new System.Drawing.Point(10, 93);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(67, 14);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Versiyon Adı";
            // 
            // txtftpkadi
            // 
            this.txtftpkadi.Location = new System.Drawing.Point(104, 172);
            this.txtftpkadi.MaxLength = 100;
            this.txtftpkadi.Name = "txtftpkadi";
            this.txtftpkadi.Size = new System.Drawing.Size(227, 21);
            this.txtftpkadi.TabIndex = 6;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Location = new System.Drawing.Point(10, 174);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(77, 14);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "FTP Klasör Adı";
            // 
            // txtpkodu
            // 
            this.txtpkodu.Location = new System.Drawing.Point(104, 37);
            this.txtpkodu.MaxLength = 50;
            this.txtpkodu.Name = "txtpkodu";
            this.txtpkodu.Size = new System.Drawing.Size(227, 21);
            this.txtpkodu.TabIndex = 1;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Location = new System.Drawing.Point(10, 39);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(60, 14);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Proje Kodu";
            // 
            // txtpadi
            // 
            this.txtpadi.Location = new System.Drawing.Point(104, 64);
            this.txtpadi.MaxLength = 150;
            this.txtpadi.Name = "txtpadi";
            this.txtpadi.Size = new System.Drawing.Size(227, 21);
            this.txtpadi.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Location = new System.Drawing.Point(10, 66);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(49, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Proje Adı";
            // 
            // frmProjeEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 332);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmProjeEkle";
            this.Text = "frmProjeEkle";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DateTimePicker dtkayittarihi;
        private DevExpress.XtraEditors.SimpleButton btnkaydet;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.TextBox txtpsorumlusu;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.TextBox txtversiyonadi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox txtftpkadi;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.TextBox txtpkodu;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.TextBox txtpadi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}