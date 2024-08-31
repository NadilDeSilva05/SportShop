namespace CW_oder_process
{
    partial class netballform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(netballform));
            this.ncat = new System.Windows.Forms.Label();
            this.ntep = new System.Windows.Forms.Label();
            this.netq = new System.Windows.Forms.Label();
            this.nettot = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.netadd = new System.Windows.Forms.Button();
            this.netbuy = new System.Windows.Forms.Button();
            this.netmain = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cid = new System.Windows.Forms.TextBox();
            this.quantity = new System.Windows.Forms.TextBox();
            this.fquantity = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ncat
            // 
            this.ncat.AutoSize = true;
            this.ncat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ncat.Location = new System.Drawing.Point(11, 94);
            this.ncat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ncat.Name = "ncat";
            this.ncat.Size = new System.Drawing.Size(73, 17);
            this.ncat.TabIndex = 0;
            this.ncat.Text = "Category";
            // 
            // ntep
            // 
            this.ntep.AutoSize = true;
            this.ntep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ntep.Location = new System.Drawing.Point(11, 155);
            this.ntep.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ntep.Name = "ntep";
            this.ntep.Size = new System.Drawing.Size(45, 17);
            this.ntep.TabIndex = 1;
            this.ntep.Text = "Price";
            // 
            // netq
            // 
            this.netq.AutoSize = true;
            this.netq.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netq.Location = new System.Drawing.Point(11, 215);
            this.netq.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.netq.Name = "netq";
            this.netq.Size = new System.Drawing.Size(69, 17);
            this.netq.TabIndex = 2;
            this.netq.Text = "Quantity";
            // 
            // nettot
            // 
            this.nettot.AutoSize = true;
            this.nettot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nettot.Location = new System.Drawing.Point(11, 274);
            this.nettot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nettot.Name = "nettot";
            this.nettot.Size = new System.Drawing.Size(45, 17);
            this.nettot.TabIndex = 3;
            this.nettot.Text = "Total";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(137, 91);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(107, 25);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(137, 152);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(88, 23);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(139, 215);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(105, 23);
            this.numericUpDown1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(137, 274);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(88, 23);
            this.textBox2.TabIndex = 7;
            // 
            // netadd
            // 
            this.netadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netadd.Location = new System.Drawing.Point(16, 325);
            this.netadd.Margin = new System.Windows.Forms.Padding(2);
            this.netadd.Name = "netadd";
            this.netadd.Size = new System.Drawing.Size(69, 28);
            this.netadd.TabIndex = 8;
            this.netadd.Text = "Add To";
            this.netadd.UseVisualStyleBackColor = true;
            this.netadd.Click += new System.EventHandler(this.netadd_Click);
            // 
            // netbuy
            // 
            this.netbuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netbuy.Location = new System.Drawing.Point(165, 327);
            this.netbuy.Margin = new System.Windows.Forms.Padding(2);
            this.netbuy.Name = "netbuy";
            this.netbuy.Size = new System.Drawing.Size(79, 28);
            this.netbuy.TabIndex = 9;
            this.netbuy.Text = "Buy Now";
            this.netbuy.UseVisualStyleBackColor = true;
            this.netbuy.Click += new System.EventHandler(this.netbuy_Click);
            // 
            // netmain
            // 
            this.netmain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netmain.Location = new System.Drawing.Point(294, 325);
            this.netmain.Margin = new System.Windows.Forms.Padding(2);
            this.netmain.Name = "netmain";
            this.netmain.Size = new System.Drawing.Size(85, 28);
            this.netmain.TabIndex = 10;
            this.netmain.Text = "Back";
            this.netmain.UseVisualStyleBackColor = true;
            this.netmain.Click += new System.EventHandler(this.netmain_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(267, 11);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(331, 257);
            this.dataGridView1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Customer Id";
            // 
            // cid
            // 
            this.cid.Location = new System.Drawing.Point(137, 30);
            this.cid.Margin = new System.Windows.Forms.Padding(2);
            this.cid.Name = "cid";
            this.cid.Size = new System.Drawing.Size(88, 23);
            this.cid.TabIndex = 13;
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(458, 289);
            this.quantity.Margin = new System.Windows.Forms.Padding(2);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(88, 23);
            this.quantity.TabIndex = 16;
            // 
            // fquantity
            // 
            this.fquantity.Location = new System.Drawing.Point(458, 335);
            this.fquantity.Margin = new System.Windows.Forms.Padding(2);
            this.fquantity.Name = "fquantity";
            this.fquantity.Size = new System.Drawing.Size(88, 23);
            this.fquantity.TabIndex = 17;
            // 
            // netballform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(607, 385);
            this.Controls.Add(this.fquantity);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.cid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.netmain);
            this.Controls.Add(this.netbuy);
            this.Controls.Add(this.netadd);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.nettot);
            this.Controls.Add(this.netq);
            this.Controls.Add(this.ntep);
            this.Controls.Add(this.ncat);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "netballform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "netballform";
            this.Load += new System.EventHandler(this.netballform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ncat;
        private System.Windows.Forms.Label ntep;
        private System.Windows.Forms.Label netq;
        private System.Windows.Forms.Label nettot;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button netadd;
        private System.Windows.Forms.Button netbuy;
        private System.Windows.Forms.Button netmain;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cid;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.TextBox fquantity;
    }
}