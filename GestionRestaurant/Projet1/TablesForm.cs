using Projet1.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1
{
    public partial class TablesForm : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
               int nleft,
               int nTop,
               int nRight,
               int nBottom,
               int nWidthEllipse,
               int nHeightEllipse


               );

        public TablesForm()
        {
            InitializeComponent();
        }

        private void TablesForm_Load(object sender, EventArgs e)
        {
            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 30, 30));
            button2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button2.Width, button2.Height, 30, 30));
            button3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button3.Width, button3.Height, 30, 30));
            DB db = new DB();
           comboBox1.DataSource=db.Tables.Select(i=> i.num_tab).ToList();
           List <string> nom= db.Serveurs.Select(i => i.nom).ToList();
           List<string> prenom = db.Serveurs.Select(i => i.prenom).ToList();
            // comboBox2.DataSource = db.Serveurs.Select(i => new {i.nom, i.prenom }).ToList();
            comboBox2.DataSource =nom.Zip(prenom, (first, second) => first + " " + second).ToList();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            List<Affecter> aff = db.Affecters.ToList();
            Serveur s = new Serveur();
            FileStream fParameter = new FileStream("C:/Users/i/source/repos/Projet1/file.txt", FileMode.Append, FileAccess.Write);
            StreamWriter m_WriterParameter = new StreamWriter(fParameter);
            m_WriterParameter.BaseStream.Seek(0, SeekOrigin.End);
            
            foreach(Affecter affecter in aff) {
                m_WriterParameter.Write("Serveur : " + s.GetServeur(affecter.num_serv).nom + " " + s.GetServeur(affecter.num_serv).nom + " ");
                m_WriterParameter.Write(" Numero de la table : " + affecter.num_tab + " ");
                m_WriterParameter.Write(" Date d'affectation : " +affecter.date_affect);
                m_WriterParameter.Write("\n");
            }
            m_WriterParameter.Write("\n ********************************************* \n");
            m_WriterParameter.Flush();
            m_WriterParameter.Close();

            MessageBox.Show("Bien Sauvegarder");

        }


        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.Affecters.RemoveRange(db.Affecters);
            db.SaveChanges();
            MessageBox.Show("Bien Supprimer");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            if (String.IsNullOrEmpty(comboBox1.Text) || String.IsNullOrEmpty(comboBox2.Text))
            {
                MessageBox.Show("SVP Entrez tous les champs !");
            }
            else
            {
                Affecter aff = new Affecter();
                aff.num_tab = Convert.ToInt32(comboBox1.Text);
                Serveur s = new Serveur();
                string[] names = comboBox2.Text.Split(' ');
                aff.num_serv = s.GetServeurByNom(names[0], names[1]).num_serv;
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "yyyy-MM-dd hh:mm:ss tt ";
                dateTimePicker1.ShowUpDown = true;
                aff.date_affect = dateTimePicker1.Value;

                db.Affecters.Add(aff);
                db.SaveChanges();
                MessageBox.Show("Bien Ajouter");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ServeurCRUD f1 = new ServeurCRUD();
            f1.Show();
            this.Close();
        }

      
    }
}
