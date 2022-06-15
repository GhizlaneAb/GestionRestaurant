using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1
{
    public partial class AcceuilForm : Form
    {

        public AcceuilForm()
        {
            InitializeComponent();
        }

        private void Restaurant_Load(object sender, EventArgs e)
        {
            

            pictureBox1.Visible = true;
            pictureBox3.Visible = false;
            pictureBox2.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == true)
            {
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
            }
            else if (pictureBox2.Visible == true)
            {
                pictureBox3.Visible = true;
                pictureBox2.Visible = false;
                pictureBox4.Visible = false;
                pictureBox1.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
            }
            else if (pictureBox3.Visible == true)
            {
                pictureBox4.Visible = true;
                pictureBox3.Visible = false;
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
            }
            else if (pictureBox4.Visible == true)
            {
                pictureBox5.Visible = true;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;
                pictureBox6.Visible = false;
            }
            else if (pictureBox5.Visible == true)
            {
                pictureBox6.Visible = true;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;
                pictureBox5.Visible = false;
            }
            else 
            {
                pictureBox1.Visible = true;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox2.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == true)
            {
                pictureBox6.Visible = true;
                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
                pictureBox2.Visible = false;
                pictureBox5.Visible = false;
                pictureBox4.Visible = false;
            }
            else if (pictureBox2.Visible == true)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox4.Visible = false;
                pictureBox3.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
            }
            else if (pictureBox3.Visible == true)
            {
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox1.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
            }
            else if (pictureBox4.Visible == true)
            {
                pictureBox3.Visible = true;
                pictureBox1.Visible = false;
                pictureBox4.Visible = false;
                pictureBox2.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
            }
            else if (pictureBox5.Visible == true)
            {
                pictureBox4.Visible = true;
                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
                pictureBox2.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
            }
            else 
            {
                pictureBox5.Visible = true;
                pictureBox1.Visible = false;
                pictureBox4.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox6.Visible = false;
            }

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            TableCRUD f1 = new TableCRUD();
            f1.Show();

        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ServeurCRUD f1 = new ServeurCRUD();
            f1.Show();
        }

        private void toolStripTextBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlatCRUD f1 = new PlatCRUD();
            f1.Show();
        }

        private void toolStripTextBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            CommandeForm f1 = new CommandeForm();
            f1.Show();
        }

        private void tousLesFacturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllFacture f1 = new AllFacture();
            f1.Show();
        }
    }
}
