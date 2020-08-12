using PetShopCSharp.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShopCSharp.view
{
    public partial class FormTelaPrincipal : Form
    {
        ClienteController clienteController;
        public FormTelaPrincipal()
        {
            InitializeComponent();
            clienteController = new ClienteController();
            enviaParaCadastroCliente();
        }

        private void enviaParaCadastroCliente()
        {
            FormCadastroCliente form = new FormCadastroCliente(clienteController);
        }
        protected override void WndProc(ref Message message)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;

            switch (message.Msg)
            {
                case WM_SYSCOMMAND:
                    int command = message.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;
            }

            base.WndProc(ref message);
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroCliente formCadastroCliente = new FormCadastroCliente(clienteController);
            formCadastroCliente.ShowDialog();
        }

        private void ferramentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void animalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroAnimal formCadastroAnimal = new FormCadastroAnimal();
            formCadastroAnimal.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormPesquisaCliente formPesquisaCliente = new FormPesquisaCliente(clienteController);
            formPesquisaCliente.ShowDialog();
        }
    }
}
