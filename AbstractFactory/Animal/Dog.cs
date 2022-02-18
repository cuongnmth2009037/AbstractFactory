using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Animal
{
    class Dog : FourLegsAnimal
    {
        public override string GetName()
        {
            return "I am Dog";
        }
    }
}
