using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class DersSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // QueryString üzerinden "DERSID" parametresi alınıyor ve bir bayt (byte) veri türüne dönüştürülüyor
            Byte id = Convert.ToByte(Request.QueryString["DERSID"].ToString());

            // DataSet1 veri tabanı tablosu ile etkileşim sağlayan bir adapter oluşturuluyor
            DataSet1TableAdapters.TBL_DERSLERTableAdapter dt = new DataSet1TableAdapters.TBL_DERSLERTableAdapter();

            // Belirtilen DERSID'ye sahip dersi silmek için adapterin DersSil() yöntemi çağrılıyor
            dt.DersSil(id);

            // Silme işlemi tamamlandıktan sonra kullanıcıyı DersListesiY.aspx sayfasına yönlendiriyoruz
            Response.Redirect("DersListesiY.aspx");
        }
    }
}
