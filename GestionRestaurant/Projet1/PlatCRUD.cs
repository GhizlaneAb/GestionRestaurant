using Projet1.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Projet1
{ 
    public partial class PlatCRUD : Form
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

        public PlatCRUD()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 30, 30));
            button2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button2.Width, button2.Height, 30, 30));
            button3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button3.Width, button3.Height, 30, 30));
           
            DB db = new DB();
            grd.DataSource = db.Plats.ToList();

          /*    int code = db.Plats.ToList().LastOrDefault<Plat>().code_plat;
              code += 1;
              textBox4.Text = code.ToString();*/

            List<string> type_plat = new List<string>() { "Salade", "Plat principal", "Desserts","Soupes", "Boissons" };

            foreach (string t in type_plat)
            {
                comboBox1.Items.Add(t);
            }

        }

        //Ajouter un plat
        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(comboBox1.Text) || String.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("SVP Entrez tous les champs !");
            }
            else
            {
                Plat plt = new Plat();
                plt.code_plat = Convert.ToInt32(textBox4.Text);
                plt.libelle = textBox1.Text;
                plt.type_plat = comboBox1.Text;
                plt.prix = float.Parse(textBox3.Text);

                db.Plats.Add(plt);
                db.SaveChanges();
                grd.DataSource = db.Plats.ToList();
                MessageBox.Show("Bien Ajouter");
            }
        }

        //Modifier un plat
        private void button2_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            Plat plt = db.Plats.Find(Convert.ToInt32(textBox4.Text));
            plt.libelle = textBox1.Text;
            plt.type_plat = comboBox1.Text;
            plt.prix = float.Parse(textBox3.Text);

            db.SaveChanges();
            grd.DataSource = db.Plats.ToList();
            MessageBox.Show("Bien Modifier");

        }

        //Suprimer un plat
        private void button3_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            if (String.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("SVP Entrez le code du plat !");
            }
            else
            {
                db.Plats.Remove(db.Plats.Find(Convert.ToInt32(textBox4.Text)));
                db.SaveChanges();
                grd.DataSource = db.Plats.ToList();
                MessageBox.Show("Bien Supprimer");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AcceuilForm f1 = new AcceuilForm();
            f1.Show();
            this.Close();
        }

    }
}
