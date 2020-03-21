using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class CarteCredit
    {
        private String num_carte, cvv, type,date_expiration;

        public CarteCredit()
        {

        }
        public CarteCredit(string num_carte, string cvv, string type, String date_expiration)
        {
            this.Num_carte = num_carte;
            this.Cvv = cvv;
            this.Type = type;
            this.Date_expiration = date_expiration;
        }

        public string Num_carte
        {
            get
            {
                return num_carte;
            }

            set
            {
                num_carte = value;
            }
        }

        public string Cvv
        {
            get
            {
                return cvv;
            }

            set
            {
                cvv = value;
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

        public String Date_expiration
        {
            get
            {
                return date_expiration;
            }

            set
            {
                date_expiration = value;
            }
        }
    }
}