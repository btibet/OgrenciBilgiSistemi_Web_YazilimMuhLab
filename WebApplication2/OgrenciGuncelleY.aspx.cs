using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class OgrenciGuncelleY : System.Web.UI.Page
    {
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                try
                {
                    // Öğrenci ID'sini sorgu parametresinden alarak sayfaya yükler
                    id = Convert.ToInt32(Request.QueryString["OGRID"].ToString());
                    TxtOgrid.Text = id.ToString();
                    DataSet1TableAdapters.TBL_OGRENCITableAdapter dt = new DataSet1TableAdapters.TBL_OGRENCITableAdapter();
                    // Öğrenci bilgilerini veritabanından alarak ilgili metin kutularına doldurur
                    TxtOgrAd.Text = dt.OgrenciSec(id)[0].OGRAD;
                    TxtOgrSoyad.Text = dt.OgrenciSec(id)[0].OGRSOYAD;
                    TxtOgrTel.Text = dt.OgrenciSec(id)[0].OGRTEL;
                    TxtOgrMail.Text = dt.OgrenciSec(id)[0].OGRMAIL;
                    TxtOgrSifre.Text = dt.OgrenciSec(id)[0].OGRSIFRE;

                }
                catch (Exception)
                {
                    // Hata durumunda bir işlem yapma
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBL_OGRENCITableAdapter dt = new DataSet1TableAdapters.TBL_OGRENCITableAdapter();
            // Öğrenci bilgilerini günceller
            dt.OgrenciGuncelle(TxtOgrAd.Text, TxtOgrSoyad.Text, TxtOgrTel.Text, TxtOgrMail.Text, TxtOgrSifre.Text, Convert.ToInt32(TxtOgrid.Text));
            // Anasayfaya yönlendirme yapar
            Response.Redirect("YoneticiDefault.aspx");
        }
    }
}
