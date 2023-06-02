using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{

    public partial class DersGuncelle : System.Web.UI.Page
    {
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Page.IsPostBack == false)
            {
                id = Convert.ToInt32(Request.QueryString["DERSID"].ToString());
                DataSet1TableAdapters.TBL_DERSLERTableAdapter dt = new DataSet1TableAdapters.TBL_DERSLERTableAdapter();
                dt.DersGetir(id);
                TxtDersAdı.Text = dt.DersGetir(id)[0].DERSAD;
            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(Request.QueryString["DERSID"].ToString());
            DataSet1TableAdapters.TBL_DERSLERTableAdapter dt = new DataSet1TableAdapters.TBL_DERSLERTableAdapter();
            dt.DersGuncelle(TxtDersAdı.Text, id);
            Response.Redirect("DersListesi.aspx");

        }
    }
}