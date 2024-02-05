using POS.Classes;
using POSv3.Components;
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

namespace POSv3.Views.KOT
{
    public partial class FormKOT : Form
    {
        public FormKOT()
        {
            InitializeComponent();
        }
        private void AdjustProductLayout()
        {
            int spacing = 11;
            int xPosition = 10;
            int yPosition = 10;
            int totalwidth = 0;
            foreach (var item in kotpanel.Controls)
            {
                var prod = (UCKot)item;
                if (prod.Visible)
                {
                    // Set the location of the visible UserControlProduct
                    prod.Location = new System.Drawing.Point(xPosition, yPosition);
                    totalwidth += xPosition;
                    // Update xPosition for the next UserControlProduct
                    xPosition += prod.Width + spacing + 47;

                    // Check if adding the UserControlProduct will exceed the panel width
                    if (xPosition > kotpanel.Width)
                    {
                        // Start a new row by resetting xPosition and adjusting the Y-coordinate
                        xPosition = spacing;
                        yPosition += prod.Height + spacing;
                    }
                }
            }
        }
        public void GetallPendingOrders()
        {
            SqlConnection con = Connection.GetConnection();
            string qry = "SELECT * FROM Orders WHERE status = 'Paid'";
            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            foreach (DataRow row in dataTable.Rows)
            {
                DateTime datetime = (DateTime)row["orderdate"];
                string formattedtime = datetime.ToString("yyyy-MM-dd HH:mm:ss");
                UCKot uckot = new UCKot()
                {
                    orderdate = formattedtime,
                    orderid = row["orderId"].ToString(),
                    ordertype = row["ordertype"].ToString()
                };
                kotpanel.Controls.Add(uckot);
                string qry2 = "SELECT * FROM OrderDetails INNER JOIN Products ON OrderDetails.productid=Products.id WHERE orderId = " + row["orderId"].ToString();
                SqlCommand cmd2 = new SqlCommand(qry2, con);
                SqlDataAdapter adapter2 = new SqlDataAdapter(cmd2);
                DataTable dataTable2 = new DataTable();
                adapter2.Fill(dataTable2);
                foreach (DataRow row2 in dataTable2.Rows)
                {
                    UCKotList uckotpro = new UCKotList()
                    {
                        ucproduct = row2["pname"].ToString(),
                        ucqty = row2["qty"].ToString()
                    };
                    uckot.AddproductInPanel(uckotpro);
                }
                uckot.onSelect += (ss, ee) =>
                {
                    var wdg = (UCKot)ss;
                    string qry3 = "UPDATE Orders set status= @Completed WHERE orderId=" + row["orderId"].ToString();
                    using (SqlCommand cmd3 = new SqlCommand(qry3, con))
                    {
                        cmd3.Parameters.AddWithValue("@Completed", "Completed");
                        int rowsaffected = cmd3.ExecuteNonQuery();
                        if (rowsaffected > 0)
                        {
                            MessageBox.Show("Update successful!");
                        }
                        else
                        {
                            MessageBox.Show("No records updated.");
                        }
                        kotpanel.Controls.Clear();
                        GetOrders();
                    }

                };
            }

        }

        private void FormKOT_Load(object sender, EventArgs e)
        {
            GetOrders();
        }
        public void GetOrders()
        {
            GetallPendingOrders();
            AdjustProductLayout();
        }

    }
}
