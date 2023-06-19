using AdoEntity;
using AdooDal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace hafta_15_ders_2
{
    public partial class Default : System.Web.UI.Page
    {

        SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        

        protected void Button1_Click(object sender, EventArgs e)
        {

            SqlParameter[] sp = new SqlParameter[3];
            sp[0] = new SqlParameter("@KullaniciAdi", tbKullaniciAdi.Text);
            sp[1] = new SqlParameter("@Sifre", tbParola.Text);
            sp[2] = new SqlParameter("@Output", System.Data.SqlDbType.NVarChar);
            sp[2].Direction = ParameterDirection.Output; 

            sp[2].Size = 100;
            sp[2].Value = " ";


            HelperSQL.SqlOkuyucuDondur("sp_Kontrol", true, sp);

            if (sp[2].Value.ToString()=="1")
            {
                Label1.Text = "Giriş Başarılı";

                KisiEntity kisi = new KisiEntity();
                SqlParameter[] sp2 = new SqlParameter[1];
                sp2[0] = new SqlParameter("@KullaniciAdi", tbKullaniciAdi.Text);
                dr=HelperSQL.SqlOkuyucuDondur("vw_KullaniciAdinaGoreKisi", true, sp2);

                while(dr.Read())
                {
                    kisi.Id = dr["KisiID"].ToString();
                }

                //AnaSayfa a = new AnaSayfa(Convert.ToInt32(kisi.Id));

                //Response.Redirect("AnaSayfa.aspx");


                Response.Redirect("AnaSayfa.aspx?id="+kisi.Id);



                //Response.Redirect("AnaSayfa.aspx");
                //Server.Transfer("AnaSayfa.aspx");
            }
            else
            {
                Label1.Text = "Giriş Başarısız";
            }





        }
    }
}