using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Hotel
    {
        private static int id=0; //pour identifier l'hôtel,static pour qu'il soit autoincrémenté
        private int nbr_étoiles; //pour connaitre la catégorie de l'hôtel
        private bool état; //état pour voir si l'hôtel est plein ou il y'a une disponibilité
        private String nom,adresse,pays,ville,num_tel; // nom de l'hôtel, son adresse, son pays, sa ville, son num_tel
        private List<Chambre> chambres;
        private List<Agence> agences;

        public Hotel()
        {

        }

        public List<Chambre> Chambres
        {
            get
            {
                return chambres;
            }

            set
            {
                chambres = value;
            }
        }

        public List<Agence> Agences
        {
            get
            {
                return agences;
            }

            set
            {
                agences = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public int Nbr_étoiles
        {
            get
            {
                return nbr_étoiles;
            }

            set
            {
                nbr_étoiles = value;
            }
        }

        public bool État
        {
            get
            {
                return état;
            }

            set
            {
                état = value;
            }
        }

        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }

        public string Adresse
        {
            get
            {
                return adresse;
            }

            set
            {
                adresse = value;
            }
        }

        public string Pays
        {
            get
            {
                return pays;
            }

            set
            {
                pays = value;
            }
        }

        public string Ville
        {
            get
            {
                return ville;
            }

            set
            {
                ville = value;
            }
        }

        public string Num_tel
        {
            get
            {
                return num_tel;
            }

            set
            {
                num_tel = value;
            }
        }

        public Hotel (Hotel hotel,List<Chambre> chambres)
        {
            this.Nbr_étoiles = hotel.Nbr_étoiles;
            this.État = hotel.État;
            this.Nom = hotel.Nom;
            this.Adresse = hotel.Adresse;
            this.Pays = hotel.Pays;
            this.Ville = hotel.Ville;
            this.Num_tel = hotel.Num_tel;
            this.Chambres = chambres;
        }
        public Hotel(Hotel hotel, List<Agence> agences)
        {
            this.Nbr_étoiles = hotel.Nbr_étoiles;
            this.État = hotel.État;
            this.Nom = hotel.Nom;
            this.Adresse = hotel.Adresse;
            this.Pays = hotel.Pays;
            this.Ville = hotel.Ville;
            this.Num_tel = hotel.Num_tel;
            this.Chambres = chambres;
        }
        public Hotel(int nbr_étoiles, bool état, string nom, string adresse, string pays, string ville, string num_tel, List<Chambre> chambres)
        {
            this.Id++;
            this.Nbr_étoiles = nbr_étoiles;
            this.État = état;
            this.Nom = nom;
            this.Adresse = adresse;
            this.Pays = pays;
            this.Ville = ville;
            this.Num_tel = num_tel;
            this.Chambres = chambres;
        }
        public void addChambre(Chambre chambre)
        {
            Chambres.Add(chambre);
        }

        public void addAgence(Agence agence)
        {
            Agences.Add(agence);
        }

        /*Non utilisée jusqu'à maintenant
        public bool etat(DateTime checkIn,DateTime checkOut)
        {
            foreach (Chambre chambre in Chambres){
                if (chambre.estDisponible(checkIn,checkOut))
                {
                    return true;
                }
            }
            return false;
        }*/
        public List<Chambre> chambresDispo(DateTime cin,DateTime cout, int prixMin,int prixMax, int nbrLits)
        { List<Chambre> chambresDispo=new List<Chambre>();
            foreach (Chambre ch in chambres)
            {   if (ch.estDisponible(cin,cout))
                    if (ch.Prix >= prixMin && ch.Prix <= prixMax) 
                    {
                        if (ch.Nbr_lits >= nbrLits) 
                            { 
                                chambresDispo.Add(ch);
                            }
                    }
            }
            return chambresDispo;
        }
    }
}