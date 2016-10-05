using EntityLayer;
using System;
using System.Windows.Forms;

namespace Yonetim
{
    public partial class frmLisansBilgileri : Form
    {
        Lisanslar lisans;
        public frmLisansBilgileri(Lisanslar lisans)
        {
            this.lisans = lisans;
            InitializeComponent();
        }
        public void lisansBilgileriGetir()
        {

        }
        private void frmLisansBilgileri_Load(object sender, EventArgs e)
        {
            if (lisans != null && lisans.lisansdurumu != null)
            {
                Helper.bindForm(lisans, pnlForm);
                txtLisansDurumu.Text = lisans.lisansdurumu ? "Kullanılıyor" : "Uygun";
            }
        }
    }
}
