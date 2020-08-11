using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopCSharp.model
{
    class Animal
    {
        private int id;
        private string nome;
        private int idade;

        public Animal() { }

        public Animal(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }

        public string getNome()
        {
            return nome;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public int getIdade()
        {
            return idade;
        }

        public void setIdade(int idade)
        {
            this.idade = idade;
        }
    }
}
