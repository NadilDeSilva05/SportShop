namespace CW_oder_process
{
    partial class mlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mlogin));
            this.mbck = new System.Windows.Forms.Button();
            this.mlo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.munj = new System.Windows.Forms.Label();
            this.mun = new System.Windows.Forms.TextBox();
            this.mpw = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mbck
            // 
            this.mbck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbck.Location = new System.Drawing.Point(63, 194);
            this.mbck.Margin = new System.Windows.Forms.Padding(2);
            this.mbck.Name = "mbck";
            this.mbck.Size = new System.Drawing.Size(84, 32);
            this.mbck.TabIndex = 0;
            this.mbck.Text = "BACK";
            this.mbck.UseVisualStyleBackColor = true;
            this.mbck.Click += new System.EventHandler(this.mbck_Click);
            // 
            // mlo
            // 
            this.mlo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mlo.Location = new System.Drawing.Point(352, 194);
            this.mlo.Margin = new System.Windows.Forms.Padding(2);
            this.mlo.Name = "mlo";
            this.mlo.Size = new System.Drawing.Size(77, 32);
            this.mlo.TabIndex = 1;
            this.mlo.Text = "LOGIN";
            this.mlo.UseVisualStyleBackColor = true;
            this.mlo.Click += new System.EventHandler(this.mlo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "PASSWORD";
            // 
            // munj
            // 
            this.munj.AutoSize = true;
            this.munj.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.munj.Location = new System.Drawing.Point(26, 30);
            this.munj.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.munj.Name = "munj";
            this.munj.Size = new System.Drawing.Size(154, 29);
            this.munj.TabIndex = 3;
            this.munj.Text = "USER NAME";
            // 
            // mun
            // 
            this.mun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mun.Location = new System.Drawing.Point(202, 11);
            this.mun.Margin = new System.Windows.Forms.Padding(2);
            this.mun.Multiline = true;
            this.mun.Name = "mun";
            this.mun.Size = new System.Drawing.Size(261, 54);
            this.mun.TabIndex = 4;
            this.mun.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mpw
            // 
            this.mpw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mpw.Location = new System.Drawing.Point(202, 119);
            this.mpw.Margin = new System.Windows.Forms.Padding(2);
            this.mpw.Multiline = true;
            this.mpw.Name = "mpw";
            this.mpw.PasswordChar = '*';
            this.mpw.Size = new System.Drawing.Size(261, 54);
            this.mpw.TabIndex = 6;
            this.mpw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(495, 254);
            this.Controls.Add(this.mpw);
            this.Controls.Add(this.mun);
            this.Controls.Add(this.munj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mlo);
            this.Controls.Add(this.mbck);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "mlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mlogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mbck;
        private System.Windows.Forms.Button mlo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label munj;
        private System.Windows.Forms.TextBox mun;
        private System.Windows.Forms.TextBox mpw;
    }
}