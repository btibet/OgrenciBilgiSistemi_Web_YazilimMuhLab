using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class OgrenciGelen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Veritabanı tablosu için TBL_MESAJLARTableAdapter örneği oluşturuluyor
            DataSet1TableAdapters.TBL_MESAJLARTableAdapter dt = new DataSet1TableAdapters.TBL_MESAJLARTableAdapter();

            // Repeater1 kontrolüne veri kaynağı atanıyor
            // OgrencıGelenKutusu1 metodu, öğrencinin gelen mesajlarını veritabanından çekiyor
            // Session["NUMARA"] değişkeni, oturumda tutulan öğrenci numarasını temsil ediyor
            Repeater1.DataSource = dt.OgrencıGelenKutusu1(Session["NUMARA"].ToString());

            // Veri bağlama işlemi gerçekleştiriliyor
            Repeater1.DataBind();
        }
    }
}
