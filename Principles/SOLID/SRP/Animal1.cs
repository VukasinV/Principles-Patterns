namespace Principles.SOLID.SRP
{
    /// <summary>
    /// This Animal class has 2 responsibilities. It keeps animal properties and saves Animal to database
    /// 
    /// </summary>
    public class Animal1
    {
        public string Name { get; set; }
        public Animal1(string name)
        {
            Name = name;
        }

        public string GetAnimalName()
        {
            return Name;
        }

        public void SaveAnimal()
        {
            System.Console.WriteLine("Save animal to database");
        }
    }
}