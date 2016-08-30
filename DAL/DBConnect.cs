using System.Data.SqlClient;

namespace DAL
{
    public class DBConnect
    {
        protected SqlConnection conn = new SqlConnection("Data Source=NGOCTUAN\\SQLEXPRESS;Initial Catalog=QLDV;Integrated Security=True");
    }
}
