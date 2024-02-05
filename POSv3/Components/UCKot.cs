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
    public partial class UCKot : UserControl
    {
        public UCKot()
        {
            InitializeComponent();
        }
        public EventHandler onSelect = null;
        public Panel panel { get; set; }
        public void AddproductInPanel(UserControl uc)
        {
            panelorders.Controls.Add(uc);
            AdjustProductLayout();
        }
        private void AdjustProductLayout()
        {
            int spacing = 10;
            int xPosition = spacing;
            int yPosition = spacing;

            foreach (var item in panelorders.Controls)
            {
                var prod = (UCKotList)item;
                if (prod.Visible)
                {
                    // Set the location of the visible UserControlProduct
                    prod.Location = new System.Drawing.Point(xPosition, yPosition);

                    // Update xPosition for the next UserControlProduct
                    xPosition += prod.Width + spacing;

                    // Check if adding the UserControlProduct will exceed the panel width
                    if (xPosition + prod.Width > panelorders.Width)
                    {
                        // Start a new row by resetting xPosition and adjusting the Y-coordinate
                        xPosition = spacing;
                        yPosition += prod.Height + spacing;
                    }
                }
            }
        }
        public string ordertype
        {
            get { return labelordertype.Text; }
            set { labelordertype.Text = value; }
        }
        public string orderid
        {
            get { return labelorderid.Text; }
            set { labelorderid.Text = value; }
        }
        public string orderdate
        {
            get { return labelorderid.Text; }
            set { labelorderid.Text = value; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }
    }
}
