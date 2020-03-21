using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Client
    {
        private String nom, prenom, numPasseport,num_tel;
        private DateTime date_naissance;
        private CarteCredit carte;

        public Client()
        {

        }
        public Client(string nom, string prenom, string numPasseport, string num_tel, DateTime date_naissance,CarteCredit carte)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.NumPasseport = numPasseport;
            this.Num_tel = num_tel;
            this.Date_naissance = date_naissance;
            this.Carte = carte;
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

        public string Prenom
        {
            get
            {
                return prenom;
            }

            set
            {
                prenom = value;
            }
        }

        public string NumPasseport
        {
            get
            {
                return numPasseport;
            }

            set
            {
                numPasseport = value;
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

        public DateTime Date_naissance
        {
            get
            {
                return date_naissance;
            }

            set
            {
                date_naissance = value;
            }
        }

        public CarteCredit Carte
        {
            get
            {
                return carte;
            }

            set
            {
                carte = value;
            }
        }
    }
}