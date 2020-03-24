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
             Chambre ch = new Chambre(101, 1, "Simple", 1, 35, "https://www.thonhotels.com/globalassets/hoteller/norge/haugesund/thon-hotel-saga/romtyper/standard-room-single/thon-hotel-saga-standard-room-single-1.jpg?width=1100&height=550&mode=crop&quality=80");
            DateTime dt1 = DateTime.Parse("12/06/2020 12:00");
            DateTime dt2 = DateTime.Parse("18/06/2020 14:00");
            Reservation res = new Reservation(dt1, dt2,120,new Client("Nassim","Sehout","100123543","+33 424 22 11 43",DateTime.Parse("15/10/1993"),new CarteCredit("453435500343","123","Visa Card","10/23")));
            ch.ajouterReservation(res);
                Chambre ch1 = new Chambre(102, 1, "Simple", 1, 35, "https://www.thonhotels.com/globalassets/hoteller/norge/haugesund/thon-hotel-saga/romtyper/standard-room-single/thon-hotel-saga-standard-room-single-1.jpg?width=1100&height=550&mode=crop&quality=80");
                Chambre ch2 = new Chambre(103, 1, "Simple", 1, 35, "https://www.thonhotels.com/globalassets/hoteller/norge/haugesund/thon-hotel-saga/romtyper/standard-room-single/thon-hotel-saga-standard-room-single-1.jpg?width=1100&height=550&mode=crop&quality=80");
                Chambre ch3 = new Chambre(104, 1, "Double", 2, 60, "https://lh3.googleusercontent.com/proxy/KwP-elt55OSSFIl9mL6rNLkBHLgqN5rwDsFo-3YN44lJU1koBysYrZqeXv9xxzeu2HyPtDimHZaHjDby09rKPvLOlunl_69yVuFJ1SYEs5wCXIc6ZxfareT0dQp_A0kaLb09dM8z_wRiTvVVDwTT9N8byQ");
                Chambre ch4 = new Chambre(105, 1, "Duplex", 4, 150, "https://806d2bf04cf5fa54997a-e7c5344b3b84eec5da7b51276407b19c.ssl.cf1.rackcdn.com/responsive/1536/806d2bf04cf5fa54997a-e7c5344b3b84eec5da7b51276407b19c.ssl.cf1.rackcdn.com/responsive/4:3/806d2bf04cf5fa54997a-e7c5344b3b84eec5da7b51276407b19c.ssl.cf1.rackcdn.com/u/conservatorium/rooms/superior-guest-room/Conservatorium_Hotel_Duplex_Guestroom--1-.jpg");
                List<Chambre> chambresHilton = new List<Chambre>();
            chambresHilton.Add(ch);
            chambresHilton.Add(ch1);
            chambresHilton.Add(ch2);
            chambresHilton.Add(ch3);
            chambresHilton.Add(ch4);
            Chambre ch11 = new Chambre(102, 1, "Simple", 1, 10, "https://www.lafenouillere.com/seize/0x500/rooms/chambre-simple-hotel-groupe-hebergement-accueil-randonneurs-cyclisme-gard-ventoux-camargue.JPG");
            Chambre ch12 = new Chambre(103, 1, "Simple", 1, 20, "https://www.hotel-leflorin-rennes.fr/images/bedroom-pictures/chambre-simple-new-1920.jpg");
            Chambre ch13 = new Chambre(104, 1, "Double", 2, 32, "https://d11t49axgioj1l.cloudfront.net/_novaimg/4226226-1323135_0_221_2000_1113_925_515.jpg");
            Chambre ch14 = new Chambre(105, 1, "Duplex", 4, 80, "https://www.cantemerle-hotel-vence.com/wp-content/uploads/2015/09/chambre-cantemerle-hotel-vence_41.jpg");
            List<Chambre> chambressheraton = new List<Chambre>();
            chambressheraton.Add(ch1);
            chambressheraton.Add(ch12);
            chambressheraton.Add(ch13);
            chambressheraton.Add(ch14);

            Hotel hilton = new Hotel(5, true, "Hilton", "Madrid", "Espagne", "Madrid", "+34 911 53 40 00", chambresHilton);
            Hotel sheraton = new Hotel(5, true, "Sheraton", "Montpellier", "France", "Madrid", "+33 911 53 40 00", chambressheraton);

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
            {  if (hotel.Ville.Equals(ville) && hotel.chambresDispo(cin,cout,prixmin,prixmax).Count>0)
                {

                        Hotel hoteldispo = new Hotel(hotel, hotel.chambresDispo(cin,cout,prixmin, prixmax));
                        hotelsDispo.Add(hoteldispo);
                    
                }
            }
            return hotelsDispo;
        }
        [WebMethod]
        public String reserverChambres(int id_hotel,String numero_chambres,String checkin,String checkout,String nom_client,String prenom_client,String num_passeport,String num_tel,String date_naissance,String num_carte,String cvv,String type,String date_expiration)
        {
            if (hotels.Count == 0)
                initialise();
            Hotel h = hotels.Find(hotel => hotel.Id == id_hotel);
            String[] numchambres=numero_chambres.Split(';'); // On utilise ; comme séparateur entre chaque deux numéros de chambre à réserver et là on récupère tous ces numéros 
            List<Chambre> chambres_à_reserver=new List<Chambre>();
            CarteCredit carte = new CarteCredit(num_carte,cvv,type,date_expiration);
            Client client = new Client(nom_client,prenom_client,num_passeport,num_tel,DateTime.Parse(date_naissance),carte);
            DateTime checkIn = DateTime.Parse(checkin);
            DateTime checkOut = DateTime.Parse(checkout);
            int nombre_jours_sejour = (checkOut - checkIn).Days; //Le nombre total des jours de séjour
            if (numchambres.Count() == 0)
            {
                chambres_à_reserver.Add(h.Chambres.Find(chambre => chambre.Numero == int.Parse(numero_chambres)));
            }
            else
            foreach (String num in numchambres)
            {
                Console.WriteLine(num);
                chambres_à_reserver.Add(h.Chambres.Find(chambre => chambre.Numero == int.Parse(num))); 
            }
            int prix_reservation = 0;
            foreach (Chambre chambre in chambres_à_reserver)
            {
                prix_reservation = chambre.Prix*nombre_jours_sejour;
                chambre.ajouterReservation(new Reservation(checkIn, checkOut, prix_reservation, client));
            }
            return "Votre réservation a été confirmée";
        }


    }

}
