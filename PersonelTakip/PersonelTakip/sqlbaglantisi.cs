using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PersonelTakip
{
    public class sqlbaglantisi
    {

        public SqlConnection baglanti()
        {
            //"Data Source=BFI03;Initial Catalog=PERSONEL;Integrated Security=True"
            
            SqlConnection baglan = new SqlConnection(@"Data Source=NETSIS; Initial Catalog=PERSONEL;Persist Security Info=False; User ID=sa; Password=1244244@");
            baglan.Open();
            return baglan;
        }
    }
}
