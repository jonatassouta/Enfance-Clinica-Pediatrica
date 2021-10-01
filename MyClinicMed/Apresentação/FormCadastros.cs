using MyClinicMed.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyClinicMed.Apresentação
{
    public partial class FormCadastros : Form
    {
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();

        public FormCadastros()
        {
            InitializeComponent();
        }

        private void limparTextBoxes(Control.ControlCollection controles)
        {
            //Faz um laço para todos os controles passados no parâmetro
            foreach (Control ctrl in controles)
            {
                //Se o contorle for um TextBox...
                if (ctrl is TextBox)
                {
                    ((TextBox)(ctrl)).Text = String.Empty;
                }
            }
        }

        private void btmCadCliente_Click(object sender, EventArgs e)
        {
            cmd.Connection = con.conectar();

            if (txtNomeCliente.Text == "")
            {
                MessageBox.Show("Obrigatório campo nome");
                txtNomeCliente.Focus();
            }
            else if (txtEndereco.Text == "")
            {
                MessageBox.Show("Obrigatório campo endereço");
                txtEndereco.Focus();
            }
            else if (txtCpfCliente.Text == "")
            {
                MessageBox.Show("Obrigatório campo cpf");
                txtCpfCliente.Focus();
            }
            else if (txtTelefoneCliente.Text == "")
            {
                MessageBox.Show("Obrigatório campo telefone");
                txtTelefoneCliente.Focus();
            }
            else
            {
                try
                {
                    string nome = txtNomeCliente.Text;
                    string cpf = txtCpfCliente.Text;
                    string telefone = txtTelefoneCliente.Text;
                    string endereco = txtEndereco.Text;

                    cmd.CommandText = $"insert into Clientes values('{nome}','{telefone}','{cpf}','{endereco}');";
                    cmd.Connection = con.conectar();

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Cliente cadastrado com sucesso!!!", "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    limparTextBoxes(this.Controls);
                    txtCpfCliente.Text = "";
                    txtEndereco.Text = "";
                    txtNomeCliente.Text = "";
                    txtTelefoneCliente.Text = "";
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message + "\n\n" + x.StackTrace + "ERRO" + MessageBoxButtons.OK + MessageBoxIcon.Error);
                }
                finally
                {
                    con.desconectar();
                }
            }
        }

        private void btmLimpar_Click(object sender, EventArgs e)
        {
            txtCpfCliente.Text = "";
            txtEndereco.Text = "";
            txtNomeCliente.Text = "";
            txtTelefoneCliente.Text = "";
        }

        private void btmCadEspec_Click(object sender, EventArgs e)
        {
            cmd.Connection  = con.conectar();

            if (txtNomeEspecialidade.Text == "")
            {
                MessageBox.Show("Obrigatório campo nome");
                txtNomeEspecialidade.Focus();
            }
            else
            {
                try
                {
                    string nome = txtNomeEspecialidade.Text;

                    cmd.CommandText = $"insert into Especialidades values('{nome}');";

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Especialidade Cadastrada com Sucesso!!", "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNomeEspecialidade.Text = "";
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message + "\n\n" + x.StackTrace + "ERRO" + MessageBoxButtons.OK + MessageBoxIcon.Error);
                }
                finally
                {
                    con.desconectar();
                }
            }
        }

        private void btmLimparMed_Click(object sender, EventArgs e)
        {
            txtCrm.Text = "";
            txtNomeMédico.Text = "";
            txtTelefoneMed.Text = "";
            comboDias.Text = "";
            comboUF.Text = "";
        }

        private void btmLimparESP_Click(object sender, EventArgs e)
        {
            txtNomeEspecialidade.Text = "";
        }

        private void btmCadMed_Click(object sender, EventArgs e)
        {
            cmd.Connection = con.conectar();

            if (txtNomeMédico.Text == "")
            {
                MessageBox.Show("Obrigatório campo nome");
                txtNomeMédico.Focus();
            }
            else if (txtCrm.Text == "")
            {
                MessageBox.Show("Obrigatório campo crm/uf");
                txtCrm.Focus();
            }
            else if (txtTelefoneMed.Text == "")
            {
                MessageBox.Show("Obrigatório campo telefone");
                txtTelefoneMed.Focus();
            }
            else if (comboDias.Text == "")
            {
                MessageBox.Show("Obrigatório campo dias disponiveis");
                comboDias.Focus();
            }
            else
            {
                try
                {
                    string nome = txtNomeMédico.Text;
                    string crm = txtCrm.Text;
                    string uf = comboUF.Text;
                    string telefone = txtTelefoneMed.Text;
                    string dia = comboDias.Text;
                    int espe = int.Parse(comboEsp.SelectedValue.ToString());

                    cmd.CommandText = $"insert into Medicos values('{nome}','{telefone}','{crm}','{uf}','{dia}', '{espe}');";

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Médico cadastrado com sucesso!!!", "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtCrm.Text = "";
                    txtNomeMédico.Text = "";
                    txtTelefoneMed.Text = "";
                    comboDias.Text = "";
                    comboUF.Text = "";
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message + "\n\n" + x.StackTrace + "ERRO" + MessageBoxButtons.OK + MessageBoxIcon.Error);
                }
                finally
                {
                    con.desconectar();
                }
            }
        }

        private void FormCadastros_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'clinicaEnfanceDataSet1.Medicos'. Você pode movê-la ou removê-la conforme necessário.
            this.medicosTableAdapter.Fill(this.clinicaEnfanceDataSet1.Medicos);
            // TODO: esta linha de código carrega dados na tabela 'clinicaEnfanceDataSet1.Especialidades'. Você pode movê-la ou removê-la conforme necessário.
            this.especialidadesTableAdapter.Fill(this.clinicaEnfanceDataSet1.Especialidades);
            // TODO: esta linha de código carrega dados na tabela 'clinicaEnfanceDataSet1.Medicos'. Você pode movê-la ou removê-la conforme necessário.

        }
    }
}
