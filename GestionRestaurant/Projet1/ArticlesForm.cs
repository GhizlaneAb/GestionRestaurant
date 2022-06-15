using Projet1.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1
{
    public partial class ArticlesForm : Form
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

        public ArticlesForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox3.Text) || String.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("SVP Entrez tous les champs !");
            }
            else
            {
                Contient ct = new Contient();
                Plat plt = new Plat();
                ct.num_com = Convert.ToInt32(textBox1.Text);
                ct.code_plat = plt.GetPlat(comboBox1.Text).code_plat;
                ct.qte = Convert.ToInt32(textBox3.Text);

                db.Contients.Add(ct);
                db.SaveChanges();
                MessageBox.Show("Le plat a bien été ajouté à la commande : " + ct.num_com);
            }
        }

        private void ArticlesForm_Load(object sender, EventArgs e)
        {

            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 30, 30));
            button2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button2.Width, button2.Height, 30, 30));

            DB db = new DB();
            textBox1.Text = CommandeForm.num_cmd.ToString();
            comboBox1.DataSource=db.Plats.Select(i=> i.libelle).ToList();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AcceuilForm f1 = new AcceuilForm();
            f1.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }
    }
}
