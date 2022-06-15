using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet1.Data
{
    internal class Contient
    {
        [Key]
        public int id_contient { get; set; }

        public int qte { get; set; }

        public int num_com { get; set; }

        public int code_plat { get; set; }

        public Contient()
        {

        }

        public Contient(int id_contient, int qte, int num_com, int code_plat)
        {
            this.id_contient = id_contient;
            this.qte = qte;
            this.num_com = num_com;
            this.code_plat = code_plat;
        }
    }
}
