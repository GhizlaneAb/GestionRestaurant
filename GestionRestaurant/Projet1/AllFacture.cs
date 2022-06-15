using CrystalDecisions.CrystalReports.Engine;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet1
{
    public partial class AllFacture : Form
    {
        public AllFacture()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            DataSet1 ds = new DataSet1();
            string cs = "Server=localhost;Port=5432;User Id=postgres;Password=postgres;Database=Restaurant;";
            try
            {
                NpgsqlConnection objConn = new NpgsqlConnection(cs);
                objConn.Open();
                string strSelectCmd = "select * from commande";
                NpgsqlDataAdapter objDataAdapter = new NpgsqlDataAdapter(strSelectCmd, objConn);
                objDataAdapter.Fill(ds.commande);
                string strSelectCmd1 = "select * from contient";
                objDataAdapter = new NpgsqlDataAdapter(strSelectCmd1, objConn);
                objDataAdapter.Fill(ds.contient);
                string strSelectCmd2 = "select * from plat";
                objDataAdapter = new NpgsqlDataAdapter(strSelectCmd2, objConn);
                objDataAdapter.Fill(ds.plat);
                objConn.Close();

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CrystalReportCmd cr = new CrystalReportCmd();
            cr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cr;
        
    }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AcceuilForm f1 = new AcceuilForm();
            f1.Show();
        }
    }
}
