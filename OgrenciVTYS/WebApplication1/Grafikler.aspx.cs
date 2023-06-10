using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Grafikler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WebChartControl1.Series["Dersler"].Points.AddPoint("Matematik", 77);
            WebChartControl1.Series["Dersler"].Points.AddPoint("Bilgisayar", 41);
            WebChartControl1.Series["Dersler"].Points.AddPoint("Kodlama", 85);
            WebChartControl1.Series["Dersler"].Points.AddPoint("Türkçe", 25);


            WebChartControl2.Series["Öğretmen"].Points.AddPoint("Matematik", 77);
            WebChartControl2.Series["Öğretmen"].Points.AddPoint("Bilgisayar", 41);
            WebChartControl2.Series["Öğretmen"].Points.AddPoint("Kodlama", 85);
            WebChartControl2.Series["Öğretmen"].Points.AddPoint("Türkçe", 25);
        }
    }
}