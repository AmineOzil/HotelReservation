using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClientApp
{
    public partial class resultats : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceHotel.WebService1SoapClient client = new ServiceHotel.WebService1SoapClient();
            test.InnerHtml = "Testing";
            hotel.InnerHtml="<figure class=\"card card-product\"><div class=\"img-wrap\"><img src = \"https://www.hotel-diana-dauphine.com/media/cache/jadro_resize/rc/rhCiPkJe1582096951/jadroRoot/medias/5658345e8f976/chambre-1.jpg\" ></div><figcaption class=\"info-wrap\"><h4 class=\"title\">Amine OZIL is just testing</h4><p class=\"desc\">Some small description goes here</p><div class=\"rating-wrap\"><div class=\"label-rating\">132 reviews</div><div class=\"label-rating\">154 orders</div></div> </figcaption><div class=\"bottom-wrap\"><a href = \"\" class=\"btn btn-sm btn-primary float-right\">Order Now</a><div class=\"price-wrap h5\"><span class=\"price-new\">$1280</span> <del class=\"price-old\">$1980</del></div> </div></figure>";
        }
    }
}