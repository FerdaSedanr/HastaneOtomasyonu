using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;



namespace DataAccessLayer
{
    public class Baglanti
    {
        public static SqlConnection bgl = new SqlConnection("Data Source=LAPTOP-U226G4BV;Initial Catalog=DBHastaneOtomasyon;Integrated Security=True");
    }
}
