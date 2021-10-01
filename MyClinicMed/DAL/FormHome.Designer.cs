
namespace MyClinicMed
{
    partial class FormHome
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
            this.paneHome = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.paneHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // paneHome
            // 
            this.paneHome.BackColor = System.Drawing.Color.White;
            this.paneHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.paneHome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneHome.Controls.Add(this.pictureBox1);
            this.paneHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneHome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.paneHome.Location = new System.Drawing.Point(0, 0);
            this.paneHome.Name = "paneHome";
            this.paneHome.Size = new System.Drawing.Size(781, 564);
            this.paneHome.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyClinicMed.Properties.Resources.batimento_cardiaco__2_;
            this.pictureBox1.Location = new System.Drawing.Point(249, 173);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 242);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 564);
            this.Controls.Add(this.paneHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHome";
            this.Text = "FormHome";
            this.paneHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneHome;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}