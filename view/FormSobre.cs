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
    public partial class FormSobre : Form
    {
        public FormSobre()
        {
            InitializeComponent();
            preencheAreadeTexto();
        }

        private void preencheAreadeTexto()
        {
            lbNome.Text = "Luís Guilherme da Cunha Cipriani";
            lbEndereco.Text = "XXXXXXXXXXXXXXXXXXXXX";
            lbData.Text = "13/08/2020";
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
