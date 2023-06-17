using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class DersGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // DERSID değeri byte türüne dönüştürülerek alınıyor
            byte id;
            if (Page.IsPostBack == false)
            {
                id = Convert.ToByte(Request.QueryString["DERSID"].ToString());

                // DataSet1TableAdapters.TBL_DERSLERTableAdapter sınıfından bir örnek oluşturuluyor
                DataSet1TableAdapters.TBL_DERSLERTableAdapter dt = new DataSet1TableAdapters.TBL_DERSLERTableAdapter();

                // DersSec() metodu kullanılarak seçilen dersin bilgileri alınıyor
                dt.DersSec(id);

                // Ders ID'si ve adı TextBox kontrollerine atanıyor
                txtDersID.Text = id.ToString();
                txtDersAd.Text = dt.DersSec(id)[0].DERSAD;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // DataSet1TableAdapters.TBL_DERSLERTableAdapter sınıfından bir örnek oluşturuluyor
            DataSet1TableAdapters.TBL_DERSLERTableAdapter dt = new DataSet1TableAdapters.TBL_DERSLERTableAdapter();

            // DersGuncelle() metodu kullanılarak ders bilgileri güncelleniyor
            dt.DersGuncelle(txtDersAd.Text, Convert.ToByte(txtDersID.Text));

            // "DersListesiY.aspx" sayfasına yönlendirme yapılıyor
            Response.Redirect("DersListesiY.aspx");
        }
    }
}
