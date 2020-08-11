using PetShopCSharp.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopCSharp.controller
{
    class AnimalController
    {
        private List<Animal> listaAnimais;

        public AnimalController()
        {
            listaAnimais = new List<Animal>();
        }

        public void cadastrarAnimal()
        {
            Animal animal = new Animal();
            listaAnimais.Add(animal);
        }

        public List<Animal> getListaAnimais()
        {
            return listaAnimais;
        }
    }
}
