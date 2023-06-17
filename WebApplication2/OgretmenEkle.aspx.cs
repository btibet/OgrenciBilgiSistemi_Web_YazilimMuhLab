using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class OgretmenEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Sayfa ilk yüklendiğinde yapılacak işlemler
            if (Page.IsPostBack == false)
            {
                // Eğer sayfa postback değilse (yani ilk yükleme), aşağıdaki işlemler gerçekleştirilir.

                // TBL_DERSLER tablosundan verileri alacak bir veri adaptörü oluşturulur
                DataSet1TableAdapters.TBL_DERSLERTableAdapter dt1 = new DataSet1TableAdapters.TBL_DERSLERTableAdapter();

                // DropDownList1 veri kaynağına TBL_DERSLER tablosundan alınan veriler atanır
                DropDownList1.DataSource = dt1.DersListesi();

                // DropDownList1'da gösterilecek metin alanı "DERSAD" olarak ayarlanır
                DropDownList1.DataTextField = "DERSAD";

                // DropDownList1'da değer olarak kullanılacak alan "DERSID" olarak ayarlanır
                DropDownList1.DataValueField = "DERSID";

                // DropDownList1 verileri bağlanır
                DropDownList1.DataBind();
            }
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            // "Kaydet" butonuna tıklandığında yapılacak işlemler

            // TBL_OGRETMENTableAdapter veri adaptörü oluşturulur
            DataSet1TableAdapters.TBL_OGRETMENTableAdapter dt = new DataSet1TableAdapters.TBL_OGRETMENTableAdapter();

            // Öğretmeni eklemek için OgretmenEkle() metoduna gerekli parametreler ile çağrı yapılır
            dt.OgretmenEkle(TxtOgrAd.Text, Convert.ToByte(DropDownList1.SelectedValue), TxtOgrTel.Text, TxtOgrSifre.Text);

            // İşlem tamamlandıktan sonra OgretmenListesi.aspx sayfasına yönlendirilir
            Response.Redirect("OgretmenListesi.aspx");
        }
    }
}
