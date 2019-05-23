using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;
namespace Chat_servis
{
    public class baglanti
    {
        public SqlConnection Baglanti()
        {
            SqlConnection con = new SqlConnection("Server=AZRAIL-PC; Integrated Security=true; Database=Online_Chat_Programı");
            if (con.State == ConnectionState.Closed )
            {
                con.Open();
            }
            return con;

        }
    }
}