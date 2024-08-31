namespace CW_oder_process
{
    partial class cusreg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cusreg));
            this.order = new System.Windows.Forms.Button();
            this.view = new System.Windows.Forms.Button();
            this.back1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // order
            // 
            this.order.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order.Location = new System.Drawing.Point(26, 210);
            this.order.Margin = new System.Windows.Forms.Padding(2);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(178, 60);
            this.order.TabIndex = 0;
            this.order.Text = "Get Order";
            this.order.UseVisualStyleBackColor = true;
            this.order.Click += new System.EventHandler(this.order_Click);
            // 
            // view
            // 
            this.view.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view.Location = new System.Drawing.Point(264, 210);
            this.view.Margin = new System.Windows.Forms.Padding(2);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(178, 60);
            this.view.TabIndex = 1;
            this.view.Text = "View Price";
            this.view.UseVisualStyleBackColor = true;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // back1
            // 
            this.back1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back1.Location = new System.Drawing.Point(497, 210);
            this.back1.Margin = new System.Windows.Forms.Padding(2);
            this.back1.Name = "back1";
            this.back1.Size = new System.Drawing.Size(178, 60);
            this.back1.TabIndex = 2;
            this.back1.Text = "BACK";
            this.back1.UseVisualStyleBackColor = true;
            this.back1.Click += new System.EventHandler(this.back1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Main Menu";
            // 
            // cusreg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(700, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back1);
            this.Controls.Add(this.view);
            this.Controls.Add(this.order);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "cusreg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cusreg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button order;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.Button back1;
        private System.Windows.Forms.Label label1;
    }
}