using AbstractFactory.Animal;
using AbstractFactory.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.AbstractAnimalFactory
{
    abstract class AbstractAnimalFactory : IAnimalFactory
    {
        public abstract IAnimal createAnimal();
    }
}
