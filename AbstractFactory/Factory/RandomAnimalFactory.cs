using AbstractFactory.Animal;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Factory
{
    class RandomAnimalFactory : IAnimalFactory
    {
        public IAnimal createAnimal()
        {
            Random random = new Random();
            int type = random.Next(0, 3);
            if (type == 0)
            {
                return new Dog();
            }
            else if (type == 1)
            {
                return new Cat();
            }
            else
            {
                return new Duck();
            }
        }
    }
}
