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
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();

        public FormAgendamento(FormMenu menu)
        {
            InitializeComponent();
            formMenu = menu;
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
                string medico = comboMedico.Text;
                string tipoConsulta = comboConsulta.Text;
                string data = dataAgendamento.Text;
                string hora = txtHora.Text;
                int valorConsulta = int.Parse(comboValor.Text);

                cmd.CommandText = $"insert into Agendamentos values('{nome}', '{cpf}', '{telefone}', '{data}', '{hora}', '{tipoConsulta}', '{valorConsulta}', '{medico}');";

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
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, x.StackTrace);
            }

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamWriter Relatorio = new StreamWriter(@"C:\Users\jonat\OneDrive\Turma de Formação Cast\Windows Form\MyClinicMed\MyClinicMed\Relatorios\teste.csv, true"))
            {
                Relatorio.Write("Testes; Jonatas; Pessoa");
                Relatorio.Write("Testes2; Jonatas; Pessoa");
            }
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
                catch (Exception erro)
                {
                    MessageBox.Show("\n" + erro);
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
            // TODO: esta linha de código carrega dados na tabela 'clinicaEnfanceDataSet1.Medicos'. Você pode movê-la ou removê-la conforme necessário.
            this.medicosTableAdapter.Fill(this.clinicaEnfanceDataSet1.Medicos);

        }
    }
}
