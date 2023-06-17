using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class DuyuruGuncelleY : System.Web.UI.Page
    {
        int id;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                // Duyuru ID'sini almak için QueryString'i kullanarak id değişkenine atama yapılır
                id = Convert.ToInt32(Request.QueryString["DUYURUID"].ToString());

                // DataSet1TableAdapters.TBL_DUYURULARTableAdapter sınıfından bir örnek oluşturulur
                DataSet1TableAdapters.TBL_DUYURULARTableAdapter dt = new DataSet1TableAdapters.TBL_DUYURULARTableAdapter();

                // Duyuruyu seçmek için dt.DuyuruSec metoduna id parametresi verilir
                dt.DuyuruSec(id);

                // Duyurunun özellikleri ilgili kontrol elemanlarına atanır
                TxtDuyuruId.Text = id.ToString();
                TxtDuyuruBaslik.Text = dt.DuyuruSec(id)[0].DUYURUBASLIK;
                TxtDuyuruicerik.Value = dt.DuyuruSec(id)[0].DUYURUICERIK;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // DataSet1TableAdapters.TBL_DUYURULARTableAdapter sınıfından bir örnek oluşturulur
            DataSet1TableAdapters.TBL_DUYURULARTableAdapter dt = new DataSet1TableAdapters.TBL_DUYURULARTableAdapter();

            // Duyuruyu güncellemek için dt.DuyuruGuncelle metoduna gerekli parametreler verilir
            dt.DuyuruGuncelle(TxtDuyuruBaslik.Text, TxtDuyuruicerik.Value, Convert.ToInt32(TxtDuyuruId.Text));

            // Sayfayı "DuyuruListesiY.aspx" sayfasına yönlendirir
            Response.Redirect("DuyuruListesiY.aspx");
        }
    }
}
