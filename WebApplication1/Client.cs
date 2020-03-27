using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Client
    {
        private String nom, prenom, numPasseport,num_tel,id,mdp;
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

        public override bool Equals(object c)
        {
            if (c == null)
                return false;

            Client client = c as Client;

            return this.id.Equals(client.id) && this.mdp.Equals(client.mdp);
        }

        public override string ToString()
        {
            string result = "";
            result += "nom : " + this.nom + Environment.NewLine;
            result += "id : " + this.id + Environment.NewLine;
            result += "mdp : " + this.mdp + Environment.NewLine;

            return result;
        }

        public string Id
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

        private string _mdp;
        public string Mdp
        {
            get
            {
                return mdp;
            }
            set
            {
                mdp = value;
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