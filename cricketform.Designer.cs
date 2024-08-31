namespace CW_oder_process
{
    partial class cricketform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cricketform));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cat = new System.Windows.Forms.ComboBox();
            this.ccprice = new System.Windows.Forms.TextBox();
            this.cqunn = new System.Windows.Forms.NumericUpDown();
            this.ctot = new System.Windows.Forms.Label();
            this.tott = new System.Windows.Forms.TextBox();
            this.cadd = new System.Windows.Forms.Button();
            this.cbuy = new System.Windows.Forms.Button();
            this.cm = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.ciii = new System.Windows.Forms.TextBox();
            this.quantity = new System.Windows.Forms.TextBox();
            this.fquantity = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.cqunn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 119);
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
            this.label3.Location = new System.Drawing.Point(22, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantity";
            // 
            // cat
            // 
            this.cat.FormattingEnabled = true;
            this.cat.Location = new System.Drawing.Point(145, 71);
            this.cat.Margin = new System.Windows.Forms.Padding(2);
            this.cat.Name = "cat";
            this.cat.Size = new System.Drawing.Size(107, 25);
            this.cat.TabIndex = 3;
            this.cat.SelectedIndexChanged += new System.EventHandler(this.ccatergory_SelectedIndexChanged);
            // 
            // ccprice
            // 
            this.ccprice.Location = new System.Drawing.Point(145, 119);
            this.ccprice.Margin = new System.Windows.Forms.Padding(2);
            this.ccprice.Name = "ccprice";
            this.ccprice.Size = new System.Drawing.Size(88, 23);
            this.ccprice.TabIndex = 4;
            this.ccprice.TextChanged += new System.EventHandler(this.ccprice_TextChanged);
            // 
            // cqunn
            // 
            this.cqunn.Location = new System.Drawing.Point(145, 175);
            this.cqunn.Margin = new System.Windows.Forms.Padding(2);
            this.cqunn.Name = "cqunn";
            this.cqunn.Size = new System.Drawing.Size(105, 23);
            this.cqunn.TabIndex = 5;
            this.cqunn.ValueChanged += new System.EventHandler(this.cqun_ValueChanged);
            // 
            // ctot
            // 
            this.ctot.AutoSize = true;
            this.ctot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctot.Location = new System.Drawing.Point(22, 243);
            this.ctot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ctot.Name = "ctot";
            this.ctot.Size = new System.Drawing.Size(45, 17);
            this.ctot.TabIndex = 6;
            this.ctot.Text = "Total";
            // 
            // tott
            // 
            this.tott.Location = new System.Drawing.Point(145, 243);
            this.tott.Margin = new System.Windows.Forms.Padding(2);
            this.tott.Name = "tott";
            this.tott.Size = new System.Drawing.Size(88, 23);
            this.tott.TabIndex = 7;
            this.tott.TextChanged += new System.EventHandler(this.ctot1_TextChanged);
            // 
            // cadd
            // 
            this.cadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadd.Location = new System.Drawing.Point(31, 309);
            this.cadd.Margin = new System.Windows.Forms.Padding(2);
            this.cadd.Name = "cadd";
            this.cadd.Size = new System.Drawing.Size(65, 28);
            this.cadd.TabIndex = 8;
            this.cadd.Text = "Add To";
            this.cadd.UseVisualStyleBackColor = true;
            this.cadd.Click += new System.EventHandler(this.cadd_Click);
            // 
            // cbuy
            // 
            this.cbuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbuy.Location = new System.Drawing.Point(158, 309);
            this.cbuy.Margin = new System.Windows.Forms.Padding(2);
            this.cbuy.Name = "cbuy";
            this.cbuy.Size = new System.Drawing.Size(75, 28);
            this.cbuy.TabIndex = 9;
            this.cbuy.Text = "Buy Now";
            this.cbuy.UseVisualStyleBackColor = true;
            this.cbuy.Click += new System.EventHandler(this.cbuy_Click);
            // 
            // cm
            // 
            this.cm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cm.Location = new System.Drawing.Point(306, 309);
            this.cm.Margin = new System.Windows.Forms.Padding(2);
            this.cm.Name = "cm";
            this.cm.Size = new System.Drawing.Size(96, 28);
            this.cm.TabIndex = 10;
            this.cm.Text = "Back";
            this.cm.UseVisualStyleBackColor = true;
            this.cm.Click += new System.EventHandler(this.cm_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(281, 40);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(359, 193);
            this.dataGridView1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Customer Id";
            // 
            // ciii
            // 
            this.ciii.Location = new System.Drawing.Point(145, 28);
            this.ciii.Margin = new System.Windows.Forms.Padding(2);
            this.ciii.Name = "ciii";
            this.ciii.Size = new System.Drawing.Size(88, 23);
            this.ciii.TabIndex = 13;
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(492, 266);
            this.quantity.Margin = new System.Windows.Forms.Padding(2);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(88, 23);
            this.quantity.TabIndex = 16;
            // 
            // fquantity
            // 
            this.fquantity.Location = new System.Drawing.Point(492, 309);
            this.fquantity.Margin = new System.Windows.Forms.Padding(2);
            this.fquantity.Name = "fquantity";
            this.fquantity.Size = new System.Drawing.Size(88, 23);
            this.fquantity.TabIndex = 17;
            // 
            // cricketform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(655, 354);
            this.Controls.Add(this.fquantity);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.ciii);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cm);
            this.Controls.Add(this.cbuy);
            this.Controls.Add(this.cadd);
            this.Controls.Add(this.tott);
            this.Controls.Add(this.ctot);
            this.Controls.Add(this.cqunn);
            this.Controls.Add(this.ccprice);
            this.Controls.Add(this.cat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "cricketform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cricketform";
            this.Load += new System.EventHandler(this.cricketform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cqunn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cat;
        private System.Windows.Forms.TextBox ccprice;
        private System.Windows.Forms.NumericUpDown cqunn;
        private System.Windows.Forms.Label ctot;
        private System.Windows.Forms.TextBox tott;
        private System.Windows.Forms.Button cadd;
        private System.Windows.Forms.Button cbuy;
        private System.Windows.Forms.Button cm;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ciii;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.TextBox fquantity;
    }
}