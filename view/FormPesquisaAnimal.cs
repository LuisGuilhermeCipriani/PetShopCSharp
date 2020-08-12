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
    public partial class FormPesquisaAnimal : Form
    {
        AnimalController animalController;
        public FormPesquisaAnimal(AnimalController animalController)
        {
            InitializeComponent();
            this.animalController = animalController;
            configurarDataGridView();
        }

        private void configurarDataGridView()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID");
            dt.Columns.Add("Nome");
            dt.Columns.Add("Idade");
            dt.Columns.Add("Tipo");

            foreach (Animal a in animalController.getListaAnimais())
            {
                dt.Rows.Add(new object[] { a.getId(), a.getNome(), a.getIdade(), a.getTipo() });
            }

            dataGridView1.DataSource = dt;
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
