using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet1.Data
{
    internal class Plat
    {
        [Key]
        public int code_plat { get; set; }

        public string libelle { get; set; }

        public string type_plat { get; set; }

        public float prix { get; set; }

        public Plat()
        {

        }

        public Plat(int code_plat, string libelle, string type_plat, float prix)
        {
            this.code_plat = code_plat;
            this.libelle = libelle;
            this.type_plat = type_plat;
            this.prix = prix;

        }

        public Plat GetPlat(string libelle)
        {
            DB db = new DB();
            List<Plat> plt = db.Plats.ToList();
            foreach (Plat p in plt)
            {
                if (p.libelle == libelle)
                {
                    return p;
                }
            }

            return null;
        }
    }
}
