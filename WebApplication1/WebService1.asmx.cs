using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication1
{
    //added to test 
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
        public static List<Hotel> hotels=new List<Hotel>();
       
       
        public void initialise()
        {
             Chambre ch = new Chambre(101, 1, "Simple", 1, 35);
            DateTime dt1 = DateTime.Parse("12/06/2020 12:00");
            DateTime dt2 = DateTime.Parse("18/06/2020 14:00");
            Reservation res = new Reservation(dt1, dt2,120,4);
            ch.ajouterReservation(res);
                Chambre ch1 = new Chambre(102, 1, "Simple", 1, 35);
                Chambre ch2 = new Chambre(103, 1, "Simple", 1, 35);
                Chambre ch3 = new Chambre(104, 1, "Double", 2, 60);
                Chambre ch4 = new Chambre(105, 1, "Duplex", 4, 150);
                List<Chambre> chambresHilton = new List<Chambre>();
            chambresHilton.Add(ch);
            chambresHilton.Add(ch1);
            chambresHilton.Add(ch2);
            chambresHilton.Add(ch3);
            chambresHilton.Add(ch4);
            Chambre ch11 = new Chambre(102, 1, "Simple", 1, 10);
            Chambre ch12 = new Chambre(103, 1, "Simple", 1, 20);
            Chambre ch13 = new Chambre(104, 1, "Double", 2, 32);
            Chambre ch14 = new Chambre(105, 1, "Duplex", 4, 80);
            List<Chambre> chambressheraton = new List<Chambre>();
            chambressheraton.Add(ch1);
            chambressheraton.Add(ch12);
            chambressheraton.Add(ch13);
            chambressheraton.Add(ch14);

            Hotel hilton = new Hotel(5, true, "Hilton", "Madrid", "Espagne", "Madrid", "+34 911 53 40 00", chambresHilton);
            Hotel sheraton = new Hotel(5, true, "Sheraton", "Montpellier", "France", "Montpellier", "+33 911 53 40 00", chambressheraton);

            hotels.Add(hilton);
            hotels.Add(sheraton);

        }

        [WebMethod]
        public List<Hotel> rechercherChambre(String ville, String checkIn,String checkout, int prixmin, int prixmax)
        {
            if (hotels.Count==0)
                initialise();
            List<Hotel> hotelsDispo=new List<Hotel>();
            checkIn += " 12:00";
            checkout += " 14:00";
            DateTime cin=DateTime.Parse(checkIn);
            DateTime cout= DateTime.Parse(checkout);

            foreach (Hotel hotel in hotels)
            {  if (hotel.Ville.Equals(ville))
                {
                    if (hotel.etat(cin, cout))
                    {
                        Hotel hoteldispo = new Hotel(hotel, hotel.chambresDispo(cin,cout,prixmin, prixmax));
                        hotelsDispo.Add(hoteldispo);
                    }
                }
            }
            return hotelsDispo;
        }

    }

}
