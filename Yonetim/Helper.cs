using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;

namespace Yonetim
{
    class Helper
    {
        public static bool sunucuKontrol()
        {
            return Properties.Settings.Default.ConnectionString.Trim().Length > 0;
        }
        public static void formSave(myClass obj, Control ctrl)
        {

            PropertyInfo[] pi = obj.GetType().GetProperties();
            foreach (PropertyInfo item in pi)
            {
                if (ctrl.Controls.ContainsKey("txt" + item.Name))
                {
                    string val = (ctrl.Controls["txt" + item.Name] as TextBox).Text;
                    item.SetValue(obj, val);
                }
            }
        }
        public static void bindForm(myClass obj, Control ctrl)
        {
            PropertyInfo[] pi = obj.GetType().GetProperties();
            foreach (PropertyInfo item in obj.GetType().GetProperties())
            {
                if (ctrl.Controls.ContainsKey("txt" + item.Name))
                {
                    string t = item.GetValue(obj) == null ? "" : item.GetValue(obj).ToString();
                    (ctrl.Controls["txt" + item.Name] as TextBox).Text = t;

                }
            }
        }
        public static void loadForm(Form childForm, Control parentPanel)
        {
            parentPanel.Controls.Clear();
            childForm.Height = parentPanel.Size.Height - 5;
            childForm.Width = parentPanel.Size.Width;
            childForm.TopLevel = false;
            parentPanel.Controls.Add(childForm);
            childForm.Show();
            childForm.Dock = DockStyle.Fill;
            childForm.BringToFront();
        }
    }
}
