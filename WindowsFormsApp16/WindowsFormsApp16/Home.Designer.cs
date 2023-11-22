namespace WindowsFormsApp16
{
    partial class Home
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pendaftaran = new System.Windows.Forms.LinkLabel();
            this.About = new System.Windows.Forms.LinkLabel();
            this.Peraturan = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp16.Properties.Resources.Desain_tanpa_judul__7_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(803, 453);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(-10, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(813, 54);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pendaftaran
            // 
            this.pendaftaran.AutoSize = true;
            this.pendaftaran.Location = new System.Drawing.Point(245, 21);
            this.pendaftaran.Name = "pendaftaran";
            this.pendaftaran.Size = new System.Drawing.Size(80, 16);
            this.pendaftaran.TabIndex = 2;
            this.pendaftaran.TabStop = true;
            this.pendaftaran.Text = "Pendaftaran";
            this.pendaftaran.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.pendaftaran_LinkClicked);
            // 
            // About
            // 
            this.About.AutoSize = true;
            this.About.Location = new System.Drawing.Point(368, 21);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(42, 16);
            this.About.TabIndex = 3;
            this.About.TabStop = true;
            this.About.Text = "About";
            // 
            // Peraturan
            // 
            this.Peraturan.AutoSize = true;
            this.Peraturan.Location = new System.Drawing.Point(458, 21);
            this.Peraturan.Name = "Peraturan";
            this.Peraturan.Size = new System.Drawing.Size(65, 16);
            this.Peraturan.TabIndex = 4;
            this.Peraturan.TabStop = true;
            this.Peraturan.Text = "Peraturan";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Peraturan);
            this.Controls.Add(this.About);
            this.Controls.Add(this.pendaftaran);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Home";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel pendaftaran;
        private System.Windows.Forms.LinkLabel About;
        private System.Windows.Forms.LinkLabel Peraturan;
    }
}