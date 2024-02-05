using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Classes
{
    public class Connection
    {
        public static readonly string con_string = "Data Source=.;Database=POSDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(con_string);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database conenction failed \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return con;
        }
    }
}
