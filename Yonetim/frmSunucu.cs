using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Data.SqlClient;

namespace Yonetim
{
    public partial class frmSunucu : Form
    {
        public frmSunucu()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            lblUyari.Text = "Kontrol Ediliyor..";
            string connstrg = "Data Source=" + txtServer.Text + ";Initial Catalog=" + txtDB.Text + ";Uid=" + txtUserName.Text + ";Password=" + txtPassword.Text + ";";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connstrg;
            try
            {
                con.Open();
                Properties.Settings.Default.ConnectionString = connstrg;
                Properties.Settings.Default.Save();
                con.Close();
                MessageBox.Show("Bağlantı bilgileri başarıyla kaydedildi");
            }
            catch (Exception)
            {
                MessageBox.Show("Bağlantı bilgileriniz hatalı.");
            }

            this.Enabled = true;

        }


        private void frmSunucu_Load(object sender, EventArgs e)
        {
            if (Helper.sunucuKontrol())
            {
                if (Properties.Settings.Default.ConnectionString.Length > 0)
                {
                    string[] arr = Properties.Settings.Default.ConnectionString.Split(';');
                    if (arr.Length >= 4)
                    {
                        txtServer.Text = arr[0].Split('=')[1];
                        txtDB.Text = arr[1].Split('=')[1];
                        txtUserName.Text = arr[2].Split('=')[1];
                        txtPassword.Text = arr[3].Split('=')[1];
                    }
                }
            }
            else
            {
                MessageBox.Show("Sunucu Ayarları Yapılandırılmamış.Lütfen Ayarlarınızı Yapılandırın");
            }
        }
    }
}
