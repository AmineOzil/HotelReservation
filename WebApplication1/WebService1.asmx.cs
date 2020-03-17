using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication1
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        List<Hotel> hotels;
        
        public void addHotel(int id, int nbr_étoiles, bool état, string nom, string adresse, string pays, string ville, string num_tel, List<Chambre> chambres)
        {
            hotels.Add(new Hotel(id, nbr_étoiles, état, nom, adresse, pays, ville, num_tel, chambres));
        }
        [WebMethod]
        public ArrayList<Hotel> rechercherChambre(String ville, DateTime checkIn,DateTime checkout, int)
        {
            hotels.Add(new Hotel(id, nbr_étoiles, état, nom, adresse, pays, ville, num_tel, chambres));
        }

    }
}
