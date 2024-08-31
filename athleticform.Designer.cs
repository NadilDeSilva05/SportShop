namespace CW_oder_process
{
    partial class athleticform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(athleticform));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.acat = new System.Windows.Forms.ComboBox();
            this.aprice = new System.Windows.Forms.TextBox();
            this.atot = new System.Windows.Forms.TextBox();
            this.aqun = new System.Windows.Forms.NumericUpDown();
            this.aadd = new System.Windows.Forms.Button();
            this.aby = new System.Windows.Forms.Button();
            this.amenu = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.cid = new System.Windows.Forms.TextBox();
            this.quantity = new System.Windows.Forms.TextBox();
            this.fquantity = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.aqun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Catogory";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 141);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 197);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantity";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 262);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // acat
            // 
            this.acat.FormattingEnabled = true;
            this.acat.Location = new System.Drawing.Point(136, 91);
            this.acat.Margin = new System.Windows.Forms.Padding(2);
            this.acat.Name = "acat";
            this.acat.Size = new System.Drawing.Size(107, 25);
            this.acat.TabIndex = 4;
            this.acat.SelectedIndexChanged += new System.EventHandler(this.acat_SelectedIndexChanged);
            // 
            // aprice
            // 
            this.aprice.Location = new System.Drawing.Point(136, 141);
            this.aprice.Margin = new System.Windows.Forms.Padding(2);
            this.aprice.Name = "aprice";
            this.aprice.Size = new System.Drawing.Size(88, 23);
            this.aprice.TabIndex = 5;
            this.aprice.TextChanged += new System.EventHandler(this.aprice_TextChanged);
            // 
            // atot
            // 
            this.atot.Location = new System.Drawing.Point(136, 259);
            this.atot.Margin = new System.Windows.Forms.Padding(2);
            this.atot.Name = "atot";
            this.atot.Size = new System.Drawing.Size(88, 23);
            this.atot.TabIndex = 6;
            // 
            // aqun
            // 
            this.aqun.Location = new System.Drawing.Point(136, 197);
            this.aqun.Margin = new System.Windows.Forms.Padding(2);
            this.aqun.Name = "aqun";
            this.aqun.Size = new System.Drawing.Size(105, 23);
            this.aqun.TabIndex = 7;
            // 
            // aadd
            // 
            this.aadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aadd.Location = new System.Drawing.Point(39, 320);
            this.aadd.Margin = new System.Windows.Forms.Padding(2);
            this.aadd.Name = "aadd";
            this.aadd.Size = new System.Drawing.Size(70, 35);
            this.aadd.TabIndex = 8;
            this.aadd.Text = "Add To";
            this.aadd.UseVisualStyleBackColor = true;
            this.aadd.Click += new System.EventHandler(this.aadd_Click);
            // 
            // aby
            // 
            this.aby.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aby.Location = new System.Drawing.Point(188, 320);
            this.aby.Margin = new System.Windows.Forms.Padding(2);
            this.aby.Name = "aby";
            this.aby.Size = new System.Drawing.Size(93, 35);
            this.aby.TabIndex = 9;
            this.aby.Text = "Buy Now";
            this.aby.UseVisualStyleBackColor = true;
            this.aby.Click += new System.EventHandler(this.aby_Click);
            // 
            // amenu
            // 
            this.amenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amenu.Location = new System.Drawing.Point(363, 320);
            this.amenu.Margin = new System.Windows.Forms.Padding(2);
            this.amenu.Name = "amenu";
            this.amenu.Size = new System.Drawing.Size(103, 35);
            this.amenu.TabIndex = 10;
            this.amenu.Text = "Back";
            this.amenu.UseVisualStyleBackColor = true;
            this.amenu.Click += new System.EventHandler(this.amenu_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(262, 37);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(384, 255);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 45);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Customer Id";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cid
            // 
            this.cid.Location = new System.Drawing.Point(136, 38);
            this.cid.Margin = new System.Windows.Forms.Padding(2);
            this.cid.Name = "cid";
            this.cid.Size = new System.Drawing.Size(88, 23);
            this.cid.TabIndex = 13;
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(534, 296);
            this.quantity.Margin = new System.Windows.Forms.Padding(2);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(88, 23);
            this.quantity.TabIndex = 16;
            // 
            // fquantity
            // 
            this.fquantity.Location = new System.Drawing.Point(534, 338);
            this.fquantity.Margin = new System.Windows.Forms.Padding(2);
            this.fquantity.Name = "fquantity";
            this.fquantity.Size = new System.Drawing.Size(88, 23);
            this.fquantity.TabIndex = 17;
            // 
            // athleticform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(652, 366);
            this.Controls.Add(this.fquantity);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.cid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.amenu);
            this.Controls.Add(this.aby);
            this.Controls.Add(this.aadd);
            this.Controls.Add(this.aqun);
            this.Controls.Add(this.atot);
            this.Controls.Add(this.aprice);
            this.Controls.Add(this.acat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "athleticform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "athleticform";
            this.Load += new System.EventHandler(this.athleticform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aqun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox acat;
        private System.Windows.Forms.TextBox aprice;
        private System.Windows.Forms.TextBox atot;
        private System.Windows.Forms.NumericUpDown aqun;
        private System.Windows.Forms.Button aadd;
        private System.Windows.Forms.Button aby;
        private System.Windows.Forms.Button amenu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cid;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.TextBox fquantity;
    }
}