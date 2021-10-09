using MyClinicMed.DAL;
using MyClinicMed.Modelo;
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
    public partial class FmrCadastrar : Form
    {
        public FmrCadastrar()
        {
            InitializeComponent();
        }

        private void btmCadastrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            String mensagem = controle.cadastrar(txtUsuarioCadastro.Text, txtSenhaCadastro.Text, txtConfirmarSenha.Text);
            if (controle.tem)//messagem sucesso
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtConfirmarSenha.Text = "";
                txtSenhaCadastro.Text = "";
                txtUsuarioCadastro.Text = "";
            }
            else
            {
                MessageBox.Show(controle.mensagem);//mensagem de erro
            }

            
        }
    }
}
