using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MyClinicMed.DAL;

namespace MyClinicMed
{
    public partial class FormAgendamento : Form
    {
        FormMenu formMenu;
        Login usuario;
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        
        public FormAgendamento(FormMenu menu, Login log)
        {
            InitializeComponent();
            formMenu = menu;
            usuario = log;
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

        private void btmVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btmLimpar_Click(object sender, EventArgs e)
        {
            limparTextBoxes(this.Controls);
            txtCpf.Text = "";
            dataAgendamento.Text = "";
            txtHora.Text = "";
            txtTelefone.Text = "";
            comboConsulta.Text = "";
            comboMedico.Text = "";
            comboValor.Text = "";
        }

        private void btmFinalizar_Click(object sender, EventArgs e)
        {
            cmd.Connection = con.conectar();

            try
            {
                string nome = txtNome.Text;
                string telefone = txtTelefone.Text;
                string cpf = txtCpf.Text;
                string endereco = txtEndereco.Text;
                string medico = comboMedico.Text;
                string tipoConsulta = comboConsulta.Text;
                string data = dataAgendamento.Text;
                string hora = txtHora.Text;
                int valorConsulta = int.Parse(comboValor.Text);

                cmd.CommandText = $"insert into Agendamentos values('{nome}', '{cpf}','{endereco}', '{telefone}', '{data}', '{hora}', '{tipoConsulta}', '{valorConsulta}', '{medico}');";

                cmd.ExecuteNonQuery();

                MessageBox.Show("Agendamendo realizado com sucesso!", "Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                limparTextBoxes(this.Controls);
                txtCpf.Text = "";
                dataAgendamento.Text = "";
                txtHora.Text = "";
                txtTelefone.Text = "";
                comboConsulta.Text = "";
                comboMedico.Text = "";
                comboValor.Text = "";
                txtEndereco.Text = "";
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, x.StackTrace);
            }        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamWriter Relatorio = new StreamWriter(@"C:\Users\jonat\OneDrive\Turma de Formação Cast\Windows Form\MyClinicMed\MyClinicMed\Relatorios\Relatorio de Agendamento.txt"))
            {
                Relatorio.Write("\tRelatório de Agendamento Clina Enfance\n\n");
 
                Relatorio.WriteLine($"Nome: {txtNome.Text}");
                Relatorio.WriteLine($"Telefone: {txtTelefone.Text}");
                Relatorio.WriteLine($"CPF: {txtCpf.Text}");
                Relatorio.WriteLine($"Endereço: {txtEndereco.Text}");
                Relatorio.WriteLine($"Médico: {comboMedico.Text}");
                Relatorio.WriteLine($"Tipo de Agendamento: {comboConsulta.Text}");
                Relatorio.WriteLine($"Data Agendamento: {dataAgendamento.Text}");
                Relatorio.WriteLine($"Hora Agendmaneto: {txtHora.Text}");
                Relatorio.WriteLine($"Valor: {comboValor.Text}\n");
               
                Relatorio.WriteLine($"Atendente Responsavel: {usuario.txtUsuario.Text}");
            }

            MessageBox.Show("Relatório gerado com sucesso!!");
       }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            cmd.Connection = con.conectar();
            if (txtPesquisar.Text != "")
            {
                try
                {
                    if (comboFiltro.Text == "Clientes")
                    {
                        cmd.CommandText = "Select * from Clientes where nome_cliente like ('%" + txtPesquisar.Text + "%')";
                    }
                    else if (comboFiltro.Text == "Médicos")
                    {
                        cmd.CommandText = "Select * from Medicos where nome_medico like ('%" + txtPesquisar.Text + "%')";
                    }
                    else if (comboFiltro.Text == "Agendamentos")
                    {
                        cmd.CommandText = "Select * from Agendamentos where nome_cliente like ('%" + txtPesquisar.Text + "%')";
                    }

                    //recebe os dados de uma tabela apos a execuçã de uma select
                    SqlDataAdapter da = new SqlDataAdapter();

                    DataTable dt = new DataTable();


                    //recebe os dados da instrução select
                    da.SelectCommand = cmd;
                    da.Fill(dt); //preenche o data table

                    dgvAgendamento.DataSource = dt;

                }
                catch (Exception)
                {
                    MessageBox.Show("Selecione uma Tebela" );
                    con.desconectar();
                }
            }
            else
            {
                dgvAgendamento.DataSource = null;
                con.desconectar();
            }
        }

        private void dgvAgendamento_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                lblID.Text = dgvAgendamento.SelectedRows[0].Cells[0].Value.ToString();
                txtNome.Text = dgvAgendamento.SelectedRows[0].Cells[1].Value.ToString();
                txtTelefone.Text = dgvAgendamento.SelectedRows[0].Cells[2].Value.ToString();
                txtCpf.Text = dgvAgendamento.SelectedRows[0].Cells[3].Value.ToString();
                txtEndereco.Text = dgvAgendamento.SelectedRows[0].Cells[4].Value.ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, x.StackTrace);
            }
        }

        public void FiltrarGrade()
        {
            cmd.Connection = con.conectar();
            if (txtPesquisar.Text == "")
            {
                try
                {
                    if (comboFiltro.Text == "Clientes")
                    {
                        cmd.CommandText = "Select * from Clientes;";
                    }
                    else if (comboFiltro.Text == "Médicos")
                    {
                        cmd.CommandText = "Select * from Medicos;";
                    }
                    else if (comboFiltro.Text == "Agendamentos")
                    {
                        cmd.CommandText = "Select * from Agendamentos;";
                    }


                    //recebe os dados de uma tabela apos a execuçã de uma select
                    SqlDataAdapter da = new SqlDataAdapter();

                    DataTable dt = new DataTable();


                    //recebe os dados da instrução select
                    da.SelectCommand = cmd;
                    da.Fill(dt); //preenche o data table

                    dgvAgendamento.DataSource = dt;

                }
                catch (Exception)
                {
                    MessageBox.Show("Selecione uma tabela!!!");
                    con.desconectar();
                }
            }
            else
            {
                dgvAgendamento.DataSource = null;
                con.desconectar();
            }
        }

        private void txtPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                FiltrarGrade();
        }

        private void FormAgendamento_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'clinicaEnfanceAtu.Consultas'. Você pode movê-la ou removê-la conforme necessário.
            this.consultasTableAdapter.Fill(this.clinicaEnfanceAtu.Consultas);
            // TODO: esta linha de código carrega dados na tabela 'clinicaEnfanceDataSet1.Medicos'. Você pode movê-la ou removê-la conforme necessário.
            this.medicosTableAdapter.Fill(this.clinicaEnfanceDataSet1.Medicos);

        }

        private void btmAtualizar_Click(object sender, EventArgs e)
        {
            cmd.Connection = con.conectar();

            try
            {
                string nome = txtNome.Text;
                string telefone = txtTelefone.Text;
                string cpf = txtCpf.Text;
                string endereco = txtEndereco.Text;       

                cmd.CommandText = $"update Clientes set nome_cliente=('{nome}'), telefone_cliente=('{telefone}'), cpf=('{cpf}'),endereco=('{endereco}');";

                cmd.ExecuteNonQuery();


                MessageBox.Show("Agendamendo realizado com sucesso!", "Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);       
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, x.StackTrace);
            }
        }

        private void comboConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd.Connection = con.conectar();
            try
            {
                comboValor.DataSource = cmd.CommandText = $"select valor from Consultas where id_consulta = ('{comboConsulta.SelectedValue}')";
                comboValor.ValueMember = "id_consulta";
                comboValor.DisplayMember = "valor";
            }
            catch (Exception)
            {
        
            }
        }
    }
}
