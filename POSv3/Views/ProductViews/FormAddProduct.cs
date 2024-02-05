using POSv3.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSv3.Views.ProductViews
{
    public partial class FormAddProduct : FormAdd
    {
        string filepath;
        public FormAddProduct()
        {
            InitializeComponent();
        }

        public virtual void FormAddProduct_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            string qry = "SELECT Id 'id',name 'name' from Category";
            Classes.Products.CBFill(qry, comboBox1);
            comboBox1.SelectedValue = 1;
        }

        public virtual void button1_Click(object sender, EventArgs e)
        {
            Classes.Products prod = new Classes.Products();
            prod.name = textBox1.Text;
            prod.price = Convert.ToInt32(textBox2.Text);
            prod.categoryid = Convert.ToInt32(comboBox1.SelectedValue);
            prod.img = GetPhoto();
            Classes.Products.AddProduct(prod);
            this.Close();
        }
        private byte[] GetPhoto()
        {
            MemoryStream stream = new MemoryStream();
            pictureBox1.Image.Save(stream, pictureBox1.Image.RawFormat);
            return stream.GetBuffer();
        }

        public virtual void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg;";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filepath = openFileDialog.FileName;
                pictureBox1.Image = new Bitmap(filepath);
            }
        }
    }
}
