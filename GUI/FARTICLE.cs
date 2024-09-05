using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace gestpro
{
    public partial class Fstock : Form
    {
        public Fstock()
        {
            InitializeComponent();
        }
        string connectionstring = (//connection here +
            //connection here );
        public void disp_data()
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                SqlCommand j = new SqlCommand(@"SELECT * FROM STKPRDFINI", connection);
                SqlDataAdapter w = new SqlDataAdapter(j);
                DataTable dt = new DataTable();
                w.Fill(dt);
                dataGridView1.DataSource = dt;



                connection.Close();
            }
        }
        private void FARTICLE_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestProDBDataSet2.STKPRDFINI'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.sTKPRDFINITableAdapter.Fill(this.gestProDBDataSet2.STKPRDFINI);

            disp_data();
            }

        private void Fstock_FormClosed(object sender, FormClosedEventArgs e)
        {
            Fprincipale fprincipale = new Fprincipale();
            fprincipale.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (desi.Text != "")
            {
                sTKPRDFINIBindingSource = new BindingSource();
                sTKPRDFINIBindingSource.DataSource = this.gestProDBDataSet2.STKPRDFINI;
                sTKPRDFINIBindingSource.Filter = $"Designation LIKE '%{desi.Text}%'";
                dataGridView1.DataSource = sTKPRDFINIBindingSource.DataSource;
                
            }
            else
            {
                sTKPRDFINIBindingSource.RemoveFilter();
               
            }
        }

        private void refer_TextChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                t3.Text = row.Cells["PUAchat"].Value != null ? row.Cells["PUAchat"].Value.ToString() : string.Empty;
                t2.Text = row.Cells["QteStock"].Value != null ? row.Cells["QteStock"].Value.ToString() : string.Empty;
                t1.Text = row.Cells["Designation"].Value != null ? row.Cells["Designation"].Value.ToString() : string.Empty;
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        { if (t4.Text != "")
            {
                string a = @"update STKPRDFINI set PUVente=@pu where( RefArtFini=@ref)";
                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    using (SqlCommand q = new SqlCommand(a, con))
                    {
                        con.Open();
                            q.Parameters.AddWithValue("@pu", t4.Text);
                        q.Parameters.AddWithValue("@ref", dataGridView1.CurrentRow.Cells["RefArtFini"].Value.ToString());
                        q.ExecuteNonQuery();
                        con.Close();
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            disp_data();
        }
    }
}
