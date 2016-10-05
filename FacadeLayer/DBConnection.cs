using System.Data.SqlClient;
using System;
using System.Windows.Forms;
namespace FacadeLayer
{
    public class DBConnection
    {

        public static SqlConnection con = new SqlConnection(Properties.Settings.Default.ConnectionString);
       
    }
}
