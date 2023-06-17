using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class NotEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Sayfa yüklenirken çalışacak kodlar
            if (!Page.IsPostBack)
            {
                // Sayfa ilk kez yüklendiğinde yapılacak işlemler

                // TBL_DERSLER tablosuna erişmek için adapter oluşturulur
                DataSet1TableAdapters.TBL_DERSLERTableAdapter dt1 = new DataSet1TableAdapters.TBL_DERSLERTableAdapter();

                // DropDownList1'in veri kaynağı TBL_DERSLER tablosundaki veriler olur
                DropDownList1.DataSource = dt1.DersListesi();

                // DropDownList1'in gösterilecek değeri DERSAD alanı olur
                DropDownList1.DataTextField = "DERSAD";

                // DropDownList1'in değer olarak tutulacak değeri DERSID alanı olur
                DropDownList1.DataValueField = "DERSID";

                // DropDownList1 verileri ile dolur
                DropDownList1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Not eklemek için butona tıklandığında yapılacak işlemler

            // ogrnotlar tablosuna erişmek için adapter oluşturulur
            DataSet1TableAdapters.ogrnotlarTableAdapter dt = new DataSet1TableAdapters.ogrnotlarTableAdapter();

            // NotEkle metodu çağrılarak notlar eklenir
            dt.NotEkle(Convert.ToInt32(TxtOgrid.Text), Convert.ToByte(DropDownList1.SelectedValue), Convert.ToByte(TxtSınav1.Text), Convert.ToByte(TxtSınav2.Text), Convert.ToByte(TxtSınav3.Text));

            // Not eklendikten sonra NotListesi.aspx sayfasına yönlendirilir
            Response.Redirect("NotListesi.aspx");
        }
    }
}
