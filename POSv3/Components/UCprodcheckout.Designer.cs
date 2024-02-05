namespace POSv3.Components
{
    partial class UCprodcheckout
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelprodname = new System.Windows.Forms.Label();
            this.prodamt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.prodqty = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // labelprodname
            // 
            this.labelprodname.AutoSize = true;
            this.labelprodname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelprodname.Location = new System.Drawing.Point(3, 11);
            this.labelprodname.Name = "labelprodname";
            this.labelprodname.Size = new System.Drawing.Size(97, 19);
            this.labelprodname.TabIndex = 0;
            this.labelprodname.Text = "Chickenjoy";
            // 
            // prodamt
            // 
            this.prodamt.AutoSize = true;
            this.prodamt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodamt.Location = new System.Drawing.Point(237, 11);
            this.prodamt.Name = "prodamt";
            this.prodamt.Size = new System.Drawing.Size(36, 19);
            this.prodamt.TabIndex = 1;
            this.prodamt.Text = "100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(161, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "X";
            // 
            // prodqty
            // 
            this.prodqty.AutoSize = true;
            this.prodqty.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodqty.Location = new System.Drawing.Point(177, 11);
            this.prodqty.Name = "prodqty";
            this.prodqty.Size = new System.Drawing.Size(18, 19);
            this.prodqty.TabIndex = 3;
            this.prodqty.Text = "2";
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.CircleMinus;
            this.iconButton1.IconColor = System.Drawing.Color.DarkGray;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(274, 9);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(30, 24);
            this.iconButton1.TabIndex = 4;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // UCprodcheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.prodqty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.prodamt);
            this.Controls.Add(this.labelprodname);
            this.Name = "UCprodcheckout";
            this.Size = new System.Drawing.Size(310, 42);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelprodname;
        private System.Windows.Forms.Label prodamt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label prodqty;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}
