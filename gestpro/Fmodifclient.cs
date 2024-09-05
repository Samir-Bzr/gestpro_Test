using DevExpress.XtraBars.Docking.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace gestpro
{
    public partial class Fmodifclient : Form
    {
        private int _id;
        public Fmodifclient(int id)
        {

            InitializeComponent();
            _id = id;
            LoadData();

        }
        public void disp_data ()
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


        public SqlConnection con = new SqlConnection("Data Source=SERVER-ZAOUIA;Initial Catalog=GestProDB;Persist Security Info=True;Us" +
    "er ID=dev01;Password=9988;TrustServerCertificate=True");
        public void LoadData()
        {
            
            string query = "SELECT * FROM CLIENT WHERE ID_CLT = @id";

            
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", _id);
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dataGridView1.DataSource= dt;

                    }
                }
            }
        }

        private void Fmodifclient_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestProDBDataSet.CLIENT'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.cLIENTTableAdapter.Fill(this.gestProDBDataSet.CLIENT);

            NOM.Focus();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Reset_Click(object sender, EventArgs e)
        {


            bindingSource1 = new BindingSource();

            bindingSource1.DataSource = this.gestProDBDataSet.CLIENT;

        }

        private void SAVE_Click(object sender, EventArgs e)
        {
            
            string a = @"UPDATE [dbo].[CLIENT]
           SET [NOM_CLT] = @nom
      ,[CATEG_CLT] = @cat
      ,[ADR_CLT] = @adr
      ,[VILLE_CLT] = @ville
      ,[TEL_CLT] = @tel
      ,[MOBIL_CLT] =@mob
      ,[EMAIL_CLT] = @mail
      ,[NRC_CLT] = @rc
      ,[NIF_CLT] = @nif
      ,[NIS_CLT] = @nis,NAI_CLT=@NAI
      ,[SOLDE_CREANCE] = @sold
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
            cmd.Parameters.AddWithValue("@date", DateTime.Now) ;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            bindingSource1.AddNew();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            bindingSource1.RemoveCurrent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string a = @"INSERT INTO [dbo].[CLIENT]
           ([NOM_CLT]
           ,[CATEG_CLT]
           ,[ADR_CLT]
           ,[VILLE_CLT]
           ,[TEL_CLT]
           ,[MOBIL_CLT]
           ,[EMAIL_CLT]
           ,[NRC_CLT]
           ,[NIF_CLT]
           ,[NIS_CLT],NAI_clt
           ,[SOLDE_CREANCE]
           ,[DATETIMECREATION])
     VALUES
           ('" + NOM.Text + "','" + CAT.Text + "','" + ADR.Text + "','" + VILLE.Text + "','" + TEL.Text + "','" + MOB.Text + "','" + MAIL.Text + "'" +
           ",'" + RC.Text + "','" + NIF.Text + "','" + NIS.Text + "','" + NAI.Text+"','"+ SOLD.Text + "','" + DateTime.Now + "') ";
            SqlCommand cmd = new SqlCommand(a, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            disp_data();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            string a = @"DELETE FROM [dbo].[CLIENT] WHERE ID_CLT = '" + dataGridView1.CurrentCell.Value +"'  ";
            SqlCommand cmd = new SqlCommand(a, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            disp_data();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            disp_data();        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the click is on a valid row
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                NOM.Text = row.Cells["NOM_CLT"].Value != null ? row.Cells["NOM_CLT"].Value.ToString() : string.Empty;
                CAT.Text = row.Cells["CATEG_CLT"].Value != null ? row.Cells["CATEG_CLT"].Value.ToString() : string.Empty;
                ADR.Text = row.Cells["ADR_CLT"].Value != null ? row.Cells["ADR_CLT"].Value.ToString() : string.Empty;
                VILLE.Text = row.Cells["VILLE_CLT"].Value != null ? row.Cells["VILLE_CLT"].Value.ToString() : string.Empty;
                TEL.Text = row.Cells["TEL_CLT"].Value != null ? row.Cells["TEL_CLT"].Value.ToString() : string.Empty;
                MOB.Text = row.Cells["MOBIL_CLT"].Value != null ? row.Cells["MOBIL_CLT"].Value.ToString() : string.Empty;
                MAIL.Text = row.Cells["EMAIL_CLT"].Value != null ? row.Cells["EMAIL_CLT"].Value.ToString() : string.Empty;
                RC.Text = row.Cells["NRC_CLT"].Value != null ? row.Cells["NRC_CLT"].Value.ToString() : string.Empty;
                NIF.Text = row.Cells["NIF_CLT"].Value != null ? row.Cells["NIF_CLT"].Value.ToString() : string.Empty;
                NIS.Text = row.Cells["NIS_CLT"].Value != null ? row.Cells["NIS_CLT"].Value.ToString() : string.Empty;
                NAI.Text = row.Cells["NAI_CLT"].Value != null ? row.Cells["NAI_CLT"].Value.ToString() : string.Empty;
                SOLD.Text = row.Cells["SOLDE_CREANCE"].Value != null ? row.Cells["SOLDE_CREANCE"].Value.ToString() : string.Empty;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            Control[] textboxes = { NOM, NIF, NIS, SOLD, CAT,NAI, RC, MAIL, MOB, TEL, VILLE, ADR };
            
            ClearText(textboxes);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
 
