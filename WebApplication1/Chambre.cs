using System;
using System.Collections.Generic;

namespace WebApplication1
{
    public class Chambre
    {
        private int numero, etage, nbr_lits,prix;
        private Boolean etat;
        private String type;
        private List<Reservation> resarvations;
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

        public bool Etat
        {
            get
            {
                return etat;
            }

            set
            {
                etat = value;
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

        public Chambre(int numero, int etage, int nbr_lits, int prix, bool etat, string type)
        {
            this.Numero = numero;
            this.Etage = etage;
            this.Nbr_lits = nbr_lits;
            this.Prix = prix;
            this.Etat = etat;
            this.Type = type;
        }
    }
}