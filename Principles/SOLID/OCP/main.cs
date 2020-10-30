using System.Collections.Generic;
using System.Linq;

namespace Principles.SOLID.OCP
{
    class Main
    {
        public List<Animal> Animals { get; set; }
        public void AnimalSounds_Bad(List<Animal> animals)
        {
            Animals.Add(new Animal("cat"));
            Animals.Add(new Animal("dog"));
            Animals.Add(new Animal("mice"));

            for (int i = 0; i < Animals.Count; i++)
            {
                if (Animals.ElementAt(i).Name == "cat")
                {
                    System.Console.WriteLine("miaw");
                }
                if (Animals.ElementAt(i).Name == "dog")
                {
                    System.Console.WriteLine("woff");
                }
                if (Animals.ElementAt(i).Name == "mice")
                {
                    System.Console.WriteLine("mi");
                }
            }
        }

        public void AnimalSounds_Good(List<Animal> animals)
        {
            for (int i = 0; i < animals.Count; i++)
            {
                animals.ElementAt(i).MakeSound();
            }
        }
    }
}