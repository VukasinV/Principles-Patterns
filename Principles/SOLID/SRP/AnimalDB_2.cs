namespace Principles.SOLID.SRP
{
    public class AnimalDB_2
    {
        public Animal_2 GetAnimal()
        {
            System.Console.WriteLine("Gets animal from DB");
        }

        public void SaveAnimal()
        {
            System.Console.WriteLine("Saves animal to database");
        }
    }
}