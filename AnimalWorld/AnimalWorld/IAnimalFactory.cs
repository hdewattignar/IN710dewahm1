using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorld
{
    public interface IAnimalFactory
    {
        Animal createAnimal(int animalCode);
    }

    public class NorthAmericanAnimalFactory : IAnimalFactory
    {
        public Animal createAnimal(int animalCode)
        {
            Animal newAnimal = null;

            switch(animalCode)
            {
                case 0:
                    newAnimal = new Eagle();
                    break;
                case 1:
                    newAnimal = new Dear();
                    break;
                case 2:
                    newAnimal = new Bear();
                    break;
                case 3:
                    newAnimal = new Wolf();
                    break;
            }

            return newAnimal;
        }
    }

    public class AustralianAnimalFactory : IAnimalFactory
    {
        public Animal createAnimal(int animalCode)
        {
            Animal newAnimal = null;

            switch (animalCode)
            {
                case 0:
                    newAnimal = new Kangaroo();
                    break;
                case 1:
                    newAnimal = new FrilledNeckLizard();
                    break;
                case 2:
                    newAnimal = new Wombat();
                    break;                
            }

            return newAnimal;
        }
    }
}
