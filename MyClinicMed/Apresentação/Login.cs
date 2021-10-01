using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using MyClinicMed.Modelo;

namespace MyClinicMed
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btmClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;
        }

        private void btmMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (txtSenha.UseSystemPasswordChar == true)
            {
                txtSenha.UseSystemPasswordChar = false;
            }
            else if (txtSenha.UseSystemPasswordChar == false)
            {
                txtSenha.UseSystemPasswordChar = true;
            }
        }

        private void linkCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FmrCadastrar cadastro = new FmrCadastrar();

            cadastro.Show();
        }

        private void btmEntrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(txtUsuario.Text, txtSenha.Text);
            if (controle.mensagem.Equals(""))
            {
                if (controle.tem)
                { 
                    MessageBox.Show("Logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    FormMenu menu = new FormMenu();
                    menu.Closed += (s, args) => this.Close();

                    menu.Show();
                }
                else
                {
                    MessageBox.Show("Usuario não encontrado, verifique usuario e senha", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }

        private void btmEntrar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btmEntrar.PerformClick();
            }

        }
    }
}
