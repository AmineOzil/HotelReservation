using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class reserverChambre : System.Web.UI.Page
    {
        String id_hotel = "";
        String num_chambre = "";
        String checkIn = "";
        String checkOut = "";

        public void Page_Load(object sender, EventArgs e)
        {
            String result = (String)Session["s1"];
            String splitor = "_";
            String[] dataChambreHotel = result.Split(splitor.ToCharArray());

            num_chambre = dataChambreHotel[0];
            id_hotel = dataChambreHotel[1];
            checkIn = dataChambreHotel[2];
            checkOut = dataChambreHotel[3];
            System.Diagnostics.Debug.WriteLine(
              "  ID_Hotel : " + id_hotel +
              "  Num_Chambre : " + num_chambre +
              "  chekIn : " + checkIn +
              "  chekOut : " + checkOut
              );


        }

        protected void btnFinish_Click(object sender, EventArgs e)
        {
            ClientApp.ServiceHotel.WebService1SoapClient client = new ClientApp.ServiceHotel.WebService1SoapClient();
           
            String result = (String)Session["s1"];
            String splitor = "_";
            String[] dataChambreHotel = result.Split(splitor.ToCharArray());
            
            num_chambre = dataChambreHotel[0];
            id_hotel = dataChambreHotel[1];
            checkIn = dataChambreHotel[2];
            checkOut = dataChambreHotel[3];
            
            String nom = nomC.Value;
            String prenom = prenomC.Value;
            String numpass = numPass.Value;
            String numtel = numTel.Value;
            String datenaiss = dateNaiss.Value;
            String numcarte = numCarte.Value;
            String cvv = cVV.Value;
            String typecarte = typeCarte.Value;
            String dateexpir = dateExpi.Value;

            System.Diagnostics.Debug.WriteLine(
                "  ID_Hotel : " + id_hotel +
                "  Num_Chambre : " + num_chambre +
                "  chekIn : " + checkIn + 
                "  chekOut : " + checkOut 
                );


            String msg = client.reserverChambres(
                        Convert.ToInt32(id_hotel),
                        num_chambre,
                        checkIn,
                        checkOut,
                        nom, prenom, numpass, numtel, datenaiss,
                        numcarte, cvv, typecarte, dateexpir);

            System.Diagnostics.Debug.WriteLine("Le msg est :"+msg);

            // Displays the MessageBox.
            MessageBox.Show("Félicitation Mr "+nom+" "+prenom+" votre réservation est effectuée avec succès! nous espérons vous voir chez nous le plutot possible ^^");
            Response.Redirect("rechercherChambre.aspx");





        }
    }
}