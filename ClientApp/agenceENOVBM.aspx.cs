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
        ClientApp.ServiceHotel.WebService1SoapClient client = new ClientApp.ServiceHotel.WebService1SoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLoginAgence_Click(object sender, EventArgs e)
        {
            int id_agence=client.authentification(username.Value, password.Value);
            if (id_agence != 0)
            {
                Session["s1"] =id_agence;
                Response.Redirect("rechercherChambre.aspx");
            }

        }

        protected void btnLoginInvite_Click(object sender, EventArgs e)
        {
            int id_agence = client.authentification("invite", "invite");
            if (id_agence != 0)
            {
                Session["s1"] = id_agence;
                Response.Redirect("rechercherChambre.aspx");
            }

        }
    }
}