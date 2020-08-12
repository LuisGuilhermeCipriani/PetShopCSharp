using PetShopCSharp.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopCSharp.controller
{
    public class AnimalController
    {
        private List<Animal> listaAnimais;

        public AnimalController()
        {
            listaAnimais = new List<Animal>();
        }

        public void cadastrarAnimal(Animal animal)
        {
            listaAnimais.Add(animal);
        }

        public Boolean verificaAnimal(Animal animal)
        {
            foreach (Animal a in listaAnimais)
            {
                if((a.getNome().ToLower().Equals(animal.getNome().ToLower())) && (a.getIdade() == animal.getIdade()) && (a.getTipo().ToLower().Equals(animal.getTipo().ToLower())))
                {
                    return true;
                }
            }

            return false;
        }
        public List<Animal> getListaAnimais()
        {
            return listaAnimais;
        }
    }
}
