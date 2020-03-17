using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Reservation
    {
        private int id;
        private DateTime checkIn;
        private DateTime checkOut;
        private int prix_res;
        private int id_client;

        public Reservation(int id, DateTime checkIn, DateTime checkOut, int prix_res, int id_client)
        {
            this.id = id;
            this.checkIn = checkIn;
            this.checkOut = checkOut;
            this.prix_res = prix_res;
            this.id_client = id_client;
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

        public int Id_client
        {
            get
            {
                return id_client;
            }

            set
            {
                id_client = value;
            }
        }
    }
}