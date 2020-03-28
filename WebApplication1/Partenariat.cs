using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Partenariat
    {
        private int id_agence, id_hotel;
        private double pourcentage;
        private int id_partenariat;
        private static int compteur=0;

        public Partenariat()
        {

        }
        public Partenariat(int id_agence, int id_hotel, double pourcentage)
        {
            this.Compteur++;
            this.Id_partenariat = this.Compteur;
            this.Id_agence = id_agence;
            this.Id_hotel = id_hotel;
            this.Pourcentage = pourcentage;
        }

        public int Id_agence
        {
            get
            {
                return id_agence;
            }

            set
            {
                id_agence = value;
            }
        }

        public int Id_hotel
        {
            get
            {
                return id_hotel;
            }

            set
            {
                id_hotel = value;
            }
        }

        public int Compteur
        {
            get
            {
                return compteur;
            }

            set
            {
                compteur = value;
            }
        }

        public double Pourcentage
        {
            get
            {
                return pourcentage;
            }

            set
            {
                pourcentage = value;
            }
        }

        public int Id_partenariat
        {
            get
            {
                return id_partenariat;
            }

            set
            {
                id_partenariat = value;
            }
        }
    }
}