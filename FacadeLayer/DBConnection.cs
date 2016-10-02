using System.Data.SqlClient;

namespace FacadeLayer
{
    public class DBConnection
    {

        public static SqlConnection con = new SqlConnection("Data Source=Sabitip.makrosoftbilisim.com;Initial Catalog=Db_SehasoftV1;User ID=sa;Password=3201479322");
       
    }
}
