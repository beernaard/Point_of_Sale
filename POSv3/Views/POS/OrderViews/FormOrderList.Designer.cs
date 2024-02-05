namespace POSv3.Views.POS.OrderViews
{
    partial class FormOrderList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvcategory = new System.Windows.Forms.DataGridView();
            this.dgvid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvdatetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvordertype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvreceived = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvchange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvview = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcategory)).BeginInit();
            this.SuspendLayout();
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(243)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(16)))), ((int)(((byte)(17)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(16)))), ((int)(((byte)(17)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 28;
            this.iconPictureBox1.Location = new System.Drawing.Point(474, 55);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(28, 31);
            this.iconPictureBox1.TabIndex = 6;
            this.iconPictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(501, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(293, 27);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgvcategory
            // 
            this.dgvcategory.AllowUserToAddRows = false;
            this.dgvcategory.AllowUserToDeleteRows = false;
            this.dgvcategory.AllowUserToResizeColumns = false;
            this.dgvcategory.AllowUserToResizeRows = false;
            this.dgvcategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvcategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvcategory.BackgroundColor = System.Drawing.Color.White;
            this.dgvcategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvcategory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvcategory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(16)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(251)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(251)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(16)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvcategory.ColumnHeadersHeight = 40;
            this.dgvcategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvcategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvid,
            this.dgvdatetime,
            this.dgvordertype,
            this.dgvtotal,
            this.dgvreceived,
            this.dgvchange,
            this.dgvstatus,
            this.dgvview});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(16)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(16)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(251)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvcategory.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvcategory.EnableHeadersVisualStyles = false;
            this.dgvcategory.Location = new System.Drawing.Point(24, 94);
            this.dgvcategory.Name = "dgvcategory";
            this.dgvcategory.ReadOnly = true;
            this.dgvcategory.RowHeadersVisible = false;
            this.dgvcategory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvcategory.Size = new System.Drawing.Size(771, 415);
            this.dgvcategory.TabIndex = 4;
            // 
            // dgvid
            // 
            this.dgvid.DataPropertyName = "orderId";
            this.dgvid.FillWeight = 27.51568F;
            this.dgvid.HeaderText = "Id";
            this.dgvid.MinimumWidth = 50;
            this.dgvid.Name = "dgvid";
            this.dgvid.ReadOnly = true;
            // 
            // dgvdatetime
            // 
            this.dgvdatetime.DataPropertyName = "orderdate";
            this.dgvdatetime.HeaderText = "Datetime";
            this.dgvdatetime.MinimumWidth = 100;
            this.dgvdatetime.Name = "dgvdatetime";
            this.dgvdatetime.ReadOnly = true;
            // 
            // dgvordertype
            // 
            this.dgvordertype.DataPropertyName = "ordertype";
            this.dgvordertype.HeaderText = "Order Type";
            this.dgvordertype.MinimumWidth = 100;
            this.dgvordertype.Name = "dgvordertype";
            this.dgvordertype.ReadOnly = true;
            // 
            // dgvtotal
            // 
            this.dgvtotal.DataPropertyName = "total";
            this.dgvtotal.HeaderText = "Total";
            this.dgvtotal.MinimumWidth = 100;
            this.dgvtotal.Name = "dgvtotal";
            this.dgvtotal.ReadOnly = true;
            // 
            // dgvreceived
            // 
            this.dgvreceived.DataPropertyName = "received";
            this.dgvreceived.HeaderText = "Received";
            this.dgvreceived.MinimumWidth = 100;
            this.dgvreceived.Name = "dgvreceived";
            this.dgvreceived.ReadOnly = true;
            // 
            // dgvchange
            // 
            this.dgvchange.DataPropertyName = "change";
            this.dgvchange.HeaderText = "Change";
            this.dgvchange.MinimumWidth = 100;
            this.dgvchange.Name = "dgvchange";
            this.dgvchange.ReadOnly = true;
            // 
            // dgvstatus
            // 
            this.dgvstatus.DataPropertyName = "status";
            this.dgvstatus.HeaderText = "Status";
            this.dgvstatus.MinimumWidth = 100;
            this.dgvstatus.Name = "dgvstatus";
            this.dgvstatus.ReadOnly = true;
            // 
            // dgvview
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.dgvview.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dgvview.HeaderText = "";
            this.dgvview.MinimumWidth = 100;
            this.dgvview.Name = "dgvview";
            this.dgvview.ReadOnly = true;
            this.dgvview.Text = "View";
            this.dgvview.UseColumnTextForButtonValue = true;
            // 
            // FormOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 540);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgvcategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormOrderList";
            this.Text = "FormOrderList";
            this.Load += new System.EventHandler(this.FormOrderList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgvcategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvdatetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvordertype;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvreceived;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvchange;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvstatus;
        private System.Windows.Forms.DataGridViewButtonColumn dgvview;
    }
}