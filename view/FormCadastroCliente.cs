using PetShopCSharp.controller;
using PetShopCSharp.model;
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
    public partial class FormCadastroCliente : Form
    {
        private ClienteController clienteController;
        int id = 0;
        public FormCadastroCliente(ClienteController clienteController)
        {
            InitializeComponent();
            tbNome.Focus();
            this.clienteController = clienteController;
            enviaParaPesquisaCliente();
        }

        private void enviaParaPesquisaCliente()
        {
            FormPesquisaCliente form = new FormPesquisaCliente(clienteController);
        }

        private void limparCampos()
        {
            tbNome.Text = "";
            tbIdade.Text = "";
            tbCpf.Text = "";
            tbNome.Focus();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente(tbNome.Text, tbCpf.Text, int.Parse(tbIdade.Text));
                id++;
                cliente.setId(id);
                if (clienteController.verificaCliente(cliente))
                {
                    MessageBox.Show("Este CPF já está cadastrado!");
                }
                else
                {
                    clienteController.cadastrarCliente(cliente);
                    MessageBox.Show("Cadastro realizado com sucesso!");
                    limparCampos();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Dados incorretos!");
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
    }
}
