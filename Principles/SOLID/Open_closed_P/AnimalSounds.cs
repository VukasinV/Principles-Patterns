
using System.Linq;
using System.Generics;

namespace Principles.SOLID.Open_closed_P
{
    class AnimalSounds
    {
        public void AnimalSounds()
        {
            List<Animal1> animals = new List<Animal1>();
            animals.add(new Animal1("lion"));
            animals.add(new Animal1("mouse"));

            void AnimalSounds(List<Animal1> animals)
            {
                for (int i = 0; i <= animals.Count; i++)
                {
                    if (animals.ElementAt(i).Name == "lion")
                    {
                        System.Console.WriteLine("Roar");
                    }
                    if (animals.ElementAt(i).Name == "mouse")
                    {
                        System.Console.WriteLine("Squeak");
                    }
                }
            }
        }
    }
}