using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class OgrenciSilY : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Sayfa yüklendiğinde çalışan olay işleyicisi
            // Request.QueryString ile OGRID parametresi alınır ve int türüne dönüştürülür
            int id = Convert.ToInt32(Request.QueryString["OGRID"].ToString());

            // DataSet1 içerisindeki TBL_OGRENCITableAdapter sınıfından bir örnek oluşturulur
            DataSet1TableAdapters.TBL_OGRENCITableAdapter dt = new DataSet1TableAdapters.TBL_OGRENCITableAdapter();

            // Öğrenciyi silmek için TBL_OGRENCITableAdapter sınıfındaki OgrenciSil metodu çağrılır
            // Silme işlemi için id parametresi kullanılır
            dt.OgrenciSil(id);

            // Silme işlemi tamamlandıktan sonra YoneticiDefault.aspx sayfasına yönlendirme yapılır
            Response.Redirect("YoneticiDefault.aspx");
        }
    }
}
