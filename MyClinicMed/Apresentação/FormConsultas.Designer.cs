
namespace MyClinicMed
{
    partial class FormConsultas
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
            this.tabConsultas = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btmVisualizar = new System.Windows.Forms.Button();
            this.comboFiltro = new System.Windows.Forms.ComboBox();
            this.btmDeletar = new System.Windows.Forms.Button();
            this.btmAlterar = new System.Windows.Forms.Button();
            this.btmPesquisar = new System.Windows.Forms.Button();
            this.dgvPesquisa = new System.Windows.Forms.DataGridView();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.tabConsultas.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // tabConsultas
            // 
            this.tabConsultas.Controls.Add(this.tabPage2);
            this.tabConsultas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabConsultas.Location = new System.Drawing.Point(0, 0);
            this.tabConsultas.Name = "tabConsultas";
            this.tabConsultas.SelectedIndex = 0;
            this.tabConsultas.Size = new System.Drawing.Size(781, 564);
            this.tabConsultas.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btmVisualizar);
            this.tabPage2.Controls.Add(this.comboFiltro);
            this.tabPage2.Controls.Add(this.btmDeletar);
            this.tabPage2.Controls.Add(this.btmAlterar);
            this.tabPage2.Controls.Add(this.btmPesquisar);
            this.tabPage2.Controls.Add(this.dgvPesquisa);
            this.tabPage2.Controls.Add(this.lblPesquisar);
            this.tabPage2.Controls.Add(this.txtPesquisar);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(773, 530);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btmVisualizar
            // 
            this.btmVisualizar.Enabled = false;
            this.btmVisualizar.Location = new System.Drawing.Point(676, 18);
            this.btmVisualizar.Name = "btmVisualizar";
            this.btmVisualizar.Size = new System.Drawing.Size(94, 34);
            this.btmVisualizar.TabIndex = 9;
            this.btmVisualizar.Text = "Visualizar";
            this.btmVisualizar.UseVisualStyleBackColor = true;
            this.btmVisualizar.Visible = false;
            // 
            // comboFiltro
            // 
            this.comboFiltro.FormattingEnabled = true;
            this.comboFiltro.Items.AddRange(new object[] {
            "Agendamentos",
            "Clientes",
            "Médicos",
            "Consultas",
            "Especialidades"});
            this.comboFiltro.Location = new System.Drawing.Point(437, 22);
            this.comboFiltro.Name = "comboFiltro";
            this.comboFiltro.Size = new System.Drawing.Size(121, 29);
            this.comboFiltro.TabIndex = 8;
            this.comboFiltro.SelectedIndexChanged += new System.EventHandler(this.comboFiltro_SelectedIndexChanged);
            // 
            // btmDeletar
            // 
            this.btmDeletar.BackColor = System.Drawing.Color.Red;
            this.btmDeletar.ForeColor = System.Drawing.Color.Black;
            this.btmDeletar.Location = new System.Drawing.Point(676, 112);
            this.btmDeletar.Name = "btmDeletar";
            this.btmDeletar.Size = new System.Drawing.Size(94, 34);
            this.btmDeletar.TabIndex = 5;
            this.btmDeletar.Text = "Deletar";
            this.btmDeletar.UseVisualStyleBackColor = false;
            this.btmDeletar.Click += new System.EventHandler(this.btmDeletar_Click);
            // 
            // btmAlterar
            // 
            this.btmAlterar.Location = new System.Drawing.Point(676, 72);
            this.btmAlterar.Name = "btmAlterar";
            this.btmAlterar.Size = new System.Drawing.Size(94, 34);
            this.btmAlterar.TabIndex = 4;
            this.btmAlterar.Text = "Alterar";
            this.btmAlterar.UseVisualStyleBackColor = true;
            this.btmAlterar.Click += new System.EventHandler(this.btmAlterar_Click);
            // 
            // btmPesquisar
            // 
            this.btmPesquisar.BackgroundImage = global::MyClinicMed.Properties.Resources.lupa;
            this.btmPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btmPesquisar.FlatAppearance.BorderSize = 0;
            this.btmPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmPesquisar.Location = new System.Drawing.Point(369, 3);
            this.btmPesquisar.Name = "btmPesquisar";
            this.btmPesquisar.Size = new System.Drawing.Size(62, 56);
            this.btmPesquisar.TabIndex = 3;
            this.btmPesquisar.UseVisualStyleBackColor = true;
            this.btmPesquisar.Click += new System.EventHandler(this.btmPesquisar_Click);
            // 
            // dgvPesquisa
            // 
            this.dgvPesquisa.AllowUserToAddRows = false;
            this.dgvPesquisa.AllowUserToDeleteRows = false;
            this.dgvPesquisa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisa.Location = new System.Drawing.Point(8, 72);
            this.dgvPesquisa.Name = "dgvPesquisa";
            this.dgvPesquisa.ReadOnly = true;
            this.dgvPesquisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPesquisa.Size = new System.Drawing.Size(662, 450);
            this.dgvPesquisa.TabIndex = 2;
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(8, 30);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(85, 21);
            this.lblPesquisar.TabIndex = 1;
            this.lblPesquisar.Text = "Pesquisar:";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(95, 24);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(268, 27);
            this.txtPesquisar.TabIndex = 0;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // FormConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 564);
            this.Controls.Add(this.tabConsultas);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormConsultas";
            this.Text = "FormConsultas";
            this.Load += new System.EventHandler(this.FormConsultas_Load);
            this.tabConsultas.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabConsultas;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btmDeletar;
        private System.Windows.Forms.Button btmAlterar;
        private System.Windows.Forms.Button btmPesquisar;
        private System.Windows.Forms.DataGridView dgvPesquisa;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.ComboBox comboFiltro;
        private System.Windows.Forms.Button btmVisualizar;
    }
}