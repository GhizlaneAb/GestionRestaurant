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
    public partial class CommandeForm : Form
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

        public static int num_cmd;

        public CommandeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox3.Text) || String.IsNullOrEmpty(textBox4.Text) || String.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("SVP Entrez tous les champs !");
            }
            else
            {
                Commande cmd = new Commande();
                cmd.num_tab = Convert.ToInt32(textBox1.Text);
                cmd.mode_pay = comboBox1.Text;
                cmd.nb_pers = Convert.ToInt32(textBox3.Text);
                cmd.date_com = DateTime.Now;
                cmd.heure_pay = textBox4.Text;

                db.Commandes.Add(cmd);
                db.SaveChanges();

                num_cmd = cmd.num_com;

                this.Hide();
                ArticlesForm f1 = new ArticlesForm();
                f1.Show();
            }
        }

        private void CommandeForm_Load(object sender, EventArgs e)
        {

            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 30, 30));
            

            List<string> mode_pay = new List<string>() { "Espèces", "Cartes bancaires", "Chèque" };

            foreach(string m in mode_pay)
            {
                comboBox1.Items.Add(m);
            }
            textBox4.Text=DateTime.Now.ToString("HH:mm");
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
