namespace Principles.SOLID.OCP
{
    public class Cat : Animal
    {
        public Cat(string name) : base(name)
        {

        }

        override public string MakeSound()
        {
            return "Miaw";
        }
    }
}