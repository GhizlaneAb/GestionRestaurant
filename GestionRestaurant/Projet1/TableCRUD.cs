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
    public partial class TableCRUD : Form
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
        public TableCRUD()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            Table tab = db.Tables.Find(Convert.ToInt32(textBox1.Text));
            tab.num_tab = Convert.ToInt32(textBox1.Text);
            tab.nb_place = Convert.ToInt32(textBox2.Text);

            db.SaveChanges();
            dataGridView1.DataSource = db.Tables.ToList();
            MessageBox.Show("Bien Modifier");

        }

        private void button3_Click(object sender, EventArgs e)
        {

            DB db = new DB();
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("SVP Entrez le numero de la table !");
            }
            else
            {
                db.Tables.Remove(db.Tables.Find(Convert.ToInt32(textBox1.Text)));
                db.SaveChanges();
                dataGridView1.DataSource = db.Tables.ToList();
                MessageBox.Show("Bien Supprimer");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            if(String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("SVP Entrez tous les champs !");
            }
            else { 
            Table tab = new Table();
            tab.num_tab = Convert.ToInt32(textBox1.Text);
            tab.nb_place = Convert.ToInt32(textBox2.Text);

            db.Tables.Add(tab);
            db.SaveChanges();
            dataGridView1.DataSource = db.Tables.ToList();
            MessageBox.Show("Bien Ajouter");
            }
        }

        private void TableCrud_Load(object sender, EventArgs e)
        {
            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 30, 30));
            button2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button2.Width, button2.Height, 30, 30));
            button3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button3.Width, button3.Height, 30, 30));

            DB db = new DB();
            dataGridView1.DataSource = db.Tables.ToList();

          /*  int id = db.Tables.ToList().LastOrDefault<Table>().num_tab;
            id += 1;
            textBox1.Text = id.ToString();*/
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AcceuilForm f1 = new AcceuilForm();
            f1.Show();
            this.Close();
        }

    }
}
