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
    public partial class Fregldirect : Form
    {
        public Fregldirect()
        {
            InitializeComponent();
        }
        string connectionstring =(//connection here +
            //connection here );
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Fregldirect_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                SqlCommand j = new SqlCommand("SELECT MONT_REGLEMENT,DATE_REGLEMENT,NUM_CHEQUE,DATE_CHEQUE,NUM_VIREMENT,DATE_VIREMENT,NUM_VERSEMENT,DATE_VERSEMENT FROM HIST_REGL_CLT", connection);
                SqlCommand q = new SqlCommand("select NOM_CLT from CLIENT", connection);
                SqlCommand M = new SqlCommand("select LABEL_MODE from MODE_REGLEMENT", connection);


                SqlDataAdapter a = new SqlDataAdapter(q);
                DataTable s = new DataTable();
                a.Fill(s);
                comboBox1.DataSource = s;
                comboBox1.DisplayMember = "NOM_CLT";

                SqlDataAdapter DR = new SqlDataAdapter(M);
                DataTable DT2 = new DataTable();
                DR.Fill(DT2);
                comboBox2.DataSource = DT2;
                comboBox2.DisplayMember = "LABEL_MODE";


                SqlDataAdapter w = new SqlDataAdapter(j);
                DataTable dt = new DataTable();
                w.Fill(dt);
                dataGridView1.DataSource = dt;



                connection.Close();
            }
            cmpt.Enabled = false;
            cmpttxt.Enabled = false;
            num.Enabled = false;
            tx3.Enabled = false;
        }

            private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {     using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                int idClt = 0;
                SqlCommand q = new SqlCommand("select ID_CLT from CLIENT WHERE NOM_CLT =@NOM", connection);
                _ = q.Parameters.AddWithValue("@NOM", comboBox1.Text);
                connection.Open();

                object result = q.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    idClt = Convert.ToInt32(result);

                }


                SqlCommand d = new SqlCommand("select MONT_REGLEMENT,DATE_REGLEMENT,NUM_CHEQUE,DATE_CHEQUE,NUM_VIREMENT,DATE_VIREMENT,NUM_VERSEMENT,DATE_VERSEMENT from HIST_REGL_CLT where ID_CLT=@ID", connection);
                _ = d.Parameters.AddWithValue("@ID", idClt);


                SqlDataAdapter a = new SqlDataAdapter(d);
                DataTable s = new DataTable();
                a.Fill(s);
                dataGridView1.DataSource = s;


                connection.Close();
            }
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                
                {
                    using (SqlConnection connection = new SqlConnection(connectionstring))
                    {
                        connection.Open();
                        int idClt = 0;
                        string getIdCltQuery = "SELECT ID_CLT FROM CLIENT WHERE NOM_CLT = @nom";
                        using (SqlCommand cmd = new SqlCommand(getIdCltQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@NOM", comboBox1.Text);
                            object result = cmd.ExecuteScalar();
                            if (result != DBNull.Value)
                            {
                                idClt = Convert.ToInt32(result);

                            }
                        }
                        if (comboBox2.Text == "ESPECE")
                        {

                            string a = @"
begin
INSERT INTO HIST_REGL_CLT 
(ID_CLT,  MONT_REGLEMENT, DATE_REGLEMENT, MODE_REGLEMENT)
    VALUES (@ID_CLT, @MON, @DATE, @MODE);
end
begin
              UPDATE CLIENT 
        SET SOLDE_CREANCE = SOLDE_CREANCE - @C
        WHERE ID_CLT = @ID_CLT;
end";
                            using (SqlCommand cmd = new SqlCommand(a, connection))
                            {
                                // Add parameters for the UPDATE query
                                cmd.Parameters.AddWithValue("@DATE", DateTime.Now);
                                cmd.Parameters.AddWithValue("@MON", tx1.Text);
                                cmd.Parameters.AddWithValue("@ID_CLT", idClt);
                                cmd.Parameters.AddWithValue("@MODE", comboBox2.Text);
                                cmd.Parameters.AddWithValue("@c",tx1.Text);
                            cmd.ExecuteNonQuery();
                            }
                            Close();
                        }
                        else if (comboBox2.Text == "CHEQUE")
                        {
                            if (tx3.Text != "" )
                            {
                                string a = @"INSERT INTO HIST_REGL_CLT (ID_CLT,  MONT_REGLEMENT, DATE_REGLEMENT, MODE_REGLEMENT,NUM_CHEQUE,DATE_CHEQUE)
    VALUES (@ID_CLT, @MON, @DATE, @MODE,@num, @datch);
                                         UPDATE CLIENT 
        SET SOLDE_CREANCE = SOLDE_CREANCE - @c
        WHERE ID_CLT = @ID_CLT;";
                                using (SqlCommand cmd = new SqlCommand(a, connection))
                                {
                                    // Add parameters for the UPDATE query
                                    cmd.Parameters.AddWithValue("@DATE", DateTime.Today);
                                    cmd.Parameters.AddWithValue("@MON", tx1.Text);
                                    cmd.Parameters.AddWithValue("@ID_CLT", idClt);
                                    cmd.Parameters.AddWithValue("@MODE", comboBox2.Text);
                                    cmd.Parameters.AddWithValue("@num", tx3.Text);
                                    cmd.Parameters.AddWithValue("@datch", Convert.ToDateTime(DATE.Text));
                                    cmd.Parameters.AddWithValue("@c", tx1.Text);
                                cmd.ExecuteNonQuery();
                                }
                            }
                        }
                        else if (comboBox2.Text == "VERSEMENT BANCAIRE")
                        {
                            if (tx3.Text != "" )
                            {
                                string a = @"INSERT INTO HIST_REGL_CLT (ID_CLT,  MONT_REGLEMENT, DATE_REGLEMENT, MODE_REGLEMENT,NUM_VERSEMENT,DATE_VERSEMENT)
    VALUES (@ID_CLT, @MON, @DATE, @MODE,@num,@datch);
UPDATE CLIENT 
        SET SOLDE_CREANCE = SOLDE_CREANCE - @c
        WHERE ID_CLT = @ID_CLT;";
                                using (SqlCommand cmd = new SqlCommand(a, connection))
                                {
                                    // Add parameters for the UPDATE query
                                    cmd.Parameters.AddWithValue("@DATE", DateTime.Today);
                                    cmd.Parameters.AddWithValue("@MON", tx1.Text);
                                    cmd.Parameters.AddWithValue("@ID_CLT", idClt);
                                    cmd.Parameters.AddWithValue("@MODE", comboBox2.Text);
                                    cmd.Parameters.AddWithValue("@num", tx3.Text);
                                    cmd.Parameters.AddWithValue("@datch",Convert.ToDateTime(DATE.Text));
                                    cmd.Parameters.AddWithValue("@c", tx1.Text);
                                cmd.ExecuteNonQuery();
                                }
                            }
                        }
                        else if (comboBox2.Text == "A TERME")
                        {
                            panel1.Enabled = false;
                        }
                        else if (comboBox2.Text == "VIREMENT BANCAIRE")
                        {
                            if (tx3.Text != "" && cmpttxt.Text != "")
                            {
                                string a = @"INSERT INTO HIST_REGL_CLT (ID_CLT,  MONT_REGLEMENT, DATE_REGLEMENT, MODE_REGLEMENT,NUM_VIREMENT,DATE_VIREMENT,NUM_COMPTCLT)
    VALUES (@ID_CLT, @MON, @DATE, @MODE,@num,@datch,@NUMCMPT);
UPDATE CLIENT 
        SET SOLDE_CREANCE = SOLDE_CREANCE - @c
        WHERE ID_CLT = @ID_CLT;";
                                using (SqlCommand cmd = new SqlCommand(a, connection))
                                {
                                    // Add parameters for the UPDATE query
                                    cmd.Parameters.AddWithValue("@DATE", DateTime.Today);
                                    cmd.Parameters.AddWithValue("@MON", tx1.Text);
                                    cmd.Parameters.AddWithValue("@ID_CLT", idClt);
                                    cmd.Parameters.AddWithValue("@MODE", comboBox2.Text);
                                    cmd.Parameters.AddWithValue("@num", tx3.Text);
                                    cmd.Parameters.AddWithValue("@datch", Convert.ToDateTime(DATE.Text));
                                    cmd.Parameters.AddWithValue("@NUMCMPT", cmpttxt.Text);
                                    cmd.Parameters.AddWithValue("@c", tx1.Text);
                                cmd.ExecuteNonQuery();
                                }
                            }
                        }
                       
                        connection.Close();
                    }
                }
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
            {
                switch (comboBox2.Text)
                {
                    case "CHEQUE":
                        {
                        panel1.Visible = true;
                        panel1.Enabled = true;
                        tx1.Text = "0";
                            cmpt.Enabled = true;
                            cmpttxt.Enabled = true;
                            tx3.Enabled = true;
                            num.Enabled = true;
                        DATE.Text = DateTime.Today.ToString();
                        DATE.Visible = true;
                            LBDT.Text = "DATE CHEQUE";
                        LBDT.Visible = true;
                            num.Text = "NUM° CHEQUE";

                            break;
                        }

                    case "ESPECE":
                        {
                        panel1.Visible = true;
                        panel1.Enabled = true;
                        tx1.Text = "0";
                            cmpt.Enabled = false;
                            cmpttxt.Enabled = false;
                            num.Enabled = false;
                            DATE.Visible = false;
                            LBDT.Visible = false;
                            tx3.Enabled = false;

                            break;
                        }

                    case "VIREMENT BANCAIRE":
                        {
                        panel1.Visible = true;
                        panel1.Enabled = true;
                        tx1.Text = "0";
                            cmpt.Enabled = true;
                            cmpttxt.Enabled = true;
                            tx3.Enabled = true;
                            num.Enabled = true;
                            DATE.Text = DateTime.Today.ToString();
                            DATE.Visible = true;
                            LBDT.Text = "DATE VIREMENT";
                        LBDT.Visible = true;
                        num.Text = "NUM° VIREMENT";

                            break;
                        }
                    case "VERSEMENT BANCAIRE":
                        {
                        panel1.Visible = true;
                        panel1.Enabled = true;
                            tx1.Text = "0";
                            cmpt.Enabled = true;
                            cmpttxt.Enabled = true;
                            tx3.Enabled = true;
                            num.Enabled = true;
                            DATE.Text = DateTime.Today.ToString();
                            DATE.Visible = true;
                            LBDT.Text = "DATE VERSEMENT";
                        LBDT.Visible = true;
                        num.Text = "NUM° VERSEMENT";

                            break;
                        }
                    case "A TERME":
                        {
                            panel1.Visible = false;
                            panel1.Enabled = false;
                            break;
                        }
                

            }
        }
    } 
}
