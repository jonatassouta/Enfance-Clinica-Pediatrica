
namespace MyClinicMed
{
    partial class FormAlterar
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
            this.tbCliente = new System.Windows.Forms.TabControl();
            this.Clientes = new System.Windows.Forms.TabPage();
            this.tabMed = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefoneCliente = new System.Windows.Forms.MaskedTextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCpfCliente = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btmAlterar = new System.Windows.Forms.Button();
            this.btmCancel = new System.Windows.Forms.Button();
            this.tbCliente.SuspendLayout();
            this.Clientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCliente
            // 
            this.tbCliente.Controls.Add(this.Clientes);
            this.tbCliente.Controls.Add(this.tabMed);
            this.tbCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCliente.Location = new System.Drawing.Point(0, 0);
            this.tbCliente.Name = "tbCliente";
            this.tbCliente.SelectedIndex = 0;
            this.tbCliente.Size = new System.Drawing.Size(781, 564);
            this.tbCliente.TabIndex = 0;
            // 
            // Clientes
            // 
            this.Clientes.Controls.Add(this.btmCancel);
            this.Clientes.Controls.Add(this.btmAlterar);
            this.Clientes.Controls.Add(this.label5);
            this.Clientes.Controls.Add(this.lblCodigo);
            this.Clientes.Controls.Add(this.label4);
            this.Clientes.Controls.Add(this.txtTelefoneCliente);
            this.Clientes.Controls.Add(this.txtEndereco);
            this.Clientes.Controls.Add(this.label3);
            this.Clientes.Controls.Add(this.label2);
            this.Clientes.Controls.Add(this.txtCpfCliente);
            this.Clientes.Controls.Add(this.txtNomeCliente);
            this.Clientes.Controls.Add(this.label1);
            this.Clientes.Location = new System.Drawing.Point(4, 30);
            this.Clientes.Name = "Clientes";
            this.Clientes.Padding = new System.Windows.Forms.Padding(3);
            this.Clientes.Size = new System.Drawing.Size(773, 530);
            this.Clientes.TabIndex = 0;
            this.Clientes.Text = "Clientes";
            this.Clientes.UseVisualStyleBackColor = true;
            // 
            // tabMed
            // 
            this.tabMed.Location = new System.Drawing.Point(4, 30);
            this.tabMed.Name = "tabMed";
            this.tabMed.Padding = new System.Windows.Forms.Padding(3);
            this.tabMed.Size = new System.Drawing.Size(773, 530);
            this.tabMed.TabIndex = 1;
            this.tabMed.Text = "Médicos";
            this.tabMed.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "Telefone:";
            // 
            // txtTelefoneCliente
            // 
            this.txtTelefoneCliente.Location = new System.Drawing.Point(309, 254);
            this.txtTelefoneCliente.Mask = "(99) 00000-0000";
            this.txtTelefoneCliente.Name = "txtTelefoneCliente";
            this.txtTelefoneCliente.Size = new System.Drawing.Size(129, 27);
            this.txtTelefoneCliente.TabIndex = 15;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(309, 306);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(268, 27);
            this.txtEndereco.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Endereço: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "CPF:";
            // 
            // txtCpfCliente
            // 
            this.txtCpfCliente.Location = new System.Drawing.Point(309, 205);
            this.txtCpfCliente.Mask = "000.000.000-00";
            this.txtCpfCliente.Name = "txtCpfCliente";
            this.txtCpfCliente.Size = new System.Drawing.Size(129, 27);
            this.txtCpfCliente.TabIndex = 11;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(309, 154);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(268, 27);
            this.txtNomeCliente.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(233, 102);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(68, 21);
            this.lblCodigo.TabIndex = 17;
            this.lblCodigo.Text = "Código";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(208, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "ID:";
            // 
            // btmAlterar
            // 
            this.btmAlterar.Location = new System.Drawing.Point(273, 389);
            this.btmAlterar.Name = "btmAlterar";
            this.btmAlterar.Size = new System.Drawing.Size(95, 38);
            this.btmAlterar.TabIndex = 19;
            this.btmAlterar.Text = "Alterar";
            this.btmAlterar.UseVisualStyleBackColor = true;
            this.btmAlterar.Click += new System.EventHandler(this.btmAlterar_Click);
            // 
            // btmCancel
            // 
            this.btmCancel.Location = new System.Drawing.Point(408, 389);
            this.btmCancel.Name = "btmCancel";
            this.btmCancel.Size = new System.Drawing.Size(95, 38);
            this.btmCancel.TabIndex = 20;
            this.btmCancel.Text = "Cancelar";
            this.btmCancel.UseVisualStyleBackColor = true;
            // 
            // FormAlterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 564);
            this.Controls.Add(this.tbCliente);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FormAlterar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAlterar";
            this.tbCliente.ResumeLayout(false);
            this.Clientes.ResumeLayout(false);
            this.Clientes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbCliente;
        private System.Windows.Forms.TabPage Clientes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabMed;
        public System.Windows.Forms.MaskedTextBox txtTelefoneCliente;
        public System.Windows.Forms.TextBox txtEndereco;
        public System.Windows.Forms.MaskedTextBox txtCpfCliente;
        public System.Windows.Forms.TextBox txtNomeCliente;
        public System.Windows.Forms.Label lblCodigo;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btmCancel;
        private System.Windows.Forms.Button btmAlterar;
    }
}