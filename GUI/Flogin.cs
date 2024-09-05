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

namespace gestpro
{
    public partial class Flogin : Form
    {
        public Flogin()
        {
            InitializeComponent();
        }

        private void Flogin_Load(object sender, EventArgs e)
        {
            label1.Parent = this;
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;   
        }

        private void sqlConnection1_InfoMessage(object sender, System.Data.SqlClient.SqlInfoMessageEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=SERVER-ZAOUIA;Initial Catalog=GestProDB;Persist Security Info=True;User ID=dev01;Password=9988;TrustServerCertificate=True";
            string query = "SELECT COUNT(1) FROM USERS WHERE LOGIN=@user AND PWD=@pass";
            try 
            {
                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        SqlParameter LOCATEUSER = cmd.Parameters.AddWithValue("@user", User.Text);
                        SqlParameter LOCATEPASS = cmd.Parameters.AddWithValue("@pass", Pass.Text);

                        con.Open();
                        int result = (int)cmd.ExecuteScalar();
                        if (result == 1)
                        {
                            MessageBox.Show(" Login Successful.! ");
                            this.Hide();
                            Fprincipale fprincipale = new Fprincipale();
                            fprincipale.ShowDialog();

                        }
                        else
                        {
                            MessageBox.Show("Invalid Username or Password.");
                        }
                    }
                }
            }
            catch(Exception ex) 
            {
                //Exception de connection au serveur
                MessageBox.Show(ex.Message, "Server Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
    
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
    
}
