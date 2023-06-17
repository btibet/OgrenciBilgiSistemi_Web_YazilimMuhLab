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
            if (Page.IsPostBack == false)
            {


                //DataSet1TableAdapters.TBL_OGRETMENTableAdapter dt = new DataSet1TableAdapters.TBL_OGRETMENTableAdapter();
                DataSet1TableAdapters.TBL_DERSLERTableAdapter dt1 = new DataSet1TableAdapters.TBL_DERSLERTableAdapter();
                DropDownList1.DataSource = dt1.DersListesi();
                DropDownList1.DataTextField = "DERSAD";
                DropDownList1.DataValueField = "DERSID";
                DropDownList1.DataBind();
            }
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            
            DataSet1TableAdapters.TBL_OGRETMENTableAdapter dt = new DataSet1TableAdapters.TBL_OGRETMENTableAdapter();
            dt.OgretmenEkle(TxtOgrAd.Text, Convert.ToByte(DropDownList1.SelectedValue), TxtOgrTel.Text, TxtOgrSifre.Text);
            Response.Redirect("OgretmenListesi.aspx");
        }
    }
}