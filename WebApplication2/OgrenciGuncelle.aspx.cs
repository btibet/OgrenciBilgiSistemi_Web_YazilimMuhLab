﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class OgrenciGuncelle : System.Web.UI.Page
    {
        int id;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                try
                {
                    // Öğrenci ID'sini al
                    id = Convert.ToInt32(Request.QueryString["OGRID"].ToString());
                    TxtOgrid.Text = id.ToString();

                    // Öğrenci bilgilerini veritabanından getir
                    DataSet1TableAdapters.TBL_OGRENCITableAdapter dt = new DataSet1TableAdapters.TBL_OGRENCITableAdapter();
                    TxtOgrAd.Text = dt.OgrenciSec(id)[0].OGRAD;
                    TxtOgrSoyad.Text = dt.OgrenciSec(id)[0].OGRSOYAD;
                    TxtOgrTel.Text = dt.OgrenciSec(id)[0].OGRTEL;
                    TxtOgrMail.Text = dt.OgrenciSec(id)[0].OGRMAIL;
                    TxtOgrSifre.Text = dt.OgrenciSec(id)[0].OGRSIFRE;
                }
                catch (Exception)
                {
                    // Hata durumunda bir şey yapma
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Öğrenci bilgilerini güncelle
            DataSet1TableAdapters.TBL_OGRENCITableAdapter dt = new DataSet1TableAdapters.TBL_OGRENCITableAdapter();
            dt.OgrenciGuncelle(TxtOgrAd.Text, TxtOgrSoyad.Text, TxtOgrTel.Text, TxtOgrMail.Text, TxtOgrSifre.Text, Convert.ToInt32(TxtOgrid.Text));

            // Anasayfaya yönlendir
            Response.Redirect("Anasayfa.aspx");
        }
    }
}
