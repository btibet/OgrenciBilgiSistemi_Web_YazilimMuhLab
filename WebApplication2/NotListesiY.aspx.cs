﻿using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Web; 
using System.Web.UI; 
using System.Web.UI.WebControls; 

namespace WebApplication2 
{
    public partial class NotListesiY : System.Web.UI.Page 
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.ogrnotlarTableAdapter dt = new DataSet1TableAdapters.ogrnotlarTableAdapter(); // DataSet1 üzerinde tanımlanmış olan ogrnotlarTableAdapter sınıfından bir nesne oluşturuluyor
            Repeater1.DataSource = dt.NotlarıGetir(); // Repeater1 kontrolünün veri kaynağı olarak dt.NotlarıGetir() metodu atanıyor
            Repeater1.DataBind(); // Veri bağlama işlemi gerçekleştiriliyor
        }
    }
}