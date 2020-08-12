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
using PetShopCSharp.model;

namespace PetShopCSharp.view
{
    public partial class FormPesquisaCliente : Form
    {
        ClienteController clienteController;
        public FormPesquisaCliente(ClienteController clienteController)
        {
            InitializeComponent();
            this.clienteController = clienteController;
            //ClienteController = new ClienteController();
            configurarDataGridView();
        }

        private void configurarDataGridView()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID");
            dt.Columns.Add("Nome");
            dt.Columns.Add("CPF");
            dt.Columns.Add("Idade");

            foreach (Cliente c in clienteController.getListaClientes())
            {
                dt.Rows.Add(new object[] { c.getId(), c.getNome(), c.getCpf(), c.getIdade() });
            }
            
            dataGridView1.DataSource = dt;
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
