using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Animal
{
    class Chicken : TwoLegsAnimal
    {
        public override string GetName()
        {
            return "I am Chicken";
        }
    }
}
