using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class OgrencidenOgretmene : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { // Sayfa yüklendiğinde çalışacak kodlar

            // Session'dan NUMARA değerini alıp TxtGonderen textbox'ına yazdırma
            TxtGonderen.Text = Session["NUMARA"].ToString();

            // Sayfa postback olmadığında çalışacak kodlar
            if (Page.IsPostBack == false)
            {
                // TBL_OGRETMENTableAdapter sınıfından bir instance oluşturma
                DataSet1TableAdapters.TBL_OGRETMENTableAdapter dt = new DataSet1TableAdapters.TBL_OGRETMENTableAdapter();

                // DropDownList1'in veri kaynağını TBL_OGRETMENTableAdapter sınıfının OgretmenListesi() metodu ile doldurma
                DropDownList1.DataSource = dt.OgretmenListesi();

                // DropDownList1'in görünen metni "OGRTADSOYAD" sütunundan alınacak
                DropDownList1.DataTextField = "OGRTADSOYAD";

                // DropDownList1'in değeri "OGRTID" sütunundan alınacak
                DropDownList1.DataValueField = "OGRTID";

                // DropDownList1'i veri kaynağı ile bağlama
                DropDownList1.DataBind();
            }
        }

        protected void BtnGonder_Click(object sender, EventArgs e)
        {
            // TBL_MESAJLARTableAdapter sınıfından bir instance oluşturma
            DataSet1TableAdapters.TBL_MESAJLARTableAdapter dt = new DataSet1TableAdapters.TBL_MESAJLARTableAdapter();

            // MesajGonder() metodu ile mesaj gönderme işlemi gerçekleştirme
            dt.MesajGonder(TxtGonderen.Text, DropDownList1.Text, TxtBaslik.Text, TxtMesajicerik.Value);

            // OgrenciGiden.aspx sayfasına yönlendirme
            Response.Redirect("OgrenciGiden.aspx");
        }
    }
}