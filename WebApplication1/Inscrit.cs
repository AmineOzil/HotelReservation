using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Inscrit : Client
    {
        public Inscrit() { }

        public Inscrit(string nom, string mdp)
        {
            this.nom = nom;
            this.mdp = mdp;
        }
    }
}