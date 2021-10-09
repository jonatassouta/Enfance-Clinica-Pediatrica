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

namespace MyClinicMed
{
    public partial class FormAlterar : Form
    {
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();

        public FormAlterar()
        {
            InitializeComponent();
        }

        private void btmAlterar_Click(object sender, EventArgs e)
        {
            FormConsultas fmc = new FormConsultas();

            cmd.Connection = con.conectar();
            try
            {
                string nome = txtNomeCliente.Text;
                string cpf = txtCpfCliente.Text;
                string telefone = txtTelefoneCliente.Text;
                string endereco = txtEndereco.Text;

                cmd.CommandText = $"update Clientes set nome_cliente = ('{nome}'), telefone_cliente=('{telefone}'), cpf=('{cpf}'), endereco=('{endereco}');";

                cmd.ExecuteNonQuery();

                MessageBox.Show("Cliente alterado com sucesso!!");

                txtCpfCliente.Text = "";
                txtEndereco.Text = "";
                txtNomeCliente.Text = "";
                txtTelefoneCliente.Text = "";
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, x.StackTrace);
            }
            finally
            {
                con.desconectar();
            }       
        }

        private void btmCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btmCadMed_Click(object sender, EventArgs e)
        {
            FormConsultas fmc = new FormConsultas();

            cmd.Connection = con.conectar();
            try
            {
                string nome = txtNomeMédico.Text;
                string crm = txtCrm.Text;
                string telefone = txtTelefoneMed.Text;
                string dia = comboDias.Text;
                string uf = comboUF.Text;
                int id = int.Parse(comboEsp.SelectedValue.ToString());

                cmd.CommandText = $"update Medicos set nome_medico = ('{nome}'), telefone_medico=('{crm}'), crm=('{telefone}'), uf=('{uf}') dia_disponivel=('{dia}'), id_especialidade=('{id}');";

                cmd.ExecuteNonQuery();

                MessageBox.Show("Médico alterado com sucesso!!");

                txtCrm.Text = "";
                txtNomeMédico.Text = "";
                txtTelefoneMed.Text = "";
                comboDias.Text = "";
                comboUF.Text = "";
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, x.StackTrace);
            }
            finally
            {
                con.desconectar();
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

        private void button1_Click(object sender, EventArgs e)
        {
            txtTipo.Text = "";
            txtValor.Text = "";
            comboMedicoCon.Text = "";
        }

        private void FormAlterar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'clinicaEnfanceAtu.Consultas'. Você pode movê-la ou removê-la conforme necessário.
            this.consultasTableAdapter.Fill(this.clinicaEnfanceAtu.Consultas);
            // TODO: esta linha de código carrega dados na tabela 'clinicaEnfanceAtu.Medicos'. Você pode movê-la ou removê-la conforme necessário.
            this.medicosTableAdapter.Fill(this.clinicaEnfanceAtu.Medicos);

        }

        private void btmCadConsulta_Click(object sender, EventArgs e)
        {
            FormConsultas fmc = new FormConsultas();

            cmd.Connection = con.conectar();
            try
            {
                string nome = txtTipo.Text;
                string valor = txtValor.Text;
                int id = int.Parse(comboMedicoCon.SelectedValue.ToString());

                cmd.CommandText = $"update Consultas set tipo = ('{nome}'), valor=('{valor}'), id_medico=('{id}');";

                cmd.ExecuteNonQuery();

                MessageBox.Show("Consulta alterado com sucesso!!");

                txtTipo.Text = "";
                txtValor.Text = "";
                comboMedicoCon.Text = "";
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, x.StackTrace);
            }
            finally
            {
                con.desconectar();
            }
        }

        private void btmLimpar_Click(object sender, EventArgs e)
        {
            lblCodigo.Text = "Codigo";
            txtNomeAg.Text = "";
            txtCpfAg.Text = "";
            dataAgendamentoAg.Text = "";
            txtHoraAg.Text = "";
            txtTelefoneAg.Text = "";
            comboConsultaAg.Text = "";
            comboMedicoAg.Text = "";
            comboValorAg.Text = "";
            txtEndereAg.Text = "";
        }

        private void btmAtualizar_Click(object sender, EventArgs e)
        {
            cmd.Connection = con.conectar();

            try
            {
                string nome = txtNomeAg.Text;
                string telefone = txtTelefoneAg.Text;
                string cpf = txtCpfAg.Text;
                string endereco = txtEndereco.Text;
                string medico = comboMedicoAg.Text;
                string tipoConsulta = comboConsultaAg.Text;
                string data = dataAgendamentoAg.Text;
                string hora = txtHoraAg.Text;
                int valorConsulta = int.Parse(comboValorAg.Text);

                cmd.CommandText = $"update Agendamentos set nome_cliente=('{nome}'), cpf_cliente=('{cpf}'), endereco=('{endereco}'), telefone_cliente=('{telefone}'), data_agendamento=('{data}'), hora_agendamento=('{hora}'), tipo_agendamento=('{tipoConsulta}'), valor=('{valorConsulta}'), medico=('{medico}');";

                cmd.ExecuteNonQuery();

                MessageBox.Show("Agendamendo Atualizado com sucesso!", "Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lblCodigo.Text = "Codigo";
                txtNomeAg.Text = "";
                txtCpfAg.Text = "";
                dataAgendamentoAg.Text = "";
                txtHoraAg.Text = "";
                txtTelefoneAg.Text = "";
                comboConsultaAg.Text = "";
                comboMedicoAg.Text = "";
                comboValorAg.Text = "";
                txtEndereAg.Text = "";
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, x.StackTrace);
            }
        }
    }
}
