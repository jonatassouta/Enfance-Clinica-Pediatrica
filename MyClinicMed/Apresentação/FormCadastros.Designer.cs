
namespace MyClinicMed.Apresentação
{
    partial class FormCadastros
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
            this.tabCadCliente = new System.Windows.Forms.TabControl();
            this.tabCliente = new System.Windows.Forms.TabPage();
            this.btmLimpar = new System.Windows.Forms.Button();
            this.btmCadCliente = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefoneCliente = new System.Windows.Forms.MaskedTextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCpfCliente = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabMedicos = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btmLimparESP = new System.Windows.Forms.Button();
            this.btmCadEspec = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNomeEspecialidade = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboEsp = new System.Windows.Forms.ComboBox();
            this.medicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinicaEnfanceDataSet1 = new MyClinicMed.ClinicaEnfanceDataSet1();
            this.especialidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.comboUF = new System.Windows.Forms.ComboBox();
            this.btmLimparMed = new System.Windows.Forms.Button();
            this.btmCadMed = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.comboDias = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefoneMed = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCrm = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeMédico = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabCadConsultas = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.NumericUpDown();
            this.comboMedicoCon = new System.Windows.Forms.ComboBox();
            this.consultasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinicaEnfanceAtu = new MyClinicMed.ClinicaEnfanceAtu();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btmCadConsulta = new System.Windows.Forms.Button();
            this.especialidadesTableAdapter = new MyClinicMed.ClinicaEnfanceDataSet1TableAdapters.EspecialidadesTableAdapter();
            this.medicosTableAdapter = new MyClinicMed.ClinicaEnfanceDataSet1TableAdapters.MedicosTableAdapter();
            this.consultasTableAdapter = new MyClinicMed.ClinicaEnfanceAtuTableAdapters.ConsultasTableAdapter();
            this.tabCadCliente.SuspendLayout();
            this.tabCliente.SuspendLayout();
            this.tabMedicos.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaEnfanceDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabCadConsultas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaEnfanceAtu)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCadCliente
            // 
            this.tabCadCliente.Controls.Add(this.tabCliente);
            this.tabCadCliente.Controls.Add(this.tabMedicos);
            this.tabCadCliente.Controls.Add(this.tabCadConsultas);
            this.tabCadCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCadCliente.Location = new System.Drawing.Point(0, 0);
            this.tabCadCliente.Name = "tabCadCliente";
            this.tabCadCliente.SelectedIndex = 0;
            this.tabCadCliente.Size = new System.Drawing.Size(781, 564);
            this.tabCadCliente.TabIndex = 0;
            // 
            // tabCliente
            // 
            this.tabCliente.Controls.Add(this.btmLimpar);
            this.tabCliente.Controls.Add(this.btmCadCliente);
            this.tabCliente.Controls.Add(this.label4);
            this.tabCliente.Controls.Add(this.txtTelefoneCliente);
            this.tabCliente.Controls.Add(this.txtEndereco);
            this.tabCliente.Controls.Add(this.label3);
            this.tabCliente.Controls.Add(this.label2);
            this.tabCliente.Controls.Add(this.txtCpfCliente);
            this.tabCliente.Controls.Add(this.txtNomeCliente);
            this.tabCliente.Controls.Add(this.label1);
            this.tabCliente.Location = new System.Drawing.Point(4, 30);
            this.tabCliente.Name = "tabCliente";
            this.tabCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tabCliente.Size = new System.Drawing.Size(773, 530);
            this.tabCliente.TabIndex = 1;
            this.tabCliente.Text = "Paciente";
            this.tabCliente.UseVisualStyleBackColor = true;
            // 
            // btmLimpar
            // 
            this.btmLimpar.Location = new System.Drawing.Point(409, 374);
            this.btmLimpar.Name = "btmLimpar";
            this.btmLimpar.Size = new System.Drawing.Size(109, 45);
            this.btmLimpar.TabIndex = 10;
            this.btmLimpar.Text = "Limpar";
            this.btmLimpar.UseVisualStyleBackColor = true;
            this.btmLimpar.Click += new System.EventHandler(this.btmLimpar_Click);
            // 
            // btmCadCliente
            // 
            this.btmCadCliente.Location = new System.Drawing.Point(257, 374);
            this.btmCadCliente.Name = "btmCadCliente";
            this.btmCadCliente.Size = new System.Drawing.Size(109, 45);
            this.btmCadCliente.TabIndex = 9;
            this.btmCadCliente.Text = "Cadastrar";
            this.btmCadCliente.UseVisualStyleBackColor = true;
            this.btmCadCliente.Click += new System.EventHandler(this.btmCadCliente_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Telefone:";
            // 
            // txtTelefoneCliente
            // 
            this.txtTelefoneCliente.Location = new System.Drawing.Point(303, 219);
            this.txtTelefoneCliente.Mask = "(99) 00000-0000";
            this.txtTelefoneCliente.Name = "txtTelefoneCliente";
            this.txtTelefoneCliente.Size = new System.Drawing.Size(129, 27);
            this.txtTelefoneCliente.TabIndex = 7;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(303, 271);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(268, 27);
            this.txtEndereco.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Endereço: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "CPF:";
            // 
            // txtCpfCliente
            // 
            this.txtCpfCliente.Location = new System.Drawing.Point(303, 170);
            this.txtCpfCliente.Mask = "000.000.000-00";
            this.txtCpfCliente.Name = "txtCpfCliente";
            this.txtCpfCliente.Size = new System.Drawing.Size(129, 27);
            this.txtCpfCliente.TabIndex = 2;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(303, 119);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(268, 27);
            this.txtNomeCliente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // tabMedicos
            // 
            this.tabMedicos.Controls.Add(this.panel3);
            this.tabMedicos.Controls.Add(this.panel2);
            this.tabMedicos.Controls.Add(this.panel1);
            this.tabMedicos.Location = new System.Drawing.Point(4, 30);
            this.tabMedicos.Name = "tabMedicos";
            this.tabMedicos.Padding = new System.Windows.Forms.Padding(3);
            this.tabMedicos.Size = new System.Drawing.Size(773, 530);
            this.tabMedicos.TabIndex = 2;
            this.tabMedicos.Text = "Médicos";
            this.tabMedicos.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(3, 291);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(794, 10);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btmLimparESP);
            this.panel2.Controls.Add(this.btmCadEspec);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtNomeEspecialidade);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 307);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(767, 220);
            this.panel2.TabIndex = 1;
            // 
            // btmLimparESP
            // 
            this.btmLimparESP.Location = new System.Drawing.Point(426, 135);
            this.btmLimparESP.Name = "btmLimparESP";
            this.btmLimparESP.Size = new System.Drawing.Size(114, 43);
            this.btmLimparESP.TabIndex = 22;
            this.btmLimparESP.Text = "Limpar";
            this.btmLimparESP.UseVisualStyleBackColor = true;
            this.btmLimparESP.Click += new System.EventHandler(this.btmLimparESP_Click);
            // 
            // btmCadEspec
            // 
            this.btmCadEspec.Location = new System.Drawing.Point(270, 135);
            this.btmCadEspec.Name = "btmCadEspec";
            this.btmCadEspec.Size = new System.Drawing.Size(114, 43);
            this.btmCadEspec.TabIndex = 23;
            this.btmCadEspec.Text = "Cadastrar";
            this.btmCadEspec.UseVisualStyleBackColor = true;
            this.btmCadEspec.Click += new System.EventHandler(this.btmCadEspec_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(6, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(248, 23);
            this.label10.TabIndex = 13;
            this.label10.Text = "Cadastro Especialidades:";
            // 
            // txtNomeEspecialidade
            // 
            this.txtNomeEspecialidade.Location = new System.Drawing.Point(270, 88);
            this.txtNomeEspecialidade.Name = "txtNomeEspecialidade";
            this.txtNomeEspecialidade.Size = new System.Drawing.Size(268, 27);
            this.txtNomeEspecialidade.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(169, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 21);
            this.label9.TabIndex = 11;
            this.label9.Text = "Nome:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboEsp);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.comboUF);
            this.panel1.Controls.Add(this.btmLimparMed);
            this.panel1.Controls.Add(this.btmCadMed);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.comboDias);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtTelefoneMed);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtCrm);
            this.panel1.Controls.Add(this.txtNomeMédico);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 282);
            this.panel1.TabIndex = 0;
            // 
            // comboEsp
            // 
            this.comboEsp.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.medicosBindingSource, "id_especialidade", true));
            this.comboEsp.DataSource = this.especialidadesBindingSource;
            this.comboEsp.DisplayMember = "nome";
            this.comboEsp.FormattingEnabled = true;
            this.comboEsp.Location = new System.Drawing.Point(171, 229);
            this.comboEsp.Name = "comboEsp";
            this.comboEsp.Size = new System.Drawing.Size(121, 29);
            this.comboEsp.TabIndex = 24;
            this.comboEsp.ValueMember = "id_especialidade";
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
            // especialidadesBindingSource
            // 
            this.especialidadesBindingSource.DataMember = "Especialidades";
            this.especialidadesBindingSource.DataSource = this.clinicaEnfanceDataSet1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 237);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 21);
            this.label12.TabIndex = 23;
            this.label12.Text = "Especialidade:";
            // 
            // comboUF
            // 
            this.comboUF.FormattingEnabled = true;
            this.comboUF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.comboUF.Location = new System.Drawing.Point(281, 75);
            this.comboUF.Name = "comboUF";
            this.comboUF.Size = new System.Drawing.Size(52, 29);
            this.comboUF.TabIndex = 22;
            // 
            // btmLimparMed
            // 
            this.btmLimparMed.Location = new System.Drawing.Point(350, 176);
            this.btmLimparMed.Name = "btmLimparMed";
            this.btmLimparMed.Size = new System.Drawing.Size(114, 43);
            this.btmLimparMed.TabIndex = 21;
            this.btmLimparMed.Text = "Limpar";
            this.btmLimparMed.UseVisualStyleBackColor = true;
            this.btmLimparMed.Click += new System.EventHandler(this.btmLimparMed_Click);
            // 
            // btmCadMed
            // 
            this.btmCadMed.Location = new System.Drawing.Point(350, 94);
            this.btmCadMed.Name = "btmCadMed";
            this.btmCadMed.Size = new System.Drawing.Size(114, 43);
            this.btmCadMed.TabIndex = 20;
            this.btmCadMed.Text = "Cadastrar";
            this.btmCadMed.UseVisualStyleBackColor = true;
            this.btmCadMed.Click += new System.EventHandler(this.btmCadMed_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(185, 23);
            this.label11.TabIndex = 19;
            this.label11.Text = "Cadastro Médicos:";
            // 
            // comboDias
            // 
            this.comboDias.FormattingEnabled = true;
            this.comboDias.Items.AddRange(new object[] {
            "Segunda-Feira",
            "Terça-Feira",
            "Quarta-Feira",
            "Quinta-Feira",
            "Sexta-Feira",
            "Sabado",
            "Domingo"});
            this.comboDias.Location = new System.Drawing.Point(171, 176);
            this.comboDias.Name = "comboDias";
            this.comboDias.Size = new System.Drawing.Size(121, 29);
            this.comboDias.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyClinicMed.Properties.Resources.Médico;
            this.pictureBox1.Location = new System.Drawing.Point(470, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 279);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "Telefone:";
            // 
            // txtTelefoneMed
            // 
            this.txtTelefoneMed.Location = new System.Drawing.Point(171, 126);
            this.txtTelefoneMed.Mask = "(99) 00000-0000";
            this.txtTelefoneMed.Name = "txtTelefoneMed";
            this.txtTelefoneMed.Size = new System.Drawing.Size(129, 27);
            this.txtTelefoneMed.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Dias disponiveis:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "CRM/UF:";
            // 
            // txtCrm
            // 
            this.txtCrm.Location = new System.Drawing.Point(171, 77);
            this.txtCrm.Mask = "00000000-0 ";
            this.txtCrm.Name = "txtCrm";
            this.txtCrm.Size = new System.Drawing.Size(104, 27);
            this.txtCrm.TabIndex = 11;
            // 
            // txtNomeMédico
            // 
            this.txtNomeMédico.Location = new System.Drawing.Point(171, 26);
            this.txtNomeMédico.Name = "txtNomeMédico";
            this.txtNomeMédico.Size = new System.Drawing.Size(268, 27);
            this.txtNomeMédico.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 21);
            this.label8.TabIndex = 9;
            this.label8.Text = "Nome:";
            // 
            // tabCadConsultas
            // 
            this.tabCadConsultas.Controls.Add(this.button1);
            this.tabCadConsultas.Controls.Add(this.txtValor);
            this.tabCadConsultas.Controls.Add(this.comboMedicoCon);
            this.tabCadConsultas.Controls.Add(this.label15);
            this.tabCadConsultas.Controls.Add(this.label14);
            this.tabCadConsultas.Controls.Add(this.txtTipo);
            this.tabCadConsultas.Controls.Add(this.label13);
            this.tabCadConsultas.Controls.Add(this.btmCadConsulta);
            this.tabCadConsultas.Location = new System.Drawing.Point(4, 30);
            this.tabCadConsultas.Name = "tabCadConsultas";
            this.tabCadConsultas.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadConsultas.Size = new System.Drawing.Size(773, 530);
            this.tabCadConsultas.TabIndex = 3;
            this.tabCadConsultas.Text = "Consultas";
            this.tabCadConsultas.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(421, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 46);
            this.button1.TabIndex = 9;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(310, 229);
            this.txtValor.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(120, 27);
            this.txtValor.TabIndex = 8;
            // 
            // comboMedicoCon
            // 
            this.comboMedicoCon.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.consultasBindingSource, "id_medico", true));
            this.comboMedicoCon.DataSource = this.medicosBindingSource;
            this.comboMedicoCon.DisplayMember = "nome_medico";
            this.comboMedicoCon.FormattingEnabled = true;
            this.comboMedicoCon.Location = new System.Drawing.Point(310, 273);
            this.comboMedicoCon.Name = "comboMedicoCon";
            this.comboMedicoCon.Size = new System.Drawing.Size(253, 29);
            this.comboMedicoCon.TabIndex = 7;
            this.comboMedicoCon.ValueMember = "id_medico";
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
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(216, 273);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 21);
            this.label15.TabIndex = 5;
            this.label15.Text = "Médico:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(216, 231);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 21);
            this.label14.TabIndex = 3;
            this.label14.Text = "Valor:";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(310, 180);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(253, 27);
            this.txtTipo.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(216, 186);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 21);
            this.label13.TabIndex = 1;
            this.label13.Text = "Tipo:";
            // 
            // btmCadConsulta
            // 
            this.btmCadConsulta.Location = new System.Drawing.Point(240, 403);
            this.btmCadConsulta.Name = "btmCadConsulta";
            this.btmCadConsulta.Size = new System.Drawing.Size(118, 46);
            this.btmCadConsulta.TabIndex = 0;
            this.btmCadConsulta.Text = "Cadastrar";
            this.btmCadConsulta.UseVisualStyleBackColor = true;
            this.btmCadConsulta.Click += new System.EventHandler(this.btmCadConsulta_Click);
            // 
            // especialidadesTableAdapter
            // 
            this.especialidadesTableAdapter.ClearBeforeFill = true;
            // 
            // medicosTableAdapter
            // 
            this.medicosTableAdapter.ClearBeforeFill = true;
            // 
            // consultasTableAdapter
            // 
            this.consultasTableAdapter.ClearBeforeFill = true;
            // 
            // FormCadastros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 564);
            this.Controls.Add(this.tabCadCliente);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormCadastros";
            this.Text = "FormCadastros";
            this.Load += new System.EventHandler(this.FormCadastros_Load);
            this.tabCadCliente.ResumeLayout(false);
            this.tabCliente.ResumeLayout(false);
            this.tabCliente.PerformLayout();
            this.tabMedicos.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaEnfanceDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabCadConsultas.ResumeLayout(false);
            this.tabCadConsultas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaEnfanceAtu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCadCliente;
        private System.Windows.Forms.TabPage tabCliente;
        private System.Windows.Forms.Button btmLimpar;
        private System.Windows.Forms.Button btmCadCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtTelefoneCliente;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtCpfCliente;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabMedicos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNomeEspecialidade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboDias;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtTelefoneMed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtCrm;
        private System.Windows.Forms.TextBox txtNomeMédico;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btmLimparESP;
        private System.Windows.Forms.Button btmCadEspec;
        private System.Windows.Forms.Button btmLimparMed;
        private System.Windows.Forms.Button btmCadMed;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboUF;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboEsp;
        private ClinicaEnfanceDataSet1 clinicaEnfanceDataSet1;
        private System.Windows.Forms.BindingSource especialidadesBindingSource;
        private ClinicaEnfanceDataSet1TableAdapters.EspecialidadesTableAdapter especialidadesTableAdapter;
        private System.Windows.Forms.BindingSource medicosBindingSource;
        private ClinicaEnfanceDataSet1TableAdapters.MedicosTableAdapter medicosTableAdapter;
        private System.Windows.Forms.TabPage tabCadConsultas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown txtValor;
        private System.Windows.Forms.ComboBox comboMedicoCon;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btmCadConsulta;
        private ClinicaEnfanceAtu clinicaEnfanceAtu;
        private System.Windows.Forms.BindingSource consultasBindingSource;
        private ClinicaEnfanceAtuTableAdapters.ConsultasTableAdapter consultasTableAdapter;
    }
}