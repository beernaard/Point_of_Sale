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
    public partial class FormEditProduct : Form
    {
        public int id=0;
        public FormEditProduct()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            Classes.Products prod = new Classes.Products();
            prod = Classes.Products.GetOneProduct(id);
            textBox1.Text = prod.name;
            textBox2.Text = prod.price.ToString();
            comboBox1.SelectedValue = prod.categoryid.ToString();
            if (prod.img != null)
            {
                pictureBox1.Image = new Bitmap(GetPhotoFromDB(prod.img));
                storedbyed = prod.img;
            }
            else
            {
                pictureBox1.Image = null;
            }

        }
        void LoadCB()
        {
            string qry = "SELECT Id 'id',name 'name' from Category";
            Classes.Products.CBFill(qry, comboBox1);
        }

        void UpdateProduct()
        {
            Classes.Products prod = new Classes.Products();
            prod.name = textBox1.Text;
            prod.price = Convert.ToInt32(textBox2.Text);
            prod.categoryid = Convert.ToInt32(comboBox1.SelectedValue);
            if (filepath != null)
            {
                prod.img = GetPhoto();
            }
            else
            {
                prod.img = storedbyed;
            }
            Classes.Products.UpdateProduct(prod, id);
        }

        private byte[] GetPhoto()
        {
            MemoryStream stream = new MemoryStream();
            pictureBox1.Image.Save(stream, pictureBox1.Image.RawFormat);
            return stream.GetBuffer();
        }
        private Image GetPhotoFromDB(byte[] img)
        {
            using (MemoryStream ms = new MemoryStream(img))
            {
                return Image.FromStream(ms);
            }
        }
        string filepath;
        byte[] storedbyed;
        private void FormEditProduct_Load_1(object sender, EventArgs e)
        {
            LoadCB();
            LoadData();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            UpdateProduct();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
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
