using AdooDal;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace hafta_15_ders_2
{
    public partial class AnaSayfa : System.Web.UI.Page
    {
        SqlDataReader dr;

        //int index1;
        //public AnaSayfa(int index)
        //{

        //    index1 = index;



        //}




        protected void Page_Load(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32(Request.QueryString["id"]);
            SqlParameter[] sp2 = new SqlParameter[1];
            sp2[0] = new SqlParameter("@ID", i);
            dr = HelperSQL.SqlOkuyucuDondur("select Ad,Soyad,TcKimlik,Adres from tbl_Kisiler where KisiID=@ID", false, sp2);

            ListView1.DataSource = dr;
            ListView1.DataBind();



        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}