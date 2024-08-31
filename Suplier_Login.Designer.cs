namespace CW_oder_process
{
    partial class Suplier_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Suplier_Login));
            this.cb = new System.Windows.Forms.Button();
            this.cpw = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cun = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb
            // 
            this.cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb.Location = new System.Drawing.Point(37, 190);
            this.cb.Margin = new System.Windows.Forms.Padding(2);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(96, 28);
            this.cb.TabIndex = 11;
            this.cb.Text = "BACK";
            this.cb.UseVisualStyleBackColor = true;
            this.cb.Click += new System.EventHandler(this.cb_Click);
            // 
            // cpw
            // 
            this.cpw.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpw.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cpw.Location = new System.Drawing.Point(216, 113);
            this.cpw.Margin = new System.Windows.Forms.Padding(2);
            this.cpw.Multiline = true;
            this.cpw.Name = "cpw";
            this.cpw.PasswordChar = '*';
            this.cpw.Size = new System.Drawing.Size(209, 43);
            this.cpw.TabIndex = 10;
            this.cpw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "PASSWORD";
            // 
            // cun
            // 
            this.cun.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cun.Location = new System.Drawing.Point(216, 21);
            this.cun.Margin = new System.Windows.Forms.Padding(2);
            this.cun.Multiline = true;
            this.cun.Name = "cun";
            this.cun.Size = new System.Drawing.Size(209, 43);
            this.cun.TabIndex = 8;
            this.cun.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "USER NAME";
            // 
            // cl
            // 
            this.cl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cl.Location = new System.Drawing.Point(216, 190);
            this.cl.Margin = new System.Windows.Forms.Padding(2);
            this.cl.Name = "cl";
            this.cl.Size = new System.Drawing.Size(86, 28);
            this.cl.TabIndex = 6;
            this.cl.Text = "LOGIN";
            this.cl.UseVisualStyleBackColor = true;
            this.cl.Click += new System.EventHandler(this.cl_Click);
            // 
            // Suplier_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(481, 238);
            this.Controls.Add(this.cb);
            this.Controls.Add(this.cpw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cun);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Suplier_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suplier_Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cb;
        private System.Windows.Forms.TextBox cpw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cl;
    }
}