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
    public partial class FormConsultas : Form
    {
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();


        public FormConsultas()
        {
            InitializeComponent();
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

                    else if (comboFiltro.Text == "Especialidades")
                    {
                        cmd.CommandText = "Select * from Especialidades where nome like ('%" + txtPesquisar.Text + "%')";
                    }
                    else if (comboFiltro.Text == "Consultas")
                    {
                        cmd.CommandText = "Select * from Consultas where tipo like ('%" + txtPesquisar.Text + "%')";
                    }

                    //recebe os dados de uma tabela apos a execuçã de uma select
                    SqlDataAdapter da = new SqlDataAdapter();

                    DataTable dt = new DataTable();


                    //recebe os dados da instrução select
                    da.SelectCommand = cmd;
                    da.Fill(dt); //preenche o data table

                    dgvPesquisa.DataSource = dt;

                }
                catch (Exception)
                {
                    MessageBox.Show("Selecione uma tabela!!!");
                    con.desconectar();
                }
            }
            else
            {
                dgvPesquisa.DataSource = null;
                con.desconectar();
            }
        }

        private void FormConsultas_Load(object sender, EventArgs e)
        {

        }

        private void btmAlterar_Click(object sender, EventArgs e)
        {
            if (dgvPesquisa.SelectedRows.Count > 0)
            {
                FormAlterar p = new FormAlterar();
                if (comboFiltro.Text == "Clientes")
                {
                    p.lblCodigo.Text = dgvPesquisa.CurrentRow.Cells[0].Value.ToString();
                    string nome = p.txtNomeCliente.Text = dgvPesquisa.CurrentRow.Cells[1].Value.ToString();
                    string cpf = p.txtCpfCliente.Text = dgvPesquisa.CurrentRow.Cells[2].Value.ToString();
                    string telefone = p.txtTelefoneCliente.Text = dgvPesquisa.CurrentRow.Cells[3].Value.ToString();
                    string endereco = p.txtEndereco.Text = dgvPesquisa.CurrentRow.Cells[4].Value.ToString();
                    
                    p.tabMed.Parent = null;
                    p.tabAgendamento.Parent = null;
                    p.tabConsul.Parent = null;
                    p.ShowDialog();
                }
                else if (comboFiltro.Text == "Médicos")
                {
                    p.lblCodigo.Text = dgvPesquisa.CurrentRow.Cells[0].Value.ToString();
                    p.txtNomeMédico.Text = dgvPesquisa.CurrentRow.Cells[1].Value.ToString();
                    p.txtCrm.Text = dgvPesquisa.CurrentRow.Cells[3].Value.ToString();
                    p.comboUF.Text = dgvPesquisa.CurrentRow.Cells[4].Value.ToString();
                    p.txtTelefoneMed.Text = dgvPesquisa.CurrentRow.Cells[2].Value.ToString();
                    p.comboDias.Text = dgvPesquisa.CurrentRow.Cells[5].Value.ToString();
                    p.comboEsp.Text = dgvPesquisa.CurrentRow.Cells[6].Value.ToString();

                    p.tabConsul.Parent = null;
                    p.tabAgendamento.Parent = null;
                    p.TabClientes.Parent = null;
                    p.Show();
                }
                else if (comboFiltro.Text == "Consultas")
                {
                    p.lblCodigo.Text = dgvPesquisa.CurrentRow.Cells[0].Value.ToString();
                    p.txtTipo.Text = dgvPesquisa.CurrentRow.Cells[1].Value.ToString();
                    p.txtValor.Text = dgvPesquisa.CurrentRow.Cells[2].Value.ToString();

                    p.tabMed.Parent = null;
                    p.TabClientes.Parent = null;
                    p.tabAgendamento.Parent = null;
                    p.Show();
                }
                else if (comboFiltro.Text == "Agendamentos")
                {
                    p.lblCodigo.Text = dgvPesquisa.CurrentRow.Cells[0].Value.ToString();
                    p.txtNomeAg.Text = dgvPesquisa.CurrentRow.Cells[1].Value.ToString();
                    p.txtCpfAg.Text = dgvPesquisa.CurrentRow.Cells[2].Value.ToString();
                    p.txtEndereAg.Text = dgvPesquisa.CurrentRow.Cells[3].Value.ToString();
                    p.txtTelefoneAg.Text = dgvPesquisa.CurrentRow.Cells[4].Value.ToString();
                    p.dataAgendamentoAg.Text = dgvPesquisa.CurrentRow.Cells[5].Value.ToString();
                    p.txtHoraAg.Text = dgvPesquisa.CurrentRow.Cells[6].Value.ToString();
                    p.comboConsultaAg.Text = dgvPesquisa.CurrentRow.Cells[7].Value.ToString();
                    p.comboValorAg.Text = dgvPesquisa.CurrentRow.Cells[8].Value.ToString();
                    p.comboMedicoAg.Text = dgvPesquisa.CurrentRow.Cells[9].Value.ToString();

                    p.tabMed.Parent = null;
                    p.TabClientes.Parent = null;
                    p.tabConsul.Parent = null;
                    p.Show();
                }
            }
        }

        private void btmDeletar_Click(object sender, EventArgs e)
        {
            cmd.Connection = con.conectar();
            try
            {
                string nome = dgvPesquisa.CurrentRow.Cells[1].Value.ToString();

                if (DialogResult.Yes == MessageBox.Show($"Tem certeza que deseja excluir o cliente {nome}? ", "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    try
                    {
                        string id = dgvPesquisa.CurrentRow.Cells[0].Value.ToString();

                        if (comboFiltro.Text == "Clientes")
                        {
                            cmd.CommandText = $"delete from Clientes where id_cliente='{id}' ";
                        }
                        else if (comboFiltro.Text == "Médicos")
                        {
                            cmd.CommandText = $"delete from Medicos where id_medico='{id}' ";
                        }
                        else if (comboFiltro.Text == "Especialidades")
                        {
                            cmd.CommandText = $"delete from Especialidades where id_especialidade='{id}' ";
                        }
                        else if (comboFiltro.Text == "Agendamentos")
                        {
                            cmd.CommandText = $"delete from Agendamentos where id_agendamento='{id}' ";
                        }
                        else if (comboFiltro.Text == "Consultas")
                        {
                            cmd.CommandText = $"delete from Consultas where id_consulta='{id}' ";
                        }


                        cmd.ExecuteNonQuery();

                        Atualizar();
                        MessageBox.Show("Dados removidos com sucesso");

                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Algo deu errado" + erro);
                    }
                    finally
                    {
                        con.conectar();
                    }
                }
                else
                {
                    con.desconectar();
                }
            }
            catch (System.NullReferenceException xe)
            {
                MessageBox.Show(xe.Message);
            }
            
        }

        public void Atualizar()
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
                    else if (comboFiltro.Text == "Especialidades")
                    {
                        cmd.CommandText = "Select * from Especialidades;";
                    }
                    else if (comboFiltro.Text == "Agendamentos")
                    {
                        cmd.CommandText = "Select * from Agendamentos;";
                    }
                    else if (comboFiltro.Text == "Consultas")
                    {
                        cmd.CommandText = "Select * from Consultas;";
                    }

                    //recebe os dados de uma tabela apos a execuçã de uma select
                    SqlDataAdapter da = new SqlDataAdapter();

                    DataTable dt = new DataTable();


                    //recebe os dados da instrução select
                    da.SelectCommand = cmd;
                    da.Fill(dt); //preenche o data table

                    dgvPesquisa.DataSource = dt;
                }
                catch (Exception)
                {
                    MessageBox.Show("Selecione uma tabela!!!");
                    con.desconectar();
                }
            }
            else
            {
                dgvPesquisa.DataSource = null;
                con.desconectar();
            }
        }

        private void btmPesquisar_Click(object sender, EventArgs e)
        {
            Atualizar();
        }

        private void comboFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboFiltro.Text == "Agendamentos")
            {
                btmVisualizar.Enabled = true;
                btmVisualizar.Visible = true;
            }
            else
            {
                btmVisualizar.Enabled = false;
                btmVisualizar.Visible = false;
            }
        }
    }
}
