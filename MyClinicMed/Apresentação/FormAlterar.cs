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
    }
}
