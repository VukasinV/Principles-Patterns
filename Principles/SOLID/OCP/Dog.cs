namespace Principles.SOLID.OCP
{
    public class Dog : Animal
    {
        public override string Name { get => base.Name; set => base.Name = value; }
        public Dog(string name) : base(name)
        {

        }
        public override string MakeSound()
        {
            return "voff";
        }
    }
}