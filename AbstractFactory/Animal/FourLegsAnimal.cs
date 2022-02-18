using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Animal
{
    abstract class FourLegsAnimal : IAnimal
    {
        public abstract string GetName();        
    }
}
