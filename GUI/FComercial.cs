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


namespace gestpro
{
    public partial class FComercial : Form
    {
        public FComercial()
        {
            InitializeComponent();

        }
        public SqlConnection con = //connection here ;
        public void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from CLIENT";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            advancedDataGridView1.DataSource = dt;
            con.Close();


        }

        private void FCOMERCIAL_Load(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }



        private void advancedDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            bindingSource1 = new BindingSource();
            bindingSource1.DataSource = this.gestProDBDataSet.CLIENT;
            bindingSource1.Filter = "NOM_CLT like '" + textBox1.Text + "%'";
            advancedDataGridView1.DataSource = bindingSource1.DataSource;
        }

        private void FComercial_Load_1(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestProDBDataSet.CLIENT'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.cLIENTTableAdapter.Fill(this.gestProDBDataSet.CLIENT);
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
        }

        private void advancedDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = advancedDataGridView1.Rows[e.RowIndex];
                int id = Convert.ToInt32(row.Cells["ID_CLT"].Value);
                Fmodifclient fmodifclient = new Fmodifclient(id);
                fmodifclient.ShowDialog();



            }
        }

        private void AJOUTER_Click(object sender, EventArgs e)
        {
            if (advancedDataGridView1.CurrentRow.Index>= 0)
            {
              
                int id = Convert.ToInt32(advancedDataGridView1.CurrentRow.Cells["ID_CLT"].Value);
                Fmodifclient fmodifclient = new Fmodifclient(id);
                _ = fmodifclient.ShowDialog();
            
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            disp_data();

            
        }

        private void FComercial_HelpButtonClicked(object sender, CancelEventArgs e)
        {

        }

        private void FComercial_FormClosing(object sender, FormClosingEventArgs e)
        {
            Fprincipale fprincipale = new Fprincipale();
            fprincipale.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fregldirect fregldirect = new Fregldirect();
            fregldirect.Show();
        }
    }
}