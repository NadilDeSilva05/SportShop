namespace CW_oder_process
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.FMC = new System.Windows.Forms.Button();
            this.FMM = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.suplier = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FMC
            // 
            this.FMC.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FMC.Location = new System.Drawing.Point(21, 345);
            this.FMC.Name = "FMC";
            this.FMC.Size = new System.Drawing.Size(177, 92);
            this.FMC.TabIndex = 1;
            this.FMC.Text = "CASHIER";
            this.FMC.UseVisualStyleBackColor = true;
            this.FMC.Click += new System.EventHandler(this.FMC_Click);
            // 
            // FMM
            // 
            this.FMM.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FMM.Location = new System.Drawing.Point(257, 343);
            this.FMM.Name = "FMM";
            this.FMM.Size = new System.Drawing.Size(177, 96);
            this.FMM.TabIndex = 2;
            this.FMM.Text = "MANAGER";
            this.FMM.UseVisualStyleBackColor = true;
            this.FMM.Click += new System.EventHandler(this.FMM_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1048, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 92);
            this.button1.TabIndex = 3;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // suplier
            // 
            this.suplier.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suplier.Location = new System.Drawing.Point(506, 347);
            this.suplier.Name = "suplier";
            this.suplier.Size = new System.Drawing.Size(159, 92);
            this.suplier.TabIndex = 4;
            this.suplier.Text = "SUPPLIER";
            this.suplier.UseVisualStyleBackColor = true;
            this.suplier.Click += new System.EventHandler(this.suplier_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(744, 343);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 92);
            this.button2.TabIndex = 7;
            this.button2.Text = "EXIT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 76);
            this.label1.TabIndex = 8;
            this.label1.Text = "WELCOME";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(948, 560);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.suplier);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FMM);
            this.Controls.Add(this.FMC);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button FMC;
        private System.Windows.Forms.Button FMM;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button suplier;
		private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}

