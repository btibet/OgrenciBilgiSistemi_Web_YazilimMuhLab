using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class DuyuruEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Sayfa yüklenirken yapılacak işlemler
            if (Page.IsPostBack == false)
            {
                // Sayfa yenilenmediğinde (ilk yükleme) çalışacak kod bloğu
                // Veritabanından öğretmen listesini alır
                DataSet1TableAdapters.TBL_OGRETMENTableAdapter dt = new DataSet1TableAdapters.TBL_OGRETMENTableAdapter();
                DropDownList1.DataSource = dt.OgretmenListesi();
                DropDownList1.DataTextField = "OGRTADSOYAD";
                DropDownList1.DataValueField = "OGRTID";
                DropDownList1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // "Kaydet" butonuna tıklandığında yapılacak işlemler
            // Duyuru ekleme işlemini gerçekleştiren kod
            DataSet1TableAdapters.TBL_DUYURULARTableAdapter dt = new DataSet1TableAdapters.TBL_DUYURULARTableAdapter();
            dt.DuyuruEkle(TxtDuyuruBaslik.Text, TxtDuyuruicerik.Value.ToString(), Convert.ToInt32(DropDownList1.SelectedValue));

            // Duyuru eklendikten sonra "DuyuruListesi.aspx" sayfasına yönlendirme yapar
            Response.Redirect("DuyuruListesi.aspx");
        }
    }
}
