using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace ClientApp
{
    public partial class resultats : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //test.InnerHtml = "Testing";
            
            ClientApp.ServiceHotel.Hotel[] result2 = (ClientApp.ServiceHotel.Hotel[])Session["s1"];
            
            String nassims = "";
            for (int j = 0; j < result2.Count(); j++) {
                nassims += "<br><p class=\"text-center\">"+result2.ElementAt(j).Nom+"</a></p><hr><div class=\"row\" runat=\"server\">";

                for (int i = 0; i < result2.ElementAt(j).Chambres.Count(); i++)
                {
                    nassims += "<div class=\"col-md-4\" runat=\"server\"> <figure class=\"card card-product\"><div class=\"img-wrap\"><img src = \""+ result2.ElementAt(j).Chambres.ElementAt(i).Image + "\" ></div><figcaption class=\"info-wrap\"><h4 class=\"title\">" + result2.ElementAt(j).Nom + "</h4><p class=\"desc\"> Chambre "+ result2.ElementAt(j).Chambres.ElementAt(i).Type + "</p><div class=\"rating-wrap\"></figcaption><div class=\"bottom-wrap\"><a href = \"\" class=\"btn btn-sm btn-primary float-right\"> Réserver</a><div class=\"price-wrap h5\"><span class=\"price-new\">$" + result2.ElementAt(j).Chambres.ElementAt(i).Prix + "</span></figure> </div>";
                }
                nassims += "</div>";
            }
            hotels.InnerHtml = nassims;
        }
    }
}