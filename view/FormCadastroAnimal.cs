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
    public partial class FormCadastroAnimal : Form
    {
        AnimalController AnimalController;
        int id = 0;
        public FormCadastroAnimal()
        {
            InitializeComponent();
            AnimalController = new AnimalController();
            rdCachorro.Focus();
        }

        private void limparCampos()
        {
            tbNome.Text = "";
            tbIdade.Text = "";
            tbNome.Focus();
            rdGato.Focus();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
           try
            {
                id++;
                string tipo = "Cachorro";
                if (rdGato.Checked)
                {
                    tipo = "Gato";
                }
                Animal animal = new Animal(tbNome.Text, int.Parse(tbIdade.Text), tipo);
                animal.setId(id);

                AnimalController.cadastrarAnimal(animal);
                MessageBox.Show("Animal cadastrado com sucesso!");
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Dados Incorretos!");
            }
        }
    }
}
