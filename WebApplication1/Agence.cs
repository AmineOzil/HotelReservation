﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Agence
    {
        private static int compteur;
        private int id;
        private String nom;
        private String username;
        private String password;
        private String pays;

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
        public String Nom
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
        public String Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }
        public String Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }
        public String Pays
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



        public Agence(String nom, String username, String password, String pays)
        {
            this.Compteur++;
            this.Id = this.Compteur;
            this.Nom = nom;
            this.Username = username;
            this.Password = password;
            this.Pays = pays;
           
        }
        public Agence()
        {

        }



    }
}