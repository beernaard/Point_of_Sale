namespace POSv3.Views.POS
{
    partial class FormPOS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelcheckout = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.labeltotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panelusercontrol = new System.Windows.Forms.Panel();
            this.paneltextbox = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelcategory = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panelproducts = new System.Windows.Forms.Panel();
            this.panelcheckout.SuspendLayout();
            this.paneltextbox.SuspendLayout();
            this.panelcategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelcheckout
            // 
            this.panelcheckout.Controls.Add(this.radioButton2);
            this.panelcheckout.Controls.Add(this.radioButton1);
            this.panelcheckout.Controls.Add(this.labeltotal);
            this.panelcheckout.Controls.Add(this.label1);
            this.panelcheckout.Controls.Add(this.button1);
            this.panelcheckout.Controls.Add(this.panelusercontrol);
            this.panelcheckout.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelcheckout.Location = new System.Drawing.Point(739, 0);
            this.panelcheckout.Name = "panelcheckout";
            this.panelcheckout.Size = new System.Drawing.Size(328, 545);
            this.panelcheckout.TabIndex = 0;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(224, 13);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(95, 23);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Take Out";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(28, 13);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(80, 23);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Dine In";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // labeltotal
            // 
            this.labeltotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labeltotal.AutoSize = true;
            this.labeltotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltotal.Location = new System.Drawing.Point(265, 440);
            this.labeltotal.Name = "labeltotal";
            this.labeltotal.Size = new System.Drawing.Size(18, 19);
            this.labeltotal.TabIndex = 3;
            this.labeltotal.Text = "0";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 440);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "TOTAL:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(16)))), ((int)(((byte)(17)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(251)))), ((int)(((byte)(254)))));
            this.button1.Location = new System.Drawing.Point(18, 477);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(298, 56);
            this.button1.TabIndex = 1;
            this.button1.Text = "Check Out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelusercontrol
            // 
            this.panelusercontrol.AutoScroll = true;
            this.panelusercontrol.AutoSize = true;
            this.panelusercontrol.Location = new System.Drawing.Point(6, 47);
            this.panelusercontrol.Name = "panelusercontrol";
            this.panelusercontrol.Size = new System.Drawing.Size(310, 348);
            this.panelusercontrol.TabIndex = 0;
            // 
            // paneltextbox
            // 
            this.paneltextbox.Controls.Add(this.textBox1);
            this.paneltextbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltextbox.Location = new System.Drawing.Point(0, 0);
            this.paneltextbox.Name = "paneltextbox";
            this.paneltextbox.Size = new System.Drawing.Size(739, 47);
            this.paneltextbox.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(461, 24);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panelcategory
            // 
            this.panelcategory.Controls.Add(this.button2);
            this.panelcategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelcategory.Location = new System.Drawing.Point(0, 47);
            this.panelcategory.Name = "panelcategory";
            this.panelcategory.Size = new System.Drawing.Size(739, 52);
            this.panelcategory.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(16)))), ((int)(((byte)(17)))));
            this.button2.Location = new System.Drawing.Point(33, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 39);
            this.button2.TabIndex = 0;
            this.button2.Text = "All";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelproducts
            // 
            this.panelproducts.AutoScroll = true;
            this.panelproducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelproducts.Location = new System.Drawing.Point(0, 99);
            this.panelproducts.Name = "panelproducts";
            this.panelproducts.Size = new System.Drawing.Size(739, 446);
            this.panelproducts.TabIndex = 3;
            // 
            // FormPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(1067, 545);
            this.Controls.Add(this.panelproducts);
            this.Controls.Add(this.panelcategory);
            this.Controls.Add(this.paneltextbox);
            this.Controls.Add(this.panelcheckout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPOS";
            this.Text = "FormPOS";
            this.Load += new System.EventHandler(this.FormPOS_Load);
            this.panelcheckout.ResumeLayout(false);
            this.panelcheckout.PerformLayout();
            this.paneltextbox.ResumeLayout(false);
            this.paneltextbox.PerformLayout();
            this.panelcategory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelcheckout;
        private System.Windows.Forms.Panel paneltextbox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panelcategory;
        private System.Windows.Forms.Panel panelproducts;
        private System.Windows.Forms.Panel panelusercontrol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labeltotal;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}