using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Serialization;

namespace ClientApp
{
    public partial class rechercherChambre : System.Web.UI.Page
    {
        String checkIn="";
        String checkOut="";
        bool state = false;
        ClientApp.ServiceHotel.Hotel[] result;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (state)
            {
                String html_code = "";
                    for (int j = 0; j < result.Count(); j++)
                    {
                        html_code += "<br><p class=\"text-center\">" + result.ElementAt(j).Nom + "<p class=\"text-center\">" + result.ElementAt(j).Adresse;
                    for (int m = 0; m < result[j].Nbr_étoiles; m++) html_code += "<span> &#11088;</span>";
                    html_code += "</a></p><hr><div class=\"row\" runat=\"server\">";
                        for (int i = 0; i < result.ElementAt(j).Chambres.Count(); i++)
                        {
                            html_code += "<div class=\"col-md-4\" runat=\"server\"> <figure class=\"card card-product\"><div class=\"img-wrap\"><img src = \"" + result.ElementAt(j).Chambres.ElementAt(i).Image + "\" ></div><figcaption class=\"info-wrap\"><h4 class=\"title\">" + result.ElementAt(j).Nom + "</h4><p class=\"desc\"> Chambre " + result.ElementAt(j).Chambres.ElementAt(i).Type + "</p><div class=\"rating-wrap\"></figcaption><div class=\"bottom-wrap\"><button ID=\"" + result[j].Chambres[i].Numero + "_" + result[j].Id + "\" type=\"button\" OnClick=\"__doPostBack('reserver','"+ result[j].Chambres[i].Numero + "_" + result[j].Id +"_"+checkIn+"_"+checkOut+"')\" class=\"btn btn-sm btn-primary float-right\" runat=\"server\"> Réserver</button><div class=\"price-wrap h5\"><span class=\"price-new\">€" + result.ElementAt(j).Chambres.ElementAt(i).Prix + "</span></figure> </div>";
                        }
                        html_code += "</div>";
                    }

                    hotels.InnerHtml = html_code;
                

            }
        }





        protected void btnSearch_Click(object sender, EventArgs e)
        {
            ClientApp.ServiceHotel.WebService1SoapClient client = new ClientApp.ServiceHotel.WebService1SoapClient();
            String dates = depart.Value;
            String splitor = " to";
            String[] datesAR = dates.Split(splitor.ToCharArray());
            checkIn = datesAR[0];
            checkOut = datesAR[4];
            System.Diagnostics.Debug.WriteLine(checkIn + "aaand" + checkOut + "for the city " + ville.Value + "one of the " + prixMax.Value);
            result = client.rechercherChambre(ville.Value,
                                                    checkIn,
                                                    checkOut,
                                                    Convert.ToInt32(prixMin.Value),
                                                    Convert.ToInt32(prixMax.Value),
                                                    Convert.ToInt32(nbrLits.Value)
                                                 );
            state = true;
            this.Page_Load(sender, e);
            SetFocus(hotels);

        }


        protected void btnReserver_Click(object sender, EventArgs e)
        {
            System.Web.UI.HtmlControls.HtmlButton btn = (System.Web.UI.HtmlControls.HtmlButton)sender;


            string requete = Request["__EVENTARGUMENT"];
            String id = (String)Session["s0"];
            Session["s1"] = requete;
            Session["s2"] = id;
            Response.Redirect("reserverChambre.aspx");
            //redirect page ...

        }
    }
}
