using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraReports.UI;

namespace gestpro
{
    public partial class Fcreationbl : Form
    {
        public Fcreationbl()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(//connection here +
            //connection here );

        public void disp_data()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from BON_LIVRAISON";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();


        }
        private void PrintReport(int id)
        {
            // Create an instance of your report
            var newbonval = new newbonval();
            string a = @"SELECT
    BL.*, 
    DB.*, 
    ST.*, 
    CL.*, 
    DS.*
FROM
    DETAIL_BL AS DB
    INNER JOIN BON_LIVRAISON AS BL ON BL.ID_BL = DB.ID_BL
    INNER JOIN STKPRDFINI AS ST ON DB.RefArtFini = ST.RefArtFini
    INNER JOIN CLIENT AS CL ON BL.ID_CLT = CL.ID_CLT
    CROSS JOIN DOSSIER AS DS
WHERE
    DB.ID_BL = @ID_BL

"; 


                using (SqlCommand cmd = new SqlCommand(a, connection))
                {
                    cmd.Parameters.AddWithValue("@ID_BL", id);
                    connection.Open();
                    
                    SqlDataAdapter q = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    q.Fill(dt);
                    cmd.ExecuteNonQuery();
                    newbonval.DataSource = dt;

                    connection.Close();



                    // Optionally configure other report settings here

                    // Print the report
                    newbonval.ShowPreview();
                }
            
        }
     








        private void Fcreationbl_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestProDBDataSet2.BON_LIVRAISON'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.bON_LIVRAISONTableAdapter.Fill(this.gestProDBDataSet2.BON_LIVRAISON);
            disp_data();
          
           
            label1.BackColor = Color.Transparent;
            connection.Open();
            SqlCommand Q = new SqlCommand(" SELECT IsINVOICED from BON_LIVRAISON ",connection);
            object result = Q.ExecuteScalar();
            int isinv = result != DBNull.Value ? Convert.ToInt32(result) : 0;
            if (isinv == 0) { dataGridView1.CurrentRow.Cells["STATUS"].Value = ""; }
            else { dataGridView1.CurrentRow.Cells["STATUS"].Value = "Facturé"; }
            connection.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            disp_data();

        }



        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            int newBlId = 0;


            {
                connection.Open();

                // Get the next ID value
                using (SqlCommand getIdCommand = new SqlCommand("SELECT ISNULL(MAX(ID_BL), 0) + 1 FROM BON_LIVRAISON", connection))
                {
                    newBlId = (int)getIdCommand.ExecuteScalar();
                }

                // Open the new form and pass the new ID
                using (Fcrebnliv fcrebnliv = new Fcrebnliv(newBlId))
                {
                    // Show the form as a dialog to hold the main form
                    fcrebnliv.ShowDialog();
                }
            }
        }


        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("etes vous sure de vouloir supprimer", "Supprimer", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string a = @"DELETE FROM [dbo].[BON_LIVRAISON] WHERE ID_BL = '" + dataGridView1.CurrentRow.Cells["ID_BL"].Value.ToString() + "'";
                SqlCommand cmd = new SqlCommand(a, connection);
                connection.Open();
                cmd.ExecuteNonQuery();

                connection.Close();

                disp_data();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index >= 0)
            {

                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID_BL"].Value);
                Fcrebnliv fcrebnliv = new Fcrebnliv(id);
                _ = fcrebnliv.ShowDialog();

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                bONLIVRAISONBindingSource = new BindingSource();
                bONLIVRAISONBindingSource.DataSource = this.gestProDBDataSet2.BON_LIVRAISON;
                bONLIVRAISONBindingSource.Filter = " ID_BL ='" + Convert.ToInt32(textBox1.Text) + "'";
                dataGridView1.DataSource = bONLIVRAISONBindingSource.DataSource;
            }
            else { bONLIVRAISONBindingSource.RemoveFilter(); }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID_BL"].Value);
            PrintReport(a);

        }

        private void Fcreationbl_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Fprincipale fprincipale = new Fprincipale();
            fprincipale.Show();
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}


