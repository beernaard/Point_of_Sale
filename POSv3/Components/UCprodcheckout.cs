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
    public partial class UCprodcheckout : UserControl
    {
        public UCprodcheckout()
        {
            InitializeComponent();
        }
        public EventHandler onSelect = null;
        public int prodid { get; set; }
        public int price { get; set; }
        public string productname
        {
            get { return labelprodname.Text; }
            set { labelprodname.Text = value; }
        }
        public string productqty
        {
            get { return prodqty.Text; }
            set { prodqty.Text = value; }
        }
        public string productamt
        {
            get { return prodamt.Text; }
            set { prodamt.Text = value; }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }
    }
}
