using FontAwesome.Sharp;
using POSv3.Views.Category;
using POSv3.Views.Home;
using POSv3.Views.KOT;
using POSv3.Views.POS;
using POSv3.Views.POS.OrderViews;
using POSv3.Views.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSv3
{
    public partial class FormNav : Form
    {
        private IconButton currentbtn;
        private Panel leftborderbtn;
        public FormNav()
        {
            InitializeComponent();
            leftborderbtn = new Panel();
            leftborderbtn.Size = new Size(7, 74);
            panel1.Controls.Add(leftborderbtn);
        }
        private void Activatebutton(object sender)
        {
            if (sender != null)
            {
                Disablebutton();
                currentbtn = (IconButton)sender;
                currentbtn.BackColor = System.Drawing.Color.FromArgb(244, 244, 243);
                currentbtn.TextAlign = ContentAlignment.MiddleCenter;
                currentbtn.ImageAlign = ContentAlignment.MiddleCenter;
                currentbtn.ForeColor = System.Drawing.Color.FromArgb(2, 16, 17);
                currentbtn.IconColor = System.Drawing.Color.FromArgb(2, 16, 17);

                leftborderbtn.BackColor = System.Drawing.Color.FromArgb(2, 16, 17);
                leftborderbtn.Location = new Point(0, currentbtn.Location.Y);
                leftborderbtn.Visible = true;
                leftborderbtn.BringToFront();
            }
        }
        private void Disablebutton()
        {
            if (currentbtn != null)
            {
                currentbtn.BackColor = System.Drawing.Color.FromArgb(2, 16, 17);
                currentbtn.TextAlign = ContentAlignment.MiddleLeft;
                currentbtn.ImageAlign = ContentAlignment.MiddleLeft;
                currentbtn.ForeColor = System.Drawing.Color.FromArgb(231, 251, 254);
                currentbtn.IconColor = System.Drawing.Color.FromArgb(231, 251, 254);
            }
        }
        public void AddControls(Form f)
        {
            panelcontent.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            panelcontent.Controls.Add(f);
            f.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Activatebutton(sender);
            AddControls(new FormHome());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Activatebutton(sender);
            AddControls(new FormCategoryList());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Activatebutton(sender);
            AddControls(new FormProductList());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            Activatebutton(sender);
            AddControls(new FormPOS());
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            Activatebutton(sender);
            AddControls(new FormKOT());
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            Activatebutton(sender);
            AddControls(new FormOrderList());
        }

        private void FormNav_Load(object sender, EventArgs e)
        {
            iconButton1.PerformClick();
            
        }
    }
}
