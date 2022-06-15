using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet1.Data
{
    internal class Serveur
    {
        [Key]
        public int num_serv { get; set; }

        public string nom { get; set; }

        public string prenom { get; set; }

        public Serveur()
        {

        }

        public Serveur(int num_serv, string nom, string prenom)
        {
            this.num_serv = num_serv;
            this.nom = nom;
            this.prenom = prenom;
        }

        public Serveur GetServeur(int num)
        {
            DB db = new DB();
            List<Serveur> serv = db.Serveurs.ToList();
            foreach (Serveur s in serv)
            {
                if (s.num_serv == num)
                {
                    return s;
                }
            }
            return null;
        }

        public Serveur GetServeurByNom(string nom, string prenom)
        {
            DB db = new DB();
            List<Serveur> serv = db.Serveurs.ToList();
            foreach (Serveur s in serv)
            {
                if (s.nom == nom && s.prenom == prenom)
                {
                    return s;
                }
            }
            return null;

        }
    }
}
