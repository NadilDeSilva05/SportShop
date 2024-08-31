namespace CW_oder_process
{
    partial class badmintionform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(badmintionform));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.badc = new System.Windows.Forms.ComboBox();
            this.badp = new System.Windows.Forms.TextBox();
            this.badq = new System.Windows.Forms.NumericUpDown();
            this.badtot = new System.Windows.Forms.TextBox();
            this.badadd = new System.Windows.Forms.Button();
            this.badbuy = new System.Windows.Forms.Button();
            this.badmain = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.TextBox();
            this.fquantity = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.badq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Catogory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 189);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 250);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total";
            // 
            // badc
            // 
            this.badc.FormattingEnabled = true;
            this.badc.Location = new System.Drawing.Point(186, 73);
            this.badc.Margin = new System.Windows.Forms.Padding(2);
            this.badc.Name = "badc";
            this.badc.Size = new System.Drawing.Size(107, 25);
            this.badc.TabIndex = 4;
            this.badc.SelectedIndexChanged += new System.EventHandler(this.badc_SelectedIndexChanged);
            // 
            // badp
            // 
            this.badp.Location = new System.Drawing.Point(187, 127);
            this.badp.Margin = new System.Windows.Forms.Padding(2);
            this.badp.Name = "badp";
            this.badp.Size = new System.Drawing.Size(88, 23);
            this.badp.TabIndex = 5;
            this.badp.TextChanged += new System.EventHandler(this.badp_TextChanged);
            // 
            // badq
            // 
            this.badq.Location = new System.Drawing.Point(187, 184);
            this.badq.Margin = new System.Windows.Forms.Padding(2);
            this.badq.Name = "badq";
            this.badq.Size = new System.Drawing.Size(105, 23);
            this.badq.TabIndex = 6;
            // 
            // badtot
            // 
            this.badtot.Location = new System.Drawing.Point(187, 245);
            this.badtot.Margin = new System.Windows.Forms.Padding(2);
            this.badtot.Name = "badtot";
            this.badtot.Size = new System.Drawing.Size(88, 23);
            this.badtot.TabIndex = 7;
            // 
            // badadd
            // 
            this.badadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.badadd.Location = new System.Drawing.Point(44, 301);
            this.badadd.Margin = new System.Windows.Forms.Padding(2);
            this.badadd.Name = "badadd";
            this.badadd.Size = new System.Drawing.Size(75, 30);
            this.badadd.TabIndex = 8;
            this.badadd.Text = "Add To";
            this.badadd.UseVisualStyleBackColor = true;
            this.badadd.Click += new System.EventHandler(this.badadd_Click);
            // 
            // badbuy
            // 
            this.badbuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.badbuy.Location = new System.Drawing.Point(198, 301);
            this.badbuy.Margin = new System.Windows.Forms.Padding(2);
            this.badbuy.Name = "badbuy";
            this.badbuy.Size = new System.Drawing.Size(75, 30);
            this.badbuy.TabIndex = 9;
            this.badbuy.Text = "Buy Now";
            this.badbuy.UseVisualStyleBackColor = true;
            this.badbuy.Click += new System.EventHandler(this.badbuy_Click);
            // 
            // badmain
            // 
            this.badmain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.badmain.Location = new System.Drawing.Point(345, 301);
            this.badmain.Margin = new System.Windows.Forms.Padding(2);
            this.badmain.Name = "badmain";
            this.badmain.Size = new System.Drawing.Size(114, 30);
            this.badmain.TabIndex = 10;
            this.badmain.Text = "Back";
            this.badmain.UseVisualStyleBackColor = true;
            this.badmain.Click += new System.EventHandler(this.badmain_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(324, 24);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(352, 222);
            this.dataGridView1.TabIndex = 11;
            // 
            // cid
            // 
            this.cid.Location = new System.Drawing.Point(187, 24);
            this.cid.Margin = new System.Windows.Forms.Padding(2);
            this.cid.Name = "cid";
            this.cid.Size = new System.Drawing.Size(88, 23);
            this.cid.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 29);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Customer Id";
            // 
            // quantity
            // 
            this.quantity.BackColor = System.Drawing.Color.White;
            this.quantity.Location = new System.Drawing.Point(517, 268);
            this.quantity.Margin = new System.Windows.Forms.Padding(2);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(88, 23);
            this.quantity.TabIndex = 16;
            this.quantity.TextChanged += new System.EventHandler(this.quantity_TextChanged);
            // 
            // fquantity
            // 
            this.fquantity.Location = new System.Drawing.Point(517, 314);
            this.fquantity.Margin = new System.Windows.Forms.Padding(2);
            this.fquantity.Name = "fquantity";
            this.fquantity.Size = new System.Drawing.Size(88, 23);
            this.fquantity.TabIndex = 17;
            // 
            // badmintionform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(700, 366);
            this.Controls.Add(this.fquantity);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cid);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.badmain);
            this.Controls.Add(this.badbuy);
            this.Controls.Add(this.badadd);
            this.Controls.Add(this.badtot);
            this.Controls.Add(this.badq);
            this.Controls.Add(this.badp);
            this.Controls.Add(this.badc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "badmintionform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.badmintionform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.badq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox badc;
        private System.Windows.Forms.TextBox badp;
        private System.Windows.Forms.NumericUpDown badq;
        private System.Windows.Forms.TextBox badtot;
        private System.Windows.Forms.Button badadd;
        private System.Windows.Forms.Button badbuy;
        private System.Windows.Forms.Button badmain;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox cid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.TextBox fquantity;
    }
}