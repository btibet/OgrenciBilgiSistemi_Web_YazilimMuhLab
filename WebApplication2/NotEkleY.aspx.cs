using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class NotEkleY : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Sayfa, PostBack işleminden gelmiyorsa yani ilk kez yüklendiyse çalışır
            if (Page.IsPostBack == false)
            {
                // DataSet1 içerisinde bulunan TBL_DERSLER tablosu için bir TableAdapter oluşturulur
                DataSet1TableAdapters.TBL_DERSLERTableAdapter dt1 = new DataSet1TableAdapters.TBL_DERSLERTableAdapter();

                // DropDownList1 için veri kaynağı olarak dt1.DersListesi() metodu kullanılır
                DropDownList1.DataSource = dt1.DersListesi();

                // DropDownList1 üzerinde görünen metin DERSAD sütunundan alınır
                DropDownList1.DataTextField = "DERSAD";

                // DropDownList1 üzerindeki değer DERSID sütunundan alınır
                DropDownList1.DataValueField = "DERSID";

                // Veriler DropDownList1'e bağlanır
                DropDownList1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // DataSet1 içerisinde bulunan ogrnotlar tablosu için bir TableAdapter oluşturulur
            DataSet1TableAdapters.ogrnotlarTableAdapter dt = new DataSet1TableAdapters.ogrnotlarTableAdapter();

            // NotEkle metodu kullanılarak öğrenci notları veritabanına eklenir
            dt.NotEkle(Convert.ToInt32(TxtOgrid.Text), Convert.ToByte(DropDownList1.SelectedValue), Convert.ToByte(TxtSınav1.Text), Convert.ToByte(TxtSınav2.Text), Convert.ToByte(TxtSınav3.Text));

            // NotListesiY.aspx sayfasına yönlendirilir
            Response.Redirect("NotListesiY.aspx");
        }
    }
}
