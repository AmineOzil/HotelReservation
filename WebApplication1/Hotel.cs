using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Hotel
    {
        private int id, nbr_étoiles; //id pour identifier l'hôtel et nbr_étoiles pour connaitre la catégorie de l'hôtel
        private bool état; //état pour voir si l'hôtel est plein ou il y'a une disponibilité
        private String nom,adresse,pays,ville,num_tel; // nom de l'hôtel, son adresse, son pays, sa ville, son num_tel
        private List<Chambre> chambres;


        public int Nbr_étoiles
        {
            get
            {
                return Nbr_étoiles1;
            }

            set
            {
                Nbr_étoiles1 = value;
            }
        }

        public bool État
        {
            get
            {
                return État1;
            }

            set
            {
                État1 = value;
            }
        }

        public string Nom
        {
            get
            {
                return Nom1;
            }

            set
            {
                Nom1 = value;
            }
        }

        public string Adresse
        {
            get
            {
                return Adresse1;
            }

            set
            {
                Adresse1 = value;
            }
        }

        public string Pays
        {
            get
            {
                return Pays1;
            }

            set
            {
                Pays1 = value;
            }
        }

        public string Ville
        {
            get
            {
                return Ville1;
            }

            set
            {
                Ville1 = value;
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

        public int Nbr_étoiles1
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

        public bool État1
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

        public string Nom1
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

        public string Adresse1
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

        public string Pays1
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

        public string Ville1
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


        public Hotel(int id, int nbr_étoiles, bool état, string nom, string adresse, string pays, string ville, string num_tel, List<Chambre> chambres)
        {
            this.Id = id;
            this.Nbr_étoiles1 = nbr_étoiles;
            this.État1 = état;
            this.Nom1 = nom;
            this.Adresse1 = adresse;
            this.Pays1 = pays;
            this.Ville1 = ville;
            this.Num_tel = num_tel;
            this.Chambres = chambres;
        }
        public void addChambre(Chambre chambre)
        {
            chambres.Add(chambre);
        }
        public void etat(DateTime checkIn,DateTime checkOut)
        {
            foreach (Chambre chambre in chambres){
                if (chambre.estDisponible(checkIn,checkOut))
                {
                    état = true;
                    break;
                }
            }
        }
    }
}