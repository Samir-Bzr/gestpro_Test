using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraReports.UI;
using System.Windows.Forms;

namespace gestpro
{
    public partial class Fprincipale : Form
    {
        public Fprincipale()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FComercial fComercial = new FComercial();   
            fComercial.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FFOURNIS fFOURNIS= new FFOURNIS();
            fFOURNIS.Show();
        }

        private void Fprincipale_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void Fprincipale_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fcreationbl fcreationbl = new Fcreationbl();
            fcreationbl.Show();
        }

        private void PANCOMMERCE_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fstock fstock = new Fstock();
            fstock.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ETATCLIENT eTATCLIENT = new ETATCLIENT();
            eTATCLIENT.ShowPreview();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ETATFOUR eTATFOUR = new ETATFOUR();
            eTATFOUR.ShowPreview();
        }
    }

}
