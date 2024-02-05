using FontAwesome.Sharp;
using POS.Classes;
using POSv3.Classes;
using POSv3.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Windows.Input;

namespace POSv3.Views.POS
{
    public partial class FormPOS : Form
    {
        public FormPOS()
        {
            InitializeComponent();
            
        }
        private System.Windows.Forms.Button currentbtn;
        private int mainid = 0;
        private string ordertype = "";
        private void Activatebutton(object sender)
        {
            if (sender != null)
            {
                Disablebutton();
                currentbtn = (System.Windows.Forms.Button)sender;
                currentbtn.BackColor = System.Drawing.Color.FromArgb(2, 16, 17); 
                currentbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                currentbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
                currentbtn.ForeColor = System.Drawing.Color.FromArgb(231, 251, 254); 

            }

        }
        private void Disablebutton()
        {
            if (currentbtn != null)
            {
                currentbtn.BackColor = System.Drawing.Color.FromArgb(244, 244, 243);
                currentbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                currentbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                currentbtn.ForeColor = System.Drawing.Color.FromArgb(2, 16, 17);
            }
        }
        private void AddCategory()
        {
            string qry = "SELECT * FROM Category";
            SqlConnection con = Connection.GetConnection();
            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                //populate category horizontally
                int spacing = 20;
                int xposition = 127;
                foreach (DataRow dr in dt.Rows)
                {
                    System.Windows.Forms.Button b = new System.Windows.Forms.Button();
                    b.Size = new System.Drawing.Size(79, 39);
                    b.Text = dr["name"].ToString();
                    b.Location = new System.Drawing.Point(xposition, 6);
                    b.FlatStyle = FlatStyle.Flat;
                    b.FlatAppearance.BorderSize = 0;
                    b.ForeColor = System.Drawing.Color.FromArgb(2, 16, 17);
                    b.BackColor= System.Drawing.Color.FromArgb(244, 244, 243);
                    b.Font = new Font("Century Gothic", 12, FontStyle.Regular);
                    b.Cursor = System.Windows.Forms.Cursors.Hand;
                    b.Click += new EventHandler(b_Click);
                    panelcategory.Controls.Add(b);
                    xposition += b.Width + spacing;      
                }

            }

        }
        private void b_Click(object sender, EventArgs e)
        {
            int spacing = 10;
            int xposition = spacing;
            Activatebutton(sender);
            System.Windows.Forms.Button b = (System.Windows.Forms.Button)sender;
            foreach (var item in panelproducts.Controls)
            {
                var prod = (UCProducts)item;
                prod.Visible = prod.pcategory.ToLower().Contains(b.Text.Trim().ToLower());
                AdjustProductLayout();
            }
        }
        private void AdjustProductLayout()
        {
            int spacing = 10;
            int xPosition = spacing;
            int yPosition = spacing;

            foreach (var item in panelproducts.Controls)
            {
                var prod = (UCProducts)item;
                if (prod.Visible)
                {
                    // Set the location of the visible UserControlProduct
                    prod.Location = new System.Drawing.Point(xPosition, yPosition);

                    // Update xPosition for the next UserControlProduct
                    xPosition += prod.Width + spacing;

                    // Check if adding the UserControlProduct will exceed the panel width
                    if (xPosition + prod.Width > panelproducts.Width)
                    {
                        // Start a new row by resetting xPosition and adjusting the Y-coordinate
                        xPosition = spacing;
                        yPosition += prod.Height + spacing;
                    }
                }
            }
        }
        private void Adjustsuercontrollayout()
        {
            int spacing = 10;
            int xPosition = spacing;
            int yPosition = spacing;

            foreach (var item in panelusercontrol.Controls)
            {
                var prod = (UCprodcheckout)item;
                if (prod.Visible)
                {
                    // Set the location of the visible UserControlProduct
                    prod.Location = new System.Drawing.Point(xPosition, yPosition);

                    // Update xPosition for the next UserControlProduct
                    xPosition += prod.Width + spacing;

                    // Check if adding the UserControlProduct will exceed the panel width
                    if (xPosition + prod.Width > panelusercontrol.Width)
                    {
                        // Start a new row by resetting xPosition and adjusting the Y-coordinate
                        xPosition = spacing;
                        yPosition += prod.Height + spacing;
                    }

                }
            }
        }
        private void LoadProduct()
        {
            string qry = "SELECT Products.Id, Products.pname,Products.price,Products.productimage, Category.name FROM Products INNER JOIN Category ON Products.categoryid=Category.Id";
            SqlConnection con = Connection.GetConnection();
            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            panelproducts.Controls.Clear();
            int spacing = 10;
            int xPosition = spacing;
            int yPosition = spacing;
            foreach (DataRow dr in dt.Rows)
            {
                Byte[] imagearray = (byte[])dr["productimage"];
                byte[] imagebytearray = imagearray;

                UCProducts w = new UCProducts()
                {
                    PName = dr["pname"].ToString(),
                    PPrice = dr["price"].ToString(),
                    pImage = System.Drawing.Image.FromStream(new MemoryStream(imagearray)),
                    pcategory = dr["name"].ToString(),
                    id = Convert.ToInt32(dr["Id"])
                };
                if (xPosition + w.Width > panelproducts.Width)
                {
                    // Start a new row by resetting xPosition and adjusting the Y-coordinate
                    xPosition = spacing;
                    yPosition += w.Height + spacing;
                }
                w.Location = new System.Drawing.Point(xPosition, yPosition);
                panelproducts.Controls.Add(w);
                xPosition += w.Width + spacing;
                w.onSelect += (ss, ee) =>
                {

                    var wdg = (UCProducts)ss;
                    foreach(UCprodcheckout usercontrol in panelusercontrol.Controls)
                    {
                        if(usercontrol.prodid == wdg.id)
                        {
                            usercontrol.productqty =(int.Parse(usercontrol.productqty)+1).ToString();
                            usercontrol.productamt = (int.Parse(usercontrol.productqty) * int.Parse(wdg.PPrice)).ToString();
                            GetTotal();
                            return;
                        }
                    }
                    
                    UCprodcheckout uCprodcheckout = new UCprodcheckout()
                    {
                        productname = dr["pname"].ToString(),
                        productamt = dr["price"].ToString(),
                        productqty = 1.ToString(),
                        prodid = int.Parse(dr["Id"].ToString()),
                        price = int.Parse(dr["price"].ToString())
                    };
                    panelusercontrol.Controls.Add(uCprodcheckout);
                    Adjustsuercontrollayout();
                    GetTotal();
                    uCprodcheckout.onSelect += (sss, eee) =>
                    {
                        foreach (UCprodcheckout usercontrol in panelusercontrol.Controls)
                        {
                            if (usercontrol.prodid == wdg.id)
                            {
                                if (int.Parse(usercontrol.productqty) == 1)
                                {
                                    panelusercontrol.Controls.Remove(usercontrol);
                                    Adjustsuercontrollayout();
                                }
                                usercontrol.productqty = (int.Parse(usercontrol.productqty) - 1).ToString();
                                usercontrol.productamt = (int.Parse(usercontrol.productqty) * int.Parse(wdg.PPrice)).ToString();
                                GetTotal();
                                return;
                            }
                        }
                    };
                };
            }
        }
        private void GetTotal()
        {
            double total = 0;
            labeltotal.Text = "";
            foreach (UCprodcheckout uc in panelusercontrol.Controls)
            {
                total += double.Parse(uc.productamt);
            }
            labeltotal.Text = total.ToString("N2");
        }
        private void FormPOS_Load(object sender, EventArgs e)
        {
                
            button2.PerformClick();
            AddCategory();
            LoadProduct();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in panelproducts.Controls)
            {
                var prod = (UCProducts)item;
                prod.Visible = prod.PName.ToLower().Contains(textBox1.Text.Trim().ToLower());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadProduct();
            Activatebutton(sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Guid guid = Guid.NewGuid();
            mainid = guid.GetHashCode();
            if (radioButton1.Checked)
            {
                ordertype = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                ordertype = radioButton2.Text;
            }
            Orders order = new Orders()
            {
                orderid = guid.GetHashCode(),
                orderdate = DateTime.Now,
                ordertype = ordertype,
                total = float.Parse(labeltotal.Text),
                received = 0,
                change = 0,
                status = "Paid",
            };
            if ((radioButton1.Checked == false && radioButton2.Checked == false) && (panelusercontrol.Controls.Count == 0)==true)
            {
                MessageBox.Show("Add Orders and Select Order type");
            }
            else if ((radioButton1.Checked==false && radioButton2.Checked==false))
            {
                MessageBox.Show("Select Order type");
                
            }
            else if(panelusercontrol.Controls.Count==0)
            {
                MessageBox.Show("Add Orders");
            }
            else
            {
                Orders.AddOrders(order, panelusercontrol);
                FormCheckoutPOS fco = new FormCheckoutPOS();
                fco.MainId = mainid;
                fco.type = ordertype;
                fco.amt = Convert.ToDouble(labeltotal.Text);
                fco.ShowDialog();
                ClearData();
            }

        }

        private void ClearData()
        {
            mainid = 0;
            ordertype = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            labeltotal.Text = "0";
            panelusercontrol.Controls.Clear();
        }
    }
}
