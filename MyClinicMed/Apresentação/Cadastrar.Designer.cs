
namespace MyClinicMed
{
    partial class FmrCadastrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmrCadastrar));
            this.txtUsuarioCadastro = new System.Windows.Forms.TextBox();
            this.btmCadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSenhaCadastro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConfirmarSenha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtUsuarioCadastro
            // 
            this.txtUsuarioCadastro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioCadastro.Location = new System.Drawing.Point(91, 45);
            this.txtUsuarioCadastro.Name = "txtUsuarioCadastro";
            this.txtUsuarioCadastro.Size = new System.Drawing.Size(253, 27);
            this.txtUsuarioCadastro.TabIndex = 0;
            // 
            // btmCadastrar
            // 
            this.btmCadastrar.BackColor = System.Drawing.Color.LightGray;
            this.btmCadastrar.FlatAppearance.BorderSize = 0;
            this.btmCadastrar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmCadastrar.Location = new System.Drawing.Point(117, 254);
            this.btmCadastrar.Name = "btmCadastrar";
            this.btmCadastrar.Size = new System.Drawing.Size(195, 45);
            this.btmCadastrar.TabIndex = 3;
            this.btmCadastrar.Text = "Cadastrar";
            this.btmCadastrar.UseVisualStyleBackColor = false;
            this.btmCadastrar.Click += new System.EventHandler(this.btmCadastrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario";
            // 
            // txtSenhaCadastro
            // 
            this.txtSenhaCadastro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaCadastro.Location = new System.Drawing.Point(91, 122);
            this.txtSenhaCadastro.Name = "txtSenhaCadastro";
            this.txtSenhaCadastro.Size = new System.Drawing.Size(253, 27);
            this.txtSenhaCadastro.TabIndex = 1;
            this.txtSenhaCadastro.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Senha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "Confirmar Senha:";
            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarSenha.Location = new System.Drawing.Point(93, 199);
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.Size = new System.Drawing.Size(253, 27);
            this.txtConfirmarSenha.TabIndex = 5;
            this.txtConfirmarSenha.UseSystemPasswordChar = true;
            // 
            // FmrCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(200)))), ((int)(((byte)(234)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(435, 311);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtConfirmarSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSenhaCadastro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btmCadastrar);
            this.Controls.Add(this.txtUsuarioCadastro);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(451, 350);
            this.MinimumSize = new System.Drawing.Size(451, 350);
            this.Name = "FmrCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuarioCadastro;
        private System.Windows.Forms.Button btmCadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSenhaCadastro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConfirmarSenha;
    }
}