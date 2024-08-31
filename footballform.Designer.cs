namespace CW_oder_process
{
    partial class footballform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(footballform));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fcat = new System.Windows.Forms.ComboBox();
            this.fprice = new System.Windows.Forms.TextBox();
            this.fq = new System.Windows.Forms.NumericUpDown();
            this.ftot = new System.Windows.Forms.TextBox();
            this.fadd = new System.Windows.Forms.Button();
            this.fbuy = new System.Windows.Forms.Button();
            this.fmenu = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.cid = new System.Windows.Forms.TextBox();
            this.quantity = new System.Windows.Forms.TextBox();
            this.fquantity = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Caregory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 131);
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
            this.label3.Location = new System.Drawing.Point(14, 194);
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
            this.label4.Location = new System.Drawing.Point(11, 250);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total";
            // 
            // fcat
            // 
            this.fcat.FormattingEnabled = true;
            this.fcat.Location = new System.Drawing.Point(120, 78);
            this.fcat.Margin = new System.Windows.Forms.Padding(2);
            this.fcat.Name = "fcat";
            this.fcat.Size = new System.Drawing.Size(107, 25);
            this.fcat.TabIndex = 4;
            this.fcat.SelectedIndexChanged += new System.EventHandler(this.fcat_SelectedIndexChanged);
            // 
            // fprice
            // 
            this.fprice.Location = new System.Drawing.Point(120, 124);
            this.fprice.Margin = new System.Windows.Forms.Padding(2);
            this.fprice.Name = "fprice";
            this.fprice.Size = new System.Drawing.Size(88, 23);
            this.fprice.TabIndex = 5;
            this.fprice.TextChanged += new System.EventHandler(this.fprice_TextChanged);
            // 
            // fq
            // 
            this.fq.Location = new System.Drawing.Point(122, 192);
            this.fq.Margin = new System.Windows.Forms.Padding(2);
            this.fq.Name = "fq";
            this.fq.Size = new System.Drawing.Size(105, 23);
            this.fq.TabIndex = 6;
            // 
            // ftot
            // 
            this.ftot.Location = new System.Drawing.Point(122, 243);
            this.ftot.Margin = new System.Windows.Forms.Padding(2);
            this.ftot.Name = "ftot";
            this.ftot.Size = new System.Drawing.Size(88, 23);
            this.ftot.TabIndex = 7;
            // 
            // fadd
            // 
            this.fadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fadd.Location = new System.Drawing.Point(14, 306);
            this.fadd.Margin = new System.Windows.Forms.Padding(2);
            this.fadd.Name = "fadd";
            this.fadd.Size = new System.Drawing.Size(86, 33);
            this.fadd.TabIndex = 8;
            this.fadd.Text = "Add To";
            this.fadd.UseVisualStyleBackColor = true;
            this.fadd.Click += new System.EventHandler(this.fadd_Click);
            // 
            // fbuy
            // 
            this.fbuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fbuy.Location = new System.Drawing.Point(144, 306);
            this.fbuy.Margin = new System.Windows.Forms.Padding(2);
            this.fbuy.Name = "fbuy";
            this.fbuy.Size = new System.Drawing.Size(83, 33);
            this.fbuy.TabIndex = 9;
            this.fbuy.Text = "Buy Now";
            this.fbuy.UseVisualStyleBackColor = true;
            this.fbuy.Click += new System.EventHandler(this.fbuy_Click);
            // 
            // fmenu
            // 
            this.fmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fmenu.Location = new System.Drawing.Point(279, 306);
            this.fmenu.Margin = new System.Windows.Forms.Padding(2);
            this.fmenu.Name = "fmenu";
            this.fmenu.Size = new System.Drawing.Size(96, 33);
            this.fmenu.TabIndex = 10;
            this.fmenu.Text = "Back";
            this.fmenu.UseVisualStyleBackColor = true;
            this.fmenu.Click += new System.EventHandler(this.fmenu_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(240, 11);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(357, 228);
            this.dataGridView1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Customer Id";
            // 
            // cid
            // 
            this.cid.Location = new System.Drawing.Point(120, 32);
            this.cid.Margin = new System.Windows.Forms.Padding(2);
            this.cid.Name = "cid";
            this.cid.Size = new System.Drawing.Size(88, 23);
            this.cid.TabIndex = 13;
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(445, 260);
            this.quantity.Margin = new System.Windows.Forms.Padding(2);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(88, 23);
            this.quantity.TabIndex = 15;
            // 
            // fquantity
            // 
            this.fquantity.Location = new System.Drawing.Point(445, 313);
            this.fquantity.Margin = new System.Windows.Forms.Padding(2);
            this.fquantity.Name = "fquantity";
            this.fquantity.Size = new System.Drawing.Size(88, 23);
            this.fquantity.TabIndex = 16;
            // 
            // footballform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(604, 370);
            this.Controls.Add(this.fquantity);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.cid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.fmenu);
            this.Controls.Add(this.fbuy);
            this.Controls.Add(this.fadd);
            this.Controls.Add(this.ftot);
            this.Controls.Add(this.fq);
            this.Controls.Add(this.fprice);
            this.Controls.Add(this.fcat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "footballform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "footballform";
            this.Load += new System.EventHandler(this.footballform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox fcat;
        private System.Windows.Forms.TextBox fprice;
        private System.Windows.Forms.NumericUpDown fq;
        private System.Windows.Forms.TextBox ftot;
        private System.Windows.Forms.Button fadd;
        private System.Windows.Forms.Button fbuy;
        private System.Windows.Forms.Button fmenu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cid;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.TextBox fquantity;
    }
}