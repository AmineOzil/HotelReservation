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
        public static List<Partenariat> partenariats = new List<Partenariat>();
        public static List<Agence> agences = new List<Agence>();


        public void initialise()
        {
            /* Réserver une chambre */

            Chambre ch = new Chambre(101, 1, "Simple", 1, 35, "https://www.thonhotels.com/globalassets/hoteller/norge/haugesund/thon-hotel-saga/romtyper/standard-room-single/thon-hotel-saga-standard-room-single-1.jpg?width=1100&height=550&mode=crop&quality=80");
            DateTime dt1 = DateTime.Parse("12/06/2020 12:00");
            DateTime dt2 = DateTime.Parse("18/06/2020 14:00");

            Reservation res = new Reservation(dt1, dt2, 120, new Client("Nassim", "Sehout", "100123543", "+33 424 22 11 43", DateTime.Parse("15/10/1993"), new CarteCredit("453435500343", "123", "Visa Card", "10/23")), 1);
            ch.ajouterReservation(res);

            /* Fin de réservation */

            /* Ajout des chambre pour l'hotel : HILTON */

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

            /* Fin d'ajout */

            /* Ajout des chambre pour l'hotel : SHERATON */

            Chambre ch11 = new Chambre(106, 1, "Simple", 1, 10, "https://www.lafenouillere.com/seize/0x500/rooms/chambre-simple-hotel-groupe-hebergement-accueil-randonneurs-cyclisme-gard-ventoux-camargue.JPG");
            Chambre ch12 = new Chambre(107, 1, "Simple", 1, 20, "https://www.hotel-leflorin-rennes.fr/images/bedroom-pictures/chambre-simple-new-1920.jpg");
            Chambre ch13 = new Chambre(108, 1, "Double", 2, 32, "https://d11t49axgioj1l.cloudfront.net/_novaimg/4226226-1323135_0_221_2000_1113_925_515.jpg");
            Chambre ch14 = new Chambre(109, 1, "Duplex", 4, 80, "https://www.cantemerle-hotel-vence.com/wp-content/uploads/2015/09/chambre-cantemerle-hotel-vence_41.jpg");

            List<Chambre> chambressheraton = new List<Chambre>();
            chambressheraton.Add(ch11);
            chambressheraton.Add(ch12);
            chambressheraton.Add(ch13);
            chambressheraton.Add(ch14);

            /* Fin d'ajout */

            /* Ajout des chambre pour l'hotel : MARIOTT */

            Chambre ch111 = new Chambre(110, 1, "Simple", 1, 25, "https://www.lafenouillere.com/seize/0x500/rooms/chambre-simple-hotel-groupe-hebergement-accueil-randonneurs-cyclisme-gard-ventoux-camargue.JPG");
            Chambre ch122 = new Chambre(111, 2, "Simple", 1, 25, "https://www.hotel-leflorin-rennes.fr/images/bedroom-pictures/chambre-simple-new-1920.jpg");
            Chambre ch133 = new Chambre(112, 3, "Double", 2, 50, "https://d11t49axgioj1l.cloudfront.net/_novaimg/4226226-1323135_0_221_2000_1113_925_515.jpg");
            Chambre ch144 = new Chambre(113, 4, "Duplex", 4, 100, "https://www.cantemerle-hotel-vence.com/wp-content/uploads/2015/09/chambre-cantemerle-hotel-vence_41.jpg");

            List<Chambre> chambresmariott = new List<Chambre>();
            chambresmariott.Add(ch111);
            chambresmariott.Add(ch122);
            chambresmariott.Add(ch133);
            chambresmariott.Add(ch144);

            /* Fin d'ajout */

            /* Ajout des chambre pour l'hotel : ST CHRISTOPHER */

            Chambre ch1111 = new Chambre(114, 1, "Simple", 1, 15, "https://www.lafenouillere.com/seize/0x500/rooms/chambre-simple-hotel-groupe-hebergement-accueil-randonneurs-cyclisme-gard-ventoux-camargue.JPG");
            Chambre ch1222 = new Chambre(115, 2, "Simple", 1, 15, "https://www.hotel-leflorin-rennes.fr/images/bedroom-pictures/chambre-simple-new-1920.jpg");
            Chambre ch1333 = new Chambre(116, 3, "Double", 2, 30, "https://d11t49axgioj1l.cloudfront.net/_novaimg/4226226-1323135_0_221_2000_1113_925_515.jpg");
            Chambre ch1444 = new Chambre(117, 4, "Duplex", 4, 70, "https://www.cantemerle-hotel-vence.com/wp-content/uploads/2015/09/chambre-cantemerle-hotel-vence_41.jpg");

            List<Chambre> chambresstchristopher = new List<Chambre>();
            chambresstchristopher.Add(ch1111);
            chambresstchristopher.Add(ch1222);
            chambresstchristopher.Add(ch1333);
            chambresstchristopher.Add(ch1444);

            /* Fin d'ajout */

            /*Ajout des agences */

            Agence asfar = new Agence("Asfar Voyages", "asfar", "asfar20", "France");
            Agence havas = new Agence("Havas Voyages", "havas", "havas19", "France");
            Agence enovbm = new Agence("ENOVBM", "enovbm", "montpellier20", "Algerie");
            Agence invité = new Agence("Invité", "invite", "invite", "World");

            agences.Add(asfar);
            agences.Add(havas);
            agences.Add(enovbm);
            agences.Add(invité);
            /*fin d'ajout*/
            /* Attribution des chambres pour les hôtels */

            Hotel hilton = new Hotel(5, true, "Hilton", "Calle de Manuela Malasaña, 6, 28004 Madrid, Espagne", "Espagne", "Madrid", "+34 914 48 58 16", chambresHilton);
            Hotel sheraton = new Hotel(5, true, "Sheraton", "1 Rue des Pertuisanes, 34000 Montpellier", "France", "Montpellier", "+33 467 99 72 72", chambressheraton);
            Hotel mariott = new Hotel(5, true, "Mariott", "70 avenue des Champs-Élysées, Paris 75008", "France", "Paris", "+33 153 93 55 00", chambresmariott);
            Hotel stchristopher = new Hotel(3, true, "St Christopher", "Carrer de Bergara, 3, 08002 Madrid, Espagne", "Espagne", "Madrid", "+34 931 75 14 01", chambresstchristopher);


            hotels.Add(hilton);
            hotels.Add(sheraton);
            hotels.Add(mariott);
            hotels.Add(stchristopher);


            /* Fin d'attribution */
            /*Ajout des partenariats*/
            int idasfar =asfar.Id;
            int idhavas= havas.Id;
            int idenovbm= enovbm.Id;
            int idinvité = invité.Id;
            int idhilton = hilton.Id;
            int idsh = sheraton.Id;
            int idst = stchristopher.Id;
            int idmar = mariott.Id;
            Partenariat p1 = new Partenariat(idasfar, idhilton, 0.20);
            Partenariat p2 = new Partenariat(idasfar, idsh, 0.25);
            Partenariat p3 = new Partenariat(idasfar, idst, 0.12);
            Partenariat p4 = new Partenariat(idenovbm, idhilton, 0.30);
            Partenariat p5 = new Partenariat(idenovbm, idsh, 0.25);
            Partenariat p6 = new Partenariat(idenovbm, idmar, 0.10);
            Partenariat p7 = new Partenariat(idenovbm, idst, 0.35);
            Partenariat p8 = new Partenariat(idhavas, idhilton, 0.15);
            Partenariat p9 = new Partenariat(idhavas, idsh, 0.20);
            Partenariat p10 = new Partenariat(idhavas, idmar, 0.25);
            partenariats.Add(p1);
            partenariats.Add(p2);
            partenariats.Add(p3);
            partenariats.Add(p4);
            partenariats.Add(p5);
            partenariats.Add(p6);
            partenariats.Add(p7);
            partenariats.Add(p8);
            partenariats.Add(p9);
            partenariats.Add(p10);
        }

        [WebMethod]
        public List<Hotel> rechercherChambre(String ville, String checkIn,String checkout, int prixmin, int prixmax, int nbrLits)
        {
            if (hotels.Count==0 || agences.Count==0 || partenariats.Count == 0)
                initialise();
            List<Hotel> hotelsDispo=new List<Hotel>();
            checkIn += " 12:00";
            checkout += " 14:00";
            DateTime cin=DateTime.Parse(checkIn);
            DateTime cout= DateTime.Parse(checkout);

            foreach (Hotel hotel in hotels)
            {  if (hotel.Ville.Equals(ville) && hotel.chambresDispo(cin,cout,prixmin,prixmax,nbrLits).Count>0)
                {

                        Hotel hoteldispo = new Hotel(hotel, hotel.chambresDispo(cin,cout,prixmin, prixmax, nbrLits));
                        hotelsDispo.Add(hoteldispo);
                    
                }
            }
            return hotelsDispo;
        }
        [WebMethod]
        public String reserverChambres(int id_hotel,String numero_chambres,String checkin,String checkout,String nom_client,String prenom_client,String num_passeport,String num_tel,String date_naissance,String num_carte,String cvv,String type,String date_expiration, int id_agence)
        {
            if (hotels.Count == 0 || agences.Count == 0 || partenariats.Count == 0)
                initialise();
            Hotel h = hotels.Find(hotel => hotel.Id == id_hotel);
            String[] numchambres=numero_chambres.Split(';'); // On utilise ; comme séparateur entre chaque deux numéros de chambre à réserver et là on récupère tous ces numéros 
            List<Chambre> chambres_à_reserver=new List<Chambre>();
            CarteCredit carte = new CarteCredit(num_carte,cvv,type,date_expiration);
            Client client = new Client(nom_client,prenom_client,num_passeport,num_tel,DateTime.Parse(date_naissance),carte);
            DateTime checkIn = DateTime.Parse(checkin);
            DateTime checkOut = DateTime.Parse(checkout);
            int nombre_jours_sejour = (checkOut - checkIn).Days; //Le nombre total des jours de séjour
            Agence ag = agences.Find(agence => agence.Id == id_agence);
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
                chambre.ajouterReservation(new Reservation(checkIn, checkOut, prix_reservation, client, ag.Id));
            }
            return "Votre réservation a été effectuée avec succès !";
        }
        public void prixAgence(int id_agence)
        {

            List<Partenariat> partenariats_agence = partenariats.FindAll(partenariat => partenariat.Id_agence == id_agence); //Récupérer toutes les partenariats d'une agence
            foreach (Partenariat partenariat in partenariats_agence) //Pour chaque partenariat d'une agence
            {
                Hotel hotel_partenaire = hotels.Find(hotel => partenariat.Id_hotel == hotel.Id); //Récupérer l'hôtel partenaire
                foreach (Chambre chambre in hotel_partenaire.Chambres) //Pour toutes les chambres d'un hôtel partenaire
                {
                    chambre.Prix -=(int) (chambre.Prix * partenariat.Pourcentage); //Appliquer le pourcentage de la remise pour cette chambre
                }
            }
        }
        [WebMethod]
        public int authentification(String identifiant,String mot_de_passe)
        {
            if (hotels.Count == 0 || agences.Count == 0 || partenariats.Count == 0)
                initialise();
            foreach (Agence agence in agences)
            {
                if (identifiant == agence.Username && agence.Password == mot_de_passe)
                {
                    prixAgence(agence.Id);
                    return agence.Id;
                }
            }
            return 0;
        }

    }

}
