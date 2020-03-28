using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

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
                Session["s0"] =id_agence;
                Response.Redirect("rechercherChambre.aspx");
            }
            else
            {
                MessageBox.Show("Identifiant ou mot de passe de l'agence incorrectes, veuillez réessayer à nouveau. Merci !");
            }

        }

        protected void btnLoginInvite_Click(object sender, EventArgs e)
        {
            Response.Redirect("rechercherChambre.aspx");

        }
    }
}