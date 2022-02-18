using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Animal
{
    class Cat : FourLegsAnimal
    {
        public override string GetName()
        {
            return "I am Cat";
        }
    }
}
