using POSv3.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSv3.Views.POS
{
    public partial class FormCheckoutPOS : Form
    {
        public FormCheckoutPOS()
        {
            InitializeComponent();
        }
        public double amt = 0;
        public int MainId = 0;
        public string type = "";
        private bool proceed = false;
        private void FormCheckoutPOS_Load(object sender, EventArgs e)
        {
            textBox1.Text = amt.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            double amt = 0;
            double received = 0;
            double change = 0;
            double.TryParse(textBox1.Text, out amt);
            double.TryParse(textBox3.Text, out received);
            change = Math.Abs(received - amt);
            if (received < amt)
            {
                textBox2.Text = "Insufficient payment";
                return;
            }
            else if (received >= amt)
            {
                proceed = true;
                textBox2.Text = change.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Checkout();
        }
        private void Checkout()
        {
            if (proceed)
            {
                Orders order = new Orders()
                {
                    received = int.Parse(textBox3.Text),
                    change = int.Parse(textBox2.Text),
                    orderid = MainId
                };
                Orders.UpdateOrders(order);
                this.Close();
            }
            else
            {
                MessageBox.Show("Insufficient payment");
            }
            
        }
    }
}
