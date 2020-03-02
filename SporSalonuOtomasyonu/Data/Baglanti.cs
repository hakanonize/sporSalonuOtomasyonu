using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Baglanti
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-44USMSSN\\SQLEXPRESS;Initial Catalog=kullaniciVerileri;Integrated Security=True");
        public SqlConnection baglantiAc()
        {
           
            conn.Open();
            return conn;
        }
        public SqlConnection baglantiKapat()
        {

            conn.Close();
            return conn;
        }
       
    }
}
