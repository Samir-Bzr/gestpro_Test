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
using System.Data.SqlTypes;
using System.Data.Sql;

namespace gestpro
{
    public partial class FBNLIV : Form
    {
        public FBNLIV()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=SERVER-ZAOUIA;Initial Catalog=GestProDB;Persist Security Info=True;Us" +
 "er ID=dev01;Password=9988;TrustServerCertificate=True");
            SqlCommand cmd = new SqlCommand(@"
                    SELECT 
                    *
                    FROM CLIENT
                    JOIN BON_LIVRAISON ON CLIENT.ID_CLT = BON_LIVRAISON.ID_CLT
                    JOIN DETAIL_BL ON BON_LIVRAISON.ID_BL = DETAIL_BL.ID_BL
                    JOIN STKPRDFINI ON DETAIL_BL.REFARTFINI = STKPRDFINI.REFARTFINI", con);
            SqlDataAdapter d = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            d.Fill(dt);
            BONLIVVAL bONLIVVAL = new BONLIVVAL
            {
                DataSource = dt
            };
           

        }

        private void documentViewer1_Load(object sender, EventArgs e)
        {

        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void FBNLIV_Load(object sender, EventArgs e)
        {
         
        }
    }
}
