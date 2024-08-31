namespace CW_oder_process
{
    partial class swimmingform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(swimmingform));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.swcat = new System.Windows.Forms.ComboBox();
            this.swprice = new System.Windows.Forms.TextBox();
            this.swtot = new System.Windows.Forms.TextBox();
            this.swq = new System.Windows.Forms.NumericUpDown();
            this.swadd = new System.Windows.Forms.Button();
            this.swby = new System.Windows.Forms.Button();
            this.swmain = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.cid = new System.Windows.Forms.TextBox();
            this.quantity = new System.Windows.Forms.TextBox();
            this.fquantity = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.swq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Catogory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total";
            // 
            // swcat
            // 
            this.swcat.FormattingEnabled = true;
            this.swcat.Location = new System.Drawing.Point(208, 87);
            this.swcat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.swcat.Name = "swcat";
            this.swcat.Size = new System.Drawing.Size(121, 24);
            this.swcat.TabIndex = 4;
            this.swcat.SelectedIndexChanged += new System.EventHandler(this.swcat_SelectedIndexChanged);
            // 
            // swprice
            // 
            this.swprice.Location = new System.Drawing.Point(209, 146);
            this.swprice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.swprice.Name = "swprice";
            this.swprice.Size = new System.Drawing.Size(100, 22);
            this.swprice.TabIndex = 5;
            this.swprice.TextChanged += new System.EventHandler(this.swprice_TextChanged);
            // 
            // swtot
            // 
            this.swtot.Location = new System.Drawing.Point(209, 308);
            this.swtot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.swtot.Name = "swtot";
            this.swtot.Size = new System.Drawing.Size(100, 22);
            this.swtot.TabIndex = 6;
            // 
            // swq
            // 
            this.swq.Location = new System.Drawing.Point(209, 222);
            this.swq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.swq.Name = "swq";
            this.swq.Size = new System.Drawing.Size(120, 22);
            this.swq.TabIndex = 7;
            // 
            // swadd
            // 
            this.swadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swadd.Location = new System.Drawing.Point(39, 370);
            this.swadd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.swadd.Name = "swadd";
            this.swadd.Size = new System.Drawing.Size(75, 32);
            this.swadd.TabIndex = 8;
            this.swadd.Text = "Add To";
            this.swadd.UseVisualStyleBackColor = true;
            this.swadd.Click += new System.EventHandler(this.swadd_Click);
            // 
            // swby
            // 
            this.swby.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swby.Location = new System.Drawing.Point(253, 370);
            this.swby.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.swby.Name = "swby";
            this.swby.Size = new System.Drawing.Size(91, 32);
            this.swby.TabIndex = 9;
            this.swby.Text = "Buy Now";
            this.swby.UseVisualStyleBackColor = true;
            this.swby.Click += new System.EventHandler(this.swby_Click);
            // 
            // swmain
            // 
            this.swmain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swmain.Location = new System.Drawing.Point(475, 370);
            this.swmain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.swmain.Name = "swmain";
            this.swmain.Size = new System.Drawing.Size(103, 32);
            this.swmain.TabIndex = 10;
            this.swmain.Text = "Back";
            this.swmain.UseVisualStyleBackColor = true;
            this.swmain.Click += new System.EventHandler(this.swmain_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(353, 12);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(435, 302);
            this.dataGridView1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Customer Id";
            // 
            // cid
            // 
            this.cid.Location = new System.Drawing.Point(208, 31);
            this.cid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cid.Name = "cid";
            this.cid.Size = new System.Drawing.Size(100, 22);
            this.cid.TabIndex = 13;
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(652, 337);
            this.quantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(100, 22);
            this.quantity.TabIndex = 16;
            // 
            // fquantity
            // 
            this.fquantity.Location = new System.Drawing.Point(652, 396);
            this.fquantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fquantity.Name = "fquantity";
            this.fquantity.Size = new System.Drawing.Size(100, 22);
            this.fquantity.TabIndex = 17;
            // 
            // swimmingform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fquantity);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.cid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.swmain);
            this.Controls.Add(this.swby);
            this.Controls.Add(this.swadd);
            this.Controls.Add(this.swq);
            this.Controls.Add(this.swtot);
            this.Controls.Add(this.swprice);
            this.Controls.Add(this.swcat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "swimmingform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "swimmingform";
            this.Load += new System.EventHandler(this.swimmingform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.swq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox swcat;
        private System.Windows.Forms.TextBox swprice;
        private System.Windows.Forms.TextBox swtot;
        private System.Windows.Forms.NumericUpDown swq;
        private System.Windows.Forms.Button swadd;
        private System.Windows.Forms.Button swby;
        private System.Windows.Forms.Button swmain;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cid;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.TextBox fquantity;
    }
}