using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet1.Data
{
    internal class Affecter
    {
        [Key]
        public int affecter_id { get; set; }

        public DateTime date_affect { get; set; }

        public int num_tab { get; set; }

        public int num_serv { get; set; }

        public Affecter()
        {

        }

        public Affecter(int affecter_id, DateTime date_affect, int num_tab, int num_serv)
        {
            this.affecter_id = affecter_id;
            this.date_affect = date_affect;
            this.num_tab = num_tab;
            this.num_serv = num_serv;

        }

        public Affecter GetAffecter(int num)
        {
            DB db = new DB();
            List<Affecter> affecter = db.Affecters.ToList();
            foreach(Affecter a in affecter){
                if(a.num_tab == num)
                {
                    return a;
                }
            }
            return null;
        }
    }
}
