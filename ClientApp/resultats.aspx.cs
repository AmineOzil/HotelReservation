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
        protected void Page_Load(object sender, EventArgs e,ServiceHotel.Hotel[] hotels)
        {
            ServiceHotel.WebService1SoapClient client = new ServiceHotel.WebService1SoapClient();
            test.InnerHtml = "Testing";
        }
    }
}