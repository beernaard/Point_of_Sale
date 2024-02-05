using POSv3.Classes;
using POSv3.Views.CategoryViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSv3.Views.Category
{
    public partial class FormCategoryList : Form
    {
        public FormCategoryList()
        {
            InitializeComponent();
        }
        public void DisplayDataonDGV()
        {
            Classes.Category.DisplayAndSearchCategory("SELECT Id, name FROM Category", dgvcategory);
        }

        private void FormCategoryList_Load(object sender, EventArgs e)
        {
            DisplayDataonDGV();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Classes.Category.DisplayAndSearchCategory("SELECT Id, name FROM Category WHERE name LIKE '%" + textBox1.Text + "%'", dgvcategory);
        }

        private void dgvcategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                int studId = Convert.ToInt32(dgvcategory.Rows[e.RowIndex].Cells[2].Value.ToString());
                string name = dgvcategory.Rows[e.RowIndex].Cells["dgvname"].Value.ToString();

                FormEditCategory categoryform = new FormEditCategory();
                categoryform.id = studId;
                categoryform.name = name;
                categoryform.ShowDialog();
                DisplayDataonDGV();
            }
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Are you sure you want to delete this data?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Classes.Category.DeleteCategory(Convert.ToInt32(dgvcategory.Rows[e.RowIndex].Cells["dgvid"].Value.ToString()));
                    DisplayDataonDGV();
                }

                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAddCategory form = new FormAddCategory();
            form.ShowDialog();
            DisplayDataonDGV();
        }
    }
}
