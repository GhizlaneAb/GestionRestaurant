using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet1.Data
{
    internal class Commande
    {
        [Key]
        public int num_com { get; set; }

        public DateTime date_com { get; set; }

        public int nb_pers { get; set; }

        public string heure_pay { get; set; }

        public string mode_pay { get; set; }

        public int num_tab { get; set; }

        public Commande()
        {

        }

        public Commande(int num_com, DateTime date_com, int nb_pers, string heure_pay, string mode_pay, int num_tab)
        {
            this.num_com = num_com;
            this.date_com = date_com;
            this.nb_pers = nb_pers;
            this.heure_pay = heure_pay;
            this.mode_pay = mode_pay;
            this.num_tab = num_tab;
        }
 
    }
}
