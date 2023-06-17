using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class DuyuruEkleY : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Sayfa ilk defa yükleniyorsa yapılacak işlemler
            if (!Page.IsPostBack)
            {
                // TBL_OGRETMENTableAdapter sınıfından bir örnek oluşturuyoruz
                DataSet1TableAdapters.TBL_OGRETMENTableAdapter dt = new DataSet1TableAdapters.TBL_OGRETMENTableAdapter();

                // Öğretmen listesini DropDownList1'e bağlıyoruz
                DropDownList1.DataSource = dt.OgretmenListesi();

                // Öğretmen adını göstermek için veri alanını belirtiyoruz
                DropDownList1.DataTextField = "OGRTADSOYAD";

                // Öğretmenin benzersiz kimliğini depolamak için veri alanını belirtiyoruz
                DropDownList1.DataValueField = "OGRTID";

                // DropDownList1'i veri kaynağıyla bağlıyoruz
                DropDownList1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Kaydet butonuna tıklandığında yapılacak işlemler
            // TBL_DUYURULARTableAdapter sınıfından bir örnek oluşturuyoruz
            DataSet1TableAdapters.TBL_DUYURULARTableAdapter dt = new DataSet1TableAdapters.TBL_DUYURULARTableAdapter();

            // Duyuru eklemek için DuyuruEkle metodunu kullanıyoruz
            // Metoda TextBox'lardan alınan verileri ve DropDownList1'den seçilen öğretmenin kimliğini iletiyoruz
            dt.DuyuruEkle(TxtDuyuruBaslik.Text, TxtDuyuruicerik.Value.ToString(), Convert.ToInt32(DropDownList1.SelectedValue));

            // İşlem tamamlandıktan sonra kullanıcıyı DuyuruListesiY.aspx sayfasına yönlendiriyoruz
            Response.Redirect("DuyuruListesiY.aspx");
        }
    }
}
