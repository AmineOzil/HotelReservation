using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClientApp
{
    public partial class agenceENOVBM : System.Web.UI.Page
    {
        String user = "";
        String pass = "";
        String result = "";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLoginAgence_Click(object sender, EventArgs e)
        {
            ClientApp.ServiceHotel.WebService1SoapClient client = new ClientApp.ServiceHotel.WebService1SoapClient();
            user = username.Value;
            pass = password.Value;
            result = client.authentification(user, pass);
            if (!result.Equals(""))
            {
                Session["s0"] = result;
                Response.Redirect("rechercherChambre.aspx");
            }


        }

        protected void btnLoginInvite_Click(object sender, EventArgs e)
        {


        }

    }