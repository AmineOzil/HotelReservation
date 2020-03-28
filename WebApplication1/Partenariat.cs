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
        private static int id_partenariat=0;

        public Partenariat()
        {

        }
        public Partenariat(int id_agence, int id_hotel, double pourcentage)
        {
            this.Id_partenariat++;
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

        public int Id_partenariat
        {
            get
            {
                return Id_partenariat;
            }

            set
            {
                Id_partenariat = value;
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

        public static int Id_partenariat1
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