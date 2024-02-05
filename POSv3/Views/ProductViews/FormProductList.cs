using POSv3.Views.ProductViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSv3.Views.Products
{
    public partial class FormProductList : Form
    {
        public FormProductList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAddProduct form = new FormAddProduct();
            form.ShowDialog();
            LoadpProducts();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                int studId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["dgvid"].Value.ToString());
                FormEditProduct form = new FormEditProduct();
                form.id = studId;
                form.ShowDialog();
                LoadpProducts();
            }
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Are you sure you want to delete this data?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Classes.Products.DeleteProduct(Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["dgvid"].Value.ToString()));
                    LoadpProducts();
                }

                return;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string selectSQL = "SELECT Products.Id, Products.pname,Products.price, Category.name FROM Products INNER JOIN Category ON Products.categoryid=Category.Id WHERE pname LIKE '%" + textBox1.Text + "%'";
            Classes.Products.GetProducts(selectSQL, dataGridView1);
        }
        private void LoadpProducts()
        {
            string selectSQL = "SELECT Products.Id, Products.pname,Products.price, Category.name FROM Products INNER JOIN Category ON Products.categoryid=Category.Id WHERE pname LIKE '%" + textBox1.Text + "%'";
            Classes.Products.GetProducts(selectSQL,dataGridView1);
        }

        private void FormProductList_Load(object sender, EventArgs e)
        {
            LoadpProducts();
        }
    }
}
