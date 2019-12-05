namespace Principles.SOLID.SRP
{
    public class Animal_1
    {
        public string Name { get; set; }
        public Animal_1 (string name)
        {
            Name = name;
        }

        public string GetAnimalName ()
        {
            return Name;
        }

        public void SaveAnimal ()
        {
            System.Console.WriteLine ("Save animal to database");
        }
    }
}