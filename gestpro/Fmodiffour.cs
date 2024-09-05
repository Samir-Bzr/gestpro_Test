using DevExpress.DirectX.Common.DirectWrite;
using DevExpress.Xpo;
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

    public partial class Fmodiffour : Form

    {

        private int _id;
        public Fmodiffour(int id)
        {
            InitializeComponent();
            _id = id;
            LoadData();

        }
        public SqlConnection con = new SqlConnection("Data Source=SERVER-ZAOUIA;Initial Catalog=GestProDB;Persist Security Info=True;Us" +
 "er ID=dev01;Password=9988;TrustServerCertificate=True");

        public void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from CLIENT";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();


        }
        public void LoadData()
        {

            string query = "SELECT * FROM FOURNISSEUR WHERE ID_FRS = @id";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@id", _id);
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;

                }
            }
        }
        private void ClearText(Control[] controls)
        {
            foreach (Control control in controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
            }
        }


        private void Fmodiffour_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestProDBDataSet1.FOURNISSEUR'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.fOURNISSEURTableAdapter.Fill(this.gestProDBDataSet1.FOURNISSEUR);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Control[] textboxes = { NOM, NIF, NIS, SOLD, CAT,NAI, RC, MAIL, MOB, TEL, VILLE, ADR };

            ClearText(textboxes);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string a = @"DELETE FROM FOURNISSEUR WHERE ID_FRS = '" + dataGridView1.CurrentCell.Value + "'  ";
            SqlCommand cmd = new SqlCommand(a, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            disp_data();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            disp_data();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = @"INSERT INTO [dbo].[FOURNISSEUR]
           ([NOM_FRS]
           ,[CATEG_FRS]
           ,[ADR_FRS]
           ,[VILLE_FRS]
           ,[TEL_FRS]
           ,[MOBIL_FRS]
           ,[EMAIL_FRS]
           ,[NRC_FRS]
           ,[NIF_FRS]
           ,[NIS_FRS],NAI_FRS
           ,[SOLDE_DETTE]
           ,[DATETIMECREATION])
     VALUES
           ('" + NOM.Text + "','" + CAT.Text + "','" + ADR.Text + "','" + VILLE.Text + "','" + TEL.Text + "','" + MOB.Text + "','" + MAIL.Text + "'" +
         ",'" + RC.Text + "','" + NIF.Text + "','" + NIS.Text + "','" + NAI.Text + "','" + SOLD.Text + "','" + DateTime.Now + "') ";
            SqlCommand cmd = new SqlCommand(a, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            disp_data();


        }

        private void SAVE_Click(object sender, EventArgs e)
        {
            string a = @"UPDATE [dbo].[FOURNISSEUR]
           SET [NOM_FRS] = @nom
      ,[CATEG_FRS] = @cat
      ,[ADR_FRS] = @adr
      ,[VILLE_FRS] = @ville
      ,[TEL_FRS] = @tel
      ,[MOBIL_FRS] =@mob
      ,[EMAIL_FRS] = @mail
      ,[NRC_FRS] = @rc
      ,[NIF_FRS] = @nif
      ,[NIS_FRS] = @nis,NAI_FRS=@NAI
      ,[SOLDE_DETTE] = @sold
      ,[DATETIMECREATION] = @date  ";
            con.Open();
            SqlCommand cmd = new SqlCommand(a, con);
            cmd.Parameters.AddWithValue("@nom", NOM.Text);
            cmd.Parameters.AddWithValue("@cat", CAT.Text);
            cmd.Parameters.AddWithValue("@adr", ADR.Text);
            cmd.Parameters.AddWithValue("@ville", VILLE.Text);
            cmd.Parameters.AddWithValue("@tel", TEL.Text);
            cmd.Parameters.AddWithValue("@mob", MOB.Text);
            cmd.Parameters.AddWithValue("@mail", MAIL.Text);
            cmd.Parameters.AddWithValue("@rc", RC.Text);
            cmd.Parameters.AddWithValue("@nif", NIF.Text);
            cmd.Parameters.AddWithValue("@nis", NIS.Text);
            cmd.Parameters.AddWithValue("@NAI", NAI.Text);
            cmd.Parameters.AddWithValue("@sold", SOLD.Text);
            cmd.Parameters.AddWithValue("@date", DateTime.Now);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the click is on a valid row
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                NOM.Text = row.Cells["NOM_FRS"].Value != null ? row.Cells["NOM_FRS"].Value.ToString() : string.Empty;
                CAT.Text = row.Cells["CATEG_FRS"].Value != null ? row.Cells["CATEG_FRS"].Value.ToString() : string.Empty;
                ADR.Text = row.Cells["ADR_FRS"].Value != null ? row.Cells["ADR_FRS"].Value.ToString() : string.Empty;
                VILLE.Text = row.Cells["VILLE_FRS"].Value != null ? row.Cells["VILLE_FRS"].Value.ToString() : string.Empty;
                TEL.Text = row.Cells["TEL_FRS"].Value != null ? row.Cells["TEL_FRS"].Value.ToString() : string.Empty;
                MOB.Text = row.Cells["MOBIL_FRS"].Value != null ? row.Cells["MOBIL_FRS"].Value.ToString() : string.Empty;
                MAIL.Text = row.Cells["EMAIL_FRS"].Value != null ? row.Cells["EMAIL_FRS"].Value.ToString() : string.Empty;
                RC.Text = row.Cells["NRC_FRS"].Value != null ? row.Cells["NRC_FRS"].Value.ToString() : string.Empty;
                NIF.Text = row.Cells["NIF_FRS"].Value != null ? row.Cells["NIF_FRS"].Value.ToString() : string.Empty;
                NIS.Text = row.Cells["NIS_FRS"].Value != null ? row.Cells["NIS_FRS"].Value.ToString() : string.Empty;
                NAI.Text = row.Cells["NAI_FRS"].Value != null ? row.Cells["NAI_FRS"].Value.ToString() : string.Empty;
                SOLD.Text = row.Cells["SOLDE_DETTE"].Value != null ? row.Cells["SOLDE_DETTE"].Value.ToString() : string.Empty;
            }
        }
    }
    
}

        

