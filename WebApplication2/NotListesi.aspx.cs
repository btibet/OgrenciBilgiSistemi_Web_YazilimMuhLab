using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class NotListesi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { // DataSet1TableAdapters.ogrnotlarTableAdapter sınıfından dt adında bir örnek oluşturuyoruz.
            DataSet1TableAdapters.ogrnotlarTableAdapter dt = new DataSet1TableAdapters.ogrnotlarTableAdapter();

            // Repeater1 kontrolünün veri kaynağını dt.NotlarıGetir() metodundan alıyoruz.
            Repeater1.DataSource = dt.NotlarıGetir();

            // Verileri Repeater1 kontrolüne bağlıyoruz.
            Repeater1.DataBind();
        }
    }
}