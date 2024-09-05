using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zuby.ADGV;

namespace gestpro
{
    public partial class FFOURNIS : Form
    {
        public FFOURNIS()
        {
            InitializeComponent();
        }
        public SqlConnection con = //connection here ;
        public void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from FOURNISSEUR";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            fOURNISSEURBindingSource.DataSource = dt;
            dataGridView1.DataSource = fOURNISSEURBindingSource;
            con.Close();


        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void FFOURNIS_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestProDBDataSet3.FOURNISSEUR'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.fOURNISSEURTableAdapter.Fill(this.gestProDBDataSet3.FOURNISSEUR);
            // TODO: cette ligne de code charge les données dans la table 'gestProDBDataSet3.FOURNISSEUR'. Vous pouvez la déplacer ou la supprimer selon les besoins.

            // TODO: cette ligne de code charge les données dans la table 'gestProDBDataSet2.FOURNISSEUR'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            disp_data();


        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void FFOURNIS_FormClosed(object sender, FormClosedEventArgs e)
        {
            Fprincipale fprincipale = new Fprincipale();
            fprincipale.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            fOURNISSEURBindingSource= new BindingSource();
            fOURNISSEURBindingSource.DataSource = this.gestProDBDataSet3.FOURNISSEUR;
            fOURNISSEURBindingSource.Filter = "NOM_FRS like '" + textBox1.Text + "%'";
            dataGridView1.DataSource = fOURNISSEURBindingSource.DataSource;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            disp_data();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Index >= 0)
            {

                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID_FRS"].Value);
                Fmodiffour fmodiffour = new Fmodiffour(id);
                fmodiffour.ShowDialog();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index >= 0)
            {

                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID_FRS" ].Value);
                Fmodiffour fmodiffour = new Fmodiffour(id);
                fmodiffour.ShowDialog();

            }
        }
    }
}
