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
    public partial class FormAddCategory : FormAdd
    {
        public FormAddCategory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Classes.Category ctg = new Classes.Category();
            ctg.name = textBox1.Text;
            Classes.Category.AddCategory(ctg);
            textBox1.Text = string.Empty;
            this.Close();
        }
    }
}
