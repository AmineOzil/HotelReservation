using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Reservation
    {
        private static int id;
        private DateTime checkIn;
        private DateTime checkOut;
        private int prix_res;
        
        Client client;

        public Reservation()
        {

        }

        public Reservation(DateTime checkIn, DateTime checkOut, int prix_res, Client client)
        {
            this.Id++;
            this.checkIn = checkIn;
            this.checkOut = checkOut;
            this.prix_res = prix_res;
            this.client = client;
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

      
    }
}