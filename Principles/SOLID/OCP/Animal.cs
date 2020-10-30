using System;

namespace Principles.SOLID.OCP
{
    public class Animal
    {
        public virtual string Name { get; set; }
        public Animal(string name)
        {
            Name = name;
        }

        public virtual string MakeSound()
        {
            return null;
        }
    }
}