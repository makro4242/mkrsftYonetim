using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using FacadeLayer;

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
            if (txtServer.Text == ".")
            {
                connstrg = "Data Source=.;Initial Catalog=" + txtDB.Text + ";Integrated Security=true;";
            }
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
                        try
                        {
                            txtServer.Text = arr[0].Split('=')[1];
                            txtDB.Text = arr[1].Split('=')[1];
                            txtUserName.Text = arr[2].Split('=')[1];
                            txtPassword.Text = arr[3].Split('=')[1];
                        }
                        catch (Exception)
                        {
                            
                        }
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
