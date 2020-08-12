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
        private AnimalController animalController;
        int id = 0;
        public FormCadastroAnimal(AnimalController animalController)
        {
            InitializeComponent();
            rdCachorro.Focus();
            this.animalController = animalController;
            enviaParaPesquisaAnimal();
        }

        private void enviaParaPesquisaAnimal()
        {
            FormPesquisaAnimal form = new FormPesquisaAnimal(animalController);
        }


        private void limparCampos()
        {
            tbNome.Text = "";
            tbIdade.Text = "";
            tbNome.Focus();
            rdCachorro.Focus();
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

                if (animalController.verificaAnimal(animal))
                {
                    MessageBox.Show("Esse animal já está cadastrado!");
                }
                else
                {
                    animalController.cadastrarAnimal(animal);
                    MessageBox.Show("Animal cadastrado com sucesso!");
                    limparCampos();
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Dados Incorretos!");
            }
        }
    }
}
