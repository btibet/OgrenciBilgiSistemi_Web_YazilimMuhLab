﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class OgretmenGuncelle : System.Web.UI.Page
    {
        int id; // Öğretmen kimlik numarasını tutmak için değişken tanımlandı.

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                try
                {
                    // Öğretmen kimlik numarası alınıyor
                    id = Convert.ToInt32(Request.QueryString["OGRTID"].ToString());
                    TxtOgrid.Text = id.ToString();

                    // Öğretmenin verileri veritabanından alınıyor ve ilgili alanlara yerleştiriliyor
                    DataSet1TableAdapters.TBL_OGRETMENTableAdapter dt = new DataSet1TableAdapters.TBL_OGRETMENTableAdapter();
                    TxtOgrid.Text = dt.OgretmenSec(id)[0].OGRTID.ToString();
                    TxtOgrAd.Text = dt.OgretmenSec(id)[0].OGRTADSOYAD;
                    TxtOgrTel.Text = dt.OgretmenSec(id)[0].OGRNUMARA;
                    TxtOgrSifre.Text = dt.OgretmenSec(id)[0].OGRTSIFRE;

                    // Derslerin bir DropDownList'e yüklenmesi
                    DataSet1TableAdapters.TBL_DERSLERTableAdapter dt1 = new DataSet1TableAdapters.TBL_DERSLERTableAdapter();
                    DropDownList1.DataSource = dt1.DersListesi();
                    DropDownList1.DataTextField = "DERSAD";
                    DropDownList1.DataValueField = "DERSID";
                    DropDownList1.DataBind();
                }
                catch (Exception)
                {
                    // Hata durumunda bir işlem yapılmayacak.
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Öğretmen verilerinin güncellenmesi
            DataSet1TableAdapters.TBL_OGRETMENTableAdapter dt = new DataSet1TableAdapters.TBL_OGRETMENTableAdapter();
            dt.OgretmenGuncelle(TxtOgrAd.Text, Convert.ToByte(DropDownList1.Text), TxtOgrTel.Text, TxtOgrSifre.Text, Convert.ToInt32(TxtOgrid.Text));

            // Sayfanın "OgretmenListesi.aspx" sayfasına yönlendirilmesi
            Response.Redirect("OgretmenListesi.aspx");
        }
    }
}
