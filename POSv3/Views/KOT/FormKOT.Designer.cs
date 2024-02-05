namespace POSv3.Views.KOT
{
    partial class FormKOT
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
            this.kotpanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // kotpanel
            // 
            this.kotpanel.AutoScroll = true;
            this.kotpanel.AutoSize = true;
            this.kotpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(243)))));
            this.kotpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kotpanel.Location = new System.Drawing.Point(0, 0);
            this.kotpanel.Name = "kotpanel";
            this.kotpanel.Size = new System.Drawing.Size(879, 517);
            this.kotpanel.TabIndex = 0;
            // 
            // FormKOT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 517);
            this.Controls.Add(this.kotpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormKOT";
            this.Text = "FormKOT";
            this.Load += new System.EventHandler(this.FormKOT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel kotpanel;
    }
}