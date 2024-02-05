using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSv3.Components
{
    public partial class UCProducts : UserControl
    {
        public UCProducts()
        {
            InitializeComponent();
        }
        public EventHandler onSelect = null;
        public int id { get; set; }
        public string pcategory { get; set; }
        public string PName
        {
            get { return labelproductname.Text; }
            set { labelproductname.Text = value; }
        }
        public string PPrice
        {
            get { return labelprodamt.Text; }
            set { labelprodamt.Text = value; }
        }
        public Image pImage
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }
    }
}
