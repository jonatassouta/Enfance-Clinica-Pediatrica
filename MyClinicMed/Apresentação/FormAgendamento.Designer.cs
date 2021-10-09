
namespace MyClinicMed
{
    partial class FormAgendamento
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
            this.components = new System.ComponentModel.Container();
            this.btmAtualizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btmFinalizar = new System.Windows.Forms.Button();
            this.comboMedico = new System.Windows.Forms.ComboBox();
            this.medicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinicaEnfanceDataSet1 = new MyClinicMed.ClinicaEnfanceDataSet1();
            this.comboConsulta = new System.Windows.Forms.ComboBox();
            this.consultasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinicaEnfanceAtu = new MyClinicMed.ClinicaEnfanceAtu();
            this.txtHora = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btmLimpar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvAgendamento = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btmVoltar = new System.Windows.Forms.Button();
            this.dataAgendamento = new System.Windows.Forms.DateTimePicker();
            this.comboFiltro = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.comboValor = new System.Windows.Forms.ComboBox();
            this.medicosTableAdapter = new MyClinicMed.ClinicaEnfanceDataSet1TableAdapters.MedicosTableAdapter();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.consultasTableAdapter = new MyClinicMed.ClinicaEnfanceAtuTableAdapters.ConsultasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaEnfanceDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaEnfanceAtu)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendamento)).BeginInit();
            this.SuspendLayout();
            // 
            // btmAtualizar
            // 
            this.btmAtualizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmAtualizar.Location = new System.Drawing.Point(642, 71);
            this.btmAtualizar.Margin = new System.Windows.Forms.Padding(5);
            this.btmAtualizar.Name = "btmAtualizar";
            this.btmAtualizar.Size = new System.Drawing.Size(125, 37);
            this.btmAtualizar.TabIndex = 0;
            this.btmAtualizar.Text = "Atualizar";
            this.btmAtualizar.UseVisualStyleBackColor = true;
            this.btmAtualizar.Click += new System.EventHandler(this.btmAtualizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(216, 14);
            this.txtNome.Margin = new System.Windows.Forms.Padding(5);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(244, 27);
            this.txtNome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Telefone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Médico:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 195);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tipo Agendamento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 228);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Data Agendamento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 261);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Hora Agendamento:";
            // 
            // btmFinalizar
            // 
            this.btmFinalizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmFinalizar.Location = new System.Drawing.Point(642, 24);
            this.btmFinalizar.Margin = new System.Windows.Forms.Padding(5);
            this.btmFinalizar.Name = "btmFinalizar";
            this.btmFinalizar.Size = new System.Drawing.Size(125, 37);
            this.btmFinalizar.TabIndex = 13;
            this.btmFinalizar.Text = "Finalizar";
            this.btmFinalizar.UseVisualStyleBackColor = true;
            this.btmFinalizar.Click += new System.EventHandler(this.btmFinalizar_Click);
            // 
            // comboMedico
            // 
            this.comboMedico.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.medicosBindingSource, "nome_medico", true));
            this.comboMedico.DataSource = this.medicosBindingSource;
            this.comboMedico.DisplayMember = "nome_medico";
            this.comboMedico.FormattingEnabled = true;
            this.comboMedico.Location = new System.Drawing.Point(216, 152);
            this.comboMedico.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboMedico.Name = "comboMedico";
            this.comboMedico.Size = new System.Drawing.Size(244, 29);
            this.comboMedico.TabIndex = 14;
            this.comboMedico.ValueMember = "nome_medico";
            // 
            // medicosBindingSource
            // 
            this.medicosBindingSource.DataMember = "Medicos";
            this.medicosBindingSource.DataSource = this.clinicaEnfanceDataSet1;
            // 
            // clinicaEnfanceDataSet1
            // 
            this.clinicaEnfanceDataSet1.DataSetName = "ClinicaEnfanceDataSet1";
            this.clinicaEnfanceDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboConsulta
            // 
            this.comboConsulta.DataSource = this.consultasBindingSource;
            this.comboConsulta.DisplayMember = "tipo";
            this.comboConsulta.FormattingEnabled = true;
            this.comboConsulta.Location = new System.Drawing.Point(216, 187);
            this.comboConsulta.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboConsulta.Name = "comboConsulta";
            this.comboConsulta.Size = new System.Drawing.Size(244, 29);
            this.comboConsulta.TabIndex = 15;
            this.comboConsulta.ValueMember = "id_consulta";
            this.comboConsulta.SelectedIndexChanged += new System.EventHandler(this.comboConsulta_SelectedIndexChanged);
            // 
            // consultasBindingSource
            // 
            this.consultasBindingSource.DataMember = "Consultas";
            this.consultasBindingSource.DataSource = this.clinicaEnfanceAtu;
            // 
            // clinicaEnfanceAtu
            // 
            this.clinicaEnfanceAtu.DataSetName = "ClinicaEnfanceAtu";
            this.clinicaEnfanceAtu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(216, 255);
            this.txtHora.Mask = "90:00";
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(100, 27);
            this.txtHora.TabIndex = 17;
            this.txtHora.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 88);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 21);
            this.label7.TabIndex = 18;
            this.label7.Text = "CPF:";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(216, 82);
            this.txtCpf.Mask = "000.000.000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(130, 27);
            this.txtCpf.TabIndex = 19;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(216, 49);
            this.txtTelefone.Mask = "(99) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(130, 27);
            this.txtTelefone.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 295);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 21);
            this.label8.TabIndex = 22;
            this.label8.Text = "Valor:";
            // 
            // btmLimpar
            // 
            this.btmLimpar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmLimpar.Location = new System.Drawing.Point(642, 118);
            this.btmLimpar.Margin = new System.Windows.Forms.Padding(5);
            this.btmLimpar.Name = "btmLimpar";
            this.btmLimpar.Size = new System.Drawing.Size(125, 37);
            this.btmLimpar.TabIndex = 23;
            this.btmLimpar.Text = "Limpar";
            this.btmLimpar.UseVisualStyleBackColor = true;
            this.btmLimpar.Click += new System.EventHandler(this.btmLimpar_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesquisar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Location = new System.Drawing.Point(216, 329);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(5);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(244, 27);
            this.txtPesquisar.TabIndex = 24;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            this.txtPesquisar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPesquisar_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 335);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 21);
            this.label9.TabIndex = 25;
            this.label9.Text = "Pesquisar:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvAgendamento);
            this.panel1.Location = new System.Drawing.Point(13, 364);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 188);
            this.panel1.TabIndex = 26;
            // 
            // dgvAgendamento
            // 
            this.dgvAgendamento.AllowUserToAddRows = false;
            this.dgvAgendamento.AllowUserToDeleteRows = false;
            this.dgvAgendamento.AllowUserToOrderColumns = true;
            this.dgvAgendamento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAgendamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgendamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAgendamento.Location = new System.Drawing.Point(0, 0);
            this.dgvAgendamento.Name = "dgvAgendamento";
            this.dgvAgendamento.ReadOnly = true;
            this.dgvAgendamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAgendamento.Size = new System.Drawing.Size(754, 188);
            this.dgvAgendamento.TabIndex = 0;
            this.dgvAgendamento.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvAgendamento_MouseClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(642, 272);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 37);
            this.button1.TabIndex = 27;
            this.button1.Text = "Relatório";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btmVoltar
            // 
            this.btmVoltar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmVoltar.Location = new System.Drawing.Point(642, 319);
            this.btmVoltar.Margin = new System.Windows.Forms.Padding(5);
            this.btmVoltar.Name = "btmVoltar";
            this.btmVoltar.Size = new System.Drawing.Size(125, 37);
            this.btmVoltar.TabIndex = 28;
            this.btmVoltar.Text = "Voltar";
            this.btmVoltar.UseVisualStyleBackColor = true;
            this.btmVoltar.Click += new System.EventHandler(this.btmVoltar_Click);
            // 
            // dataAgendamento
            // 
            this.dataAgendamento.Location = new System.Drawing.Point(216, 223);
            this.dataAgendamento.Name = "dataAgendamento";
            this.dataAgendamento.Size = new System.Drawing.Size(200, 27);
            this.dataAgendamento.TabIndex = 29;
            // 
            // comboFiltro
            // 
            this.comboFiltro.FormattingEnabled = true;
            this.comboFiltro.Items.AddRange(new object[] {
            "Clientes",
            "Médicos",
            "Consultas",
            "Agendamentos"});
            this.comboFiltro.Location = new System.Drawing.Point(489, 327);
            this.comboFiltro.Name = "comboFiltro";
            this.comboFiltro.Size = new System.Drawing.Size(121, 29);
            this.comboFiltro.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(485, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 21);
            this.label11.TabIndex = 31;
            this.label11.Text = "ID:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(513, 20);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(68, 21);
            this.lblID.TabIndex = 32;
            this.lblID.Text = "Codigo";
            // 
            // comboValor
            // 
            this.comboValor.DataSource = this.consultasBindingSource;
            this.comboValor.DisplayMember = "valor";
            this.comboValor.Enabled = false;
            this.comboValor.FormattingEnabled = true;
            this.comboValor.Location = new System.Drawing.Point(216, 287);
            this.comboValor.Name = "comboValor";
            this.comboValor.Size = new System.Drawing.Size(100, 29);
            this.comboValor.TabIndex = 33;
            this.comboValor.ValueMember = "tipo";
            // 
            // medicosTableAdapter
            // 
            this.medicosTableAdapter.ClearBeforeFill = true;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(216, 117);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(5);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(244, 27);
            this.txtEndereco.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 123);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 21);
            this.label10.TabIndex = 34;
            this.label10.Text = "Endereço:";
            // 
            // consultasTableAdapter
            // 
            this.consultasTableAdapter.ClearBeforeFill = true;
            // 
            // FormAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 564);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboValor);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboFiltro);
            this.Controls.Add(this.dataAgendamento);
            this.Controls.Add(this.btmVoltar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.btmLimpar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.comboConsulta);
            this.Controls.Add(this.comboMedico);
            this.Controls.Add(this.btmFinalizar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btmAtualizar);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormAgendamento";
            this.Text = "FormAgendamento";
            this.Load += new System.EventHandler(this.FormAgendamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaEnfanceDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaEnfanceAtu)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmAtualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btmFinalizar;
        private System.Windows.Forms.ComboBox comboMedico;
        private System.Windows.Forms.ComboBox comboConsulta;
        private System.Windows.Forms.MaskedTextBox txtHora;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btmLimpar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvAgendamento;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btmVoltar;
        private System.Windows.Forms.DateTimePicker dataAgendamento;
        private System.Windows.Forms.ComboBox comboFiltro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ComboBox comboValor;
        private ClinicaEnfanceDataSet1 clinicaEnfanceDataSet1;
        private System.Windows.Forms.BindingSource medicosBindingSource;
        private ClinicaEnfanceDataSet1TableAdapters.MedicosTableAdapter medicosTableAdapter;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label10;
        private ClinicaEnfanceAtu clinicaEnfanceAtu;
        private System.Windows.Forms.BindingSource consultasBindingSource;
        private ClinicaEnfanceAtuTableAdapters.ConsultasTableAdapter consultasTableAdapter;
    }
}