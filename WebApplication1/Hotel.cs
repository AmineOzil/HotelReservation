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


        public Hotel(int id, int nbr_étoiles, bool état, string nom, string adresse, string pays, string ville, string num_tel, List<Chambre> chambres)
        {
            this.Id = id;
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
        public void etat(DateTime checkIn,DateTime checkOut)
        {
            foreach (Chambre chambre in Chambres){
                if (chambre.estDisponible(checkIn,checkOut))
                {
                    État = true;
                    break;
                }
            }
        }
    }
}