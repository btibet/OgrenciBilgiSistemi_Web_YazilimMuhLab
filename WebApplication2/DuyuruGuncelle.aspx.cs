using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class DuyuruGuncelle : System.Web.UI.Page
    {
        int id;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                // Güncellenecek duyurunun ID'sini alma
                id = Convert.ToInt32(Request.QueryString["DUYURUID"].ToString());

                // TBL_DUYURULARTableAdapter nesnesini oluşturma
                DataSet1TableAdapters.TBL_DUYURULARTableAdapter dt = new DataSet1TableAdapters.TBL_DUYURULARTableAdapter();

                // Duyuruyu seçme ve ilgili kontrollere değerleri atama
                dt.DuyuruSec(id);
                TxtDuyuruId.Text = id.ToString();
                TxtDuyuruBaslik.Text = dt.DuyuruSec(id)[0].DUYURUBASLIK;
                TxtDuyuruicerik.Value = dt.DuyuruSec(id)[0].DUYURUICERIK;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // TBL_DUYURULARTableAdapter nesnesini oluşturma
            DataSet1TableAdapters.TBL_DUYURULARTableAdapter dt = new DataSet1TableAdapters.TBL_DUYURULARTableAdapter();

            // Duyuruyu güncelleme
            dt.DuyuruGuncelle(TxtDuyuruBaslik.Text, TxtDuyuruicerik.Value, Convert.ToInt32(TxtDuyuruId.Text));

            // Duyuru listesine yönlendirme
            Response.Redirect("DuyuruListesi.aspx");
        }
    }
}
