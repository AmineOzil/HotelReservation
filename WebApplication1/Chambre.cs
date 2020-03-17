using System;
using System.Collections.Generic;

namespace WebApplication1
{
    public class Chambre
    {
        private int numero;
        private int etage;
        private String type;
        private int nbr_lits;
        private int prix;
        private List<Reservation> reservations;

        public int Numero
        {
            get
            {
                return numero;
            }

            set
            {
                numero = value;
            }
        }

        public int Etage
        {
            get
            {
                return etage;
            }

            set
            {
                etage = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public int Nbr_lits
        {
            get
            {
                return nbr_lits;
            }

            set
            {
                nbr_lits = value;
            }
        }

        public int Prix
        {
            get
            {
                return prix;
            }

            set
            {
                prix = value;
            }
        }

        public List<Reservation> Reservations
        {
            get
            {
                return reservations;
            }

            set
            {
                reservations = value;
            }
        }

        public Chambre(int numero, int etage, string type, int nbr_lits, int prix)
        {
            this.Numero = numero;
            this.Etage = etage;
            this.Type = type;
            this.Nbr_lits = nbr_lits;
            this.Prix = prix;
        }

        public Boolean estDisponible(DateTime checkIn, DateTime checkOut)
        {
            Boolean res = false;
            Reservations = new List<Reservation>();
            for (int i = 0; i < Reservations.Count; i++)
            {
                if (checkIn < Reservations[i].checkIn)
                {
                    if (checkIn < Reservations[i].checkOut)
                    {
                        if (checkOut < Reservations[i].checkOut)
                        {
                            res = true;
                            return res;
                        }
                        else
                        {
                            return res;
                        }
                    }
                    else
                    {
                        return res;
                    }
                }
                else
                {
                    res = true;
                    return res;
                }

            }
            return res;

        }

    }
}