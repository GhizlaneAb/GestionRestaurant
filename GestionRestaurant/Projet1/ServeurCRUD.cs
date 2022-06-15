using Projet1.Data;
using System;
using System.Linq;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Projet1
{
    public partial class ServeurCRUD : Form
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

        public ServeurCRUD()
        {
            InitializeComponent();
        }

        private void ServeurCRUD_Load(object sender, EventArgs e)
        {
            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 30, 30));
            button2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button2.Width, button2.Height, 30, 30));
            button3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button3.Width, button3.Height, 30, 30));
            button4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button4.Width, button4.Height, 30, 30));
           
            DB db = new DB();
            dataGridView1.DataSource = db.Serveurs.ToList();
/*
               int id = db.Serveurs.ToList().LastOrDefault<Serveur>().num_serv;
                id += 1;
                textBox1.Text = id.ToString();*/

        }

        //Ajouter un serveur
        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("SVP Entrez tous les champs !");
            }
            else
            {
                Serveur srv = new Serveur();
                srv.num_serv = Convert.ToInt32(textBox1.Text);
                srv.nom = textBox2.Text;
                srv.prenom = textBox3.Text;

                db.Serveurs.Add(srv);
                db.SaveChanges();
                dataGridView1.DataSource = db.Serveurs.ToList();
                MessageBox.Show("Bien Ajouter");
            }
        }

        //Modifier un serveur
        private void button2_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            Serveur srv = db.Serveurs.Find(Convert.ToInt32(textBox1.Text));
            srv.nom = textBox2.Text;
            srv.prenom = textBox3.Text;
            db.SaveChanges();

            dataGridView1.DataSource = db.Serveurs.ToList();
            MessageBox.Show("Bien Modifier");
        }

        //Supprimer un serveur
        private void button3_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("SVP Entrez le numero de serveur !");
            }
            else
            {
                db.Serveurs.Remove(db.Serveurs.Find(Convert.ToInt32(textBox1.Text)));
                db.SaveChanges();
                dataGridView1.DataSource = db.Serveurs.ToList();
                MessageBox.Show("Bien Supprimer");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AcceuilForm f1 = new AcceuilForm();
            f1.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            TablesForm f1 = new TablesForm();
            f1.Show();
            this.Close();
        }
    }
}
