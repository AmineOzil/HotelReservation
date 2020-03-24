using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClientApp
{
    public partial class reserverChambre : System.Web.UI.Page
    {
        public void Page_Load(object sender, EventArgs e)
        {
            String result = (String)Session["s1"];
                test.InnerHtml = result;
            
        }
    }
}