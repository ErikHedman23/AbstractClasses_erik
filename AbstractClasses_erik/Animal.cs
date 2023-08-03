using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses_erik
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        //using abstract allows you to create a stubbed out method

        public abstract void AbstractAnimal();

        public virtual void VirtualAnimal()
        {

        }
        

    }
}
