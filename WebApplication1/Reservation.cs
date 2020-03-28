﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Reservation
    {
        private static int compteur=0;
        private int id;
        private DateTime checkIn;
        private DateTime checkOut;
        private int prix_res;
        private Client client;

        public Reservation()
        {

        }

        public Reservation(DateTime checkIn, DateTime checkOut, int prix_res, Client client)
        {
            this.Compteur++;
            this.Id = this.Compteur;
            this.checkIn = checkIn;
            this.checkOut = checkOut;
            this.prix_res = prix_res;
            this.Client = client;
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
        public DateTime CheckIn
        {
            get
            {
                return checkIn;
            }

            set
            {
                checkIn = value;
            }
        }

        public DateTime CheckOut
        {
            get
            {
                return checkOut;
            }

            set
            {
                checkOut = value;
            }
        }

        public int Prix_res
        {
            get
            {
                return prix_res;
            }

            set
            {
                prix_res = value;
            }
        }

        public Client Client
        {
            get
            {
                return client;
            }

            set
            {
                client = value;
            }
        }

        
    }
}