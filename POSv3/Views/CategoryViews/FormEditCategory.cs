using POSv3.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSv3.Views.CategoryViews
{
    public partial class FormEditCategory : FormAdd
    {
        public string name = "";
        public int id = 0;
        public FormEditCategory()
        {
            InitializeComponent();
        }

        private void FormEditCategory_Load(object sender, EventArgs e)
        {
            textBox1.Text=name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Classes.Category ctg = new Classes.Category()
            {
                name = textBox1.Text,
            };
            Classes.Category.UpdateCategory(ctg, id);
            this.Close();
        }
    }
}
