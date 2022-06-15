using Projet1.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1.UC
{
    public partial class UcTable : UserControl
    {
        public int Num { get; set; }
        Affecter aff=new Affecter();
        Serveur s = new Serveur();

        public UcTable()
        {
            InitializeComponent();
        }

        private void ucTable_Load(object sender, EventArgs e)
        {
            lbNum.Text = Num.ToString();


        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(aff.GetAffecter(Num) == null)
            {
                MessageBox.Show("Table Num :" + Num + "\n" + "Pas d'affectation");
            }
            else {
                int n = aff.GetAffecter(Num).num_serv;
                MessageBox.Show("Table Num :" + Num + "\n" + "Serveur : " + s.GetServeur(n).nom +" "+ s.GetServeur(n).prenom + " " +  "\n" + "Date Affectation : " + aff.GetAffecter(Num).date_affect);
             }
        }
    
    }
}
