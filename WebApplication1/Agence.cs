using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Agence
    {
        private static int id;
        private String nom;
        private String username;
        private String password;
        private String pays;

        public int Id
        {
            get
            {
                return Id;
            }

            set
            {
                Id = value;
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

        public static int Id1
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

        public Agence(String nom, String username, String password, String pays)
        {
            this.Id++;
            this.Nom = nom;
            this.Username = username;
            this.Password = password;
            this.Pays = pays;
           
        }
        public Agence()
        {

        }

        /*private static List<Inscrit> inscrits = new List<Inscrit>();
        private static List<Agence> agences = new List<Agence>();

        public void initialise()
        {

            ajoutInscrit(new Inscrit("Amin", "abcd"));
            ajoutInscrit(new Inscrit("Nassim", "1234"));
            ajoutInscrit(new Inscrit("Anes", "0000"));

            agences.Add(new Agence("AG1001", "ENOVBM", "enovbm2020", "pass1001", "Espagne"));
            agences.Add(new Agence("AG1002", "PLATINIUM", "platinium2020", "pass1002", "Italie"));
            
        }

        public void ajoutInscrit(Inscrit i)
        {
            inscrits.Add(i);
            Console.WriteLine(i.nom + " est maintenant inscrit à l'agence");
        }

        
        public Inscrit authentificationInscrit(string id, string mdp)
        {
            foreach (Inscrit c in inscrits)
            {
                if (object.Equals(c.id,id) && object.Equals(c.mdp, mdp))
                {
                    return c;
                }
            }
            return null;
        }
*/


    }
}