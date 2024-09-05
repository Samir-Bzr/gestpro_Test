using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            FBNLIV fBNLIV = new FBNLIV();
            fBNLIV.Show();
        }
    }

}
