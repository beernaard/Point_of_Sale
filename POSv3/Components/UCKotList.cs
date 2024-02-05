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
    public partial class UCKotList : UserControl
    {
        public UCKotList()
        {
            InitializeComponent();
        }
        public string ucproduct
        {
            get { return labelproduct.Text; }
            set { labelproduct.Text = value; }
        }
        public string ucqty
        {
            get { return labelqty.Text; }
            set { labelqty.Text = value; }
        }
    }
}
