using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSv3.Views.POS.OrderViews
{
    public partial class FormOrderList : Form
    {
        public FormOrderList()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string qry = "SELECT * FROM Orders WHERE orderId LIKE '%" + textBox1.Text + "%'";
            Classes.Orders.DisplayAndSearchOrders(qry, dgvcategory);
        }

        private void FormOrderList_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            string qry = "SELECT * FROM Orders WHERE orderId LIKE '%" + textBox1.Text + "%'";
            Classes.Orders.DisplayAndSearchOrders(qry, dgvcategory);
        }
    }
}
