namespace CW_oder_process
{
    partial class supply
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(supply));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.catergory = new System.Windows.Forms.ComboBox();
            this.item = new System.Windows.Forms.ComboBox();
            this.quntity = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Cqun = new System.Windows.Forms.TextBox();
            this.fqun = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.quntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Supply Quantity";
            // 
            // catergory
            // 
            this.catergory.FormattingEnabled = true;
            this.catergory.Items.AddRange(new object[] {
            "badminton",
            "athletics",
            "cricket",
            "football",
            "natball1",
            "swimming"});
            this.catergory.Location = new System.Drawing.Point(152, 34);
            this.catergory.Margin = new System.Windows.Forms.Padding(2);
            this.catergory.Name = "catergory";
            this.catergory.Size = new System.Drawing.Size(107, 25);
            this.catergory.TabIndex = 3;
            this.catergory.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // item
            // 
            this.item.FormattingEnabled = true;
            this.item.Location = new System.Drawing.Point(152, 83);
            this.item.Margin = new System.Windows.Forms.Padding(2);
            this.item.Name = "item";
            this.item.Size = new System.Drawing.Size(107, 25);
            this.item.TabIndex = 4;
            this.item.SelectedIndexChanged += new System.EventHandler(this.item_SelectedIndexChanged);
            // 
            // quntity
            // 
            this.quntity.Location = new System.Drawing.Point(153, 138);
            this.quntity.Margin = new System.Windows.Forms.Padding(2);
            this.quntity.Name = "quntity";
            this.quntity.Size = new System.Drawing.Size(105, 23);
            this.quntity.TabIndex = 5;
            this.quntity.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(321, 11);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(351, 84);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 54);
            this.button1.TabIndex = 7;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(338, 221);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 54);
            this.button2.TabIndex = 8;
            this.button2.Text = "ADD PRODUCT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Cqun
            // 
            this.Cqun.Location = new System.Drawing.Point(12, 321);
            this.Cqun.Name = "Cqun";
            this.Cqun.Size = new System.Drawing.Size(72, 23);
            this.Cqun.TabIndex = 9;
            this.Cqun.TextChanged += new System.EventHandler(this.Cqun_TextChanged);
            // 
            // fqun
            // 
            this.fqun.Location = new System.Drawing.Point(152, 321);
            this.fqun.Name = "fqun";
            this.fqun.Size = new System.Drawing.Size(72, 23);
            this.fqun.TabIndex = 10;
            // 
            // supply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(700, 366);
            this.Controls.Add(this.fqun);
            this.Controls.Add(this.Cqun);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.quntity);
            this.Controls.Add(this.item);
            this.Controls.Add(this.catergory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "supply";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "supply";
            this.Load += new System.EventHandler(this.supply_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox catergory;
        private System.Windows.Forms.ComboBox item;
        private System.Windows.Forms.NumericUpDown quntity;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Cqun;
        private System.Windows.Forms.TextBox fqun;
    }
}