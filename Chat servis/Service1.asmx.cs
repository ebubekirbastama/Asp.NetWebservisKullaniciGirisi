using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Chat_servis
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string KullanıcıGirisi(string d1, string s2)
        {
            var mesaj = "";
            baglanti bgl = new baglanti();
            SqlConnection con = bgl.Baglanti();
            SqlCommand kmt1 = new SqlCommand("sp_k_giris", con);
            kmt1.CommandType = CommandType.StoredProcedure;
            kmt1.Parameters.AddWithValue("@k_adi", d1);
            kmt1.Parameters.AddWithValue("@k_sifresi", s2);
            int sonuc1 = kmt1.ExecuteNonQuery();
            //MessageBox.Show(sonuc.ToString ());
            if (sonuc1 == 0)
            {
                mesaj = "Kullanıcı Girişi Başarılı";
            }
            else if (sonuc1 == 1)
            {
                mesaj = "Kullanıcı Girişi Başarısız";
            }
            return mesaj;
        }
    }
}