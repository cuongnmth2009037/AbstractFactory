using AbstractFactory.Animal;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Factory
{
    interface IAnimalFactory
    {
        IAnimal createAnimal();
    }
}
