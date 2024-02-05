namespace POSv3.Components
{
    partial class UCKotList
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
            this.labelproduct = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelqty = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelproduct
            // 
            this.labelproduct.AutoSize = true;
            this.labelproduct.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelproduct.Location = new System.Drawing.Point(4, 5);
            this.labelproduct.Name = "labelproduct";
            this.labelproduct.Size = new System.Drawing.Size(120, 21);
            this.labelproduct.TabIndex = 0;
            this.labelproduct.Text = "ProductName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            // 
            // labelqty
            // 
            this.labelqty.AutoSize = true;
            this.labelqty.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelqty.Location = new System.Drawing.Point(172, 5);
            this.labelqty.Name = "labelqty";
            this.labelqty.Size = new System.Drawing.Size(19, 21);
            this.labelqty.TabIndex = 2;
            this.labelqty.Text = "2";
            // 
            // UCKotList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelqty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelproduct);
            this.Name = "UCKotList";
            this.Size = new System.Drawing.Size(224, 42);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelproduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelqty;
    }
}
