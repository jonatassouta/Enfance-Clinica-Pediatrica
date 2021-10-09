using MyClinicMed.Apresentação;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyClinicMed
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        public void AbrirFomularioFilho(object formulariofilho)
        {
            if (this.panelContainer.Controls.Count > 0)
                this.panelContainer.Controls.RemoveAt(0);

            Form fh = formulariofilho as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContainer.Controls.Add(fh);
            this.panelContainer.Tag = fh;
            fh.Show();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btmClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btmMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timerHora_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToLongTimeString();
            labelData.Text = DateTime.Now.ToShortDateString();
        }

        private void btmAgendamento_Click(object sender, EventArgs e)
        {
            AbrirFomularioFilho(new FormAgendamento(this, new Login()));
        }

        private void btmCadastros_Click(object sender, EventArgs e)
        {
            AbrirFomularioFilho(new FormCadastros());
        }

        private void btmConsultas_Click(object sender, EventArgs e)
        {
            AbrirFomularioFilho(new FormConsultas());
        }

        private void btmInfo_Click(object sender, EventArgs e)
        {
            AbrirFomularioFilho(new FormInfo());
        }

        private void btmHome_Click(object sender, EventArgs e)
        {
            AbrirFomularioFilho(new FormHome());
        }
    }
}
