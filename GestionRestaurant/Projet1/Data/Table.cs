using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet1.Data
{
    internal class Table
    {
        [Key]
        public int num_tab { get; set; }

        public int nb_place { get; set; }

        public Table(int num_table, int nb_place)
        {
            this.num_tab = num_table;
            this.nb_place = nb_place;
        }

        public Table()
        {

        }

      


    }
}
