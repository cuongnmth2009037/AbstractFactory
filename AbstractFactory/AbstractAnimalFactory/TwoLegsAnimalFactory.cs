using AbstractFactory.Animal;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.AbstractAnimalFactory
{
    class TwoLegsAnimalFactory : AbstractAnimalFactory
    {
        public override IAnimal createAnimal()
        {
            Random random = new Random();
            int type = random.Next(0, 2);
            if (type == 0)
            {
                return new Chicken();
            }
            else
            {
                return new Duck();
            }
        }
    }
}
