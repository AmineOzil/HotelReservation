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



        public Chambre(int numero, int etage, string type, int nbr_lits, int prix)
        {
            this.numero = numero;
            this.etage = etage;
            this.type = type;
            this.nbr_lits = nbr_lits;
            this.prix = prix;
        }

        public Boolean estDisponible(DateTime checkIn, DateTime checkOut)
        {
            Boolean res = false;
            reservations = new List<Reservation>();
            for (int i = 0; i < reservations.Count; i++)
            {
                if (checkIn < reservations[i].CheckIn)
                {
                    if (checkIn < reservations[i].CheckOut)
                    {
                        if (checkOut < reservations[i].CheckOut)
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

        public int Numero
        {
            get => numero;
            set => numero = value;
        }
        public int etage
        {
            get => etage;
            set => etage = value;
        }
        public string Type
        {
            get => type;
            set => type = value;
        }
        public int Nbr_lits
        {
            get => nbr_lits;
            set => nbr_lits = value;
        }
        public int Prix
        {
            get => prix;
            set => prix = value;
        }
        public List<Reservation> Reservations
        {
            get => reservations;
            set => reservations = value;
        }
    }
}