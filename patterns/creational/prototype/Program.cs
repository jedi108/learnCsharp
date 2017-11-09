using System;


namespace prototype
{
    public abstract class Prototypes
    {
        public string name { get; set;}
        public Prototypes(string name)
        {
            this.name = name;
            Console.WriteLine("base constructor");
        }
        public virtual Prototypes Clone()
        {
            return (Prototypes)this.MemberwiseClone();
        }
    }

    public class DivPrototype : Prototypes
    {
        public DivPrototype(string name) : base(name) {}
    }

    public class BoldPrototype : Prototypes
    {
        public BoldPrototype(string name) : base(name) {}
    }

    class Program
    {
        static void Main(string[] args)
        {
            Prototypes prototypeDiv = new DivPrototype("test");
            Prototypes clonedPrototypeDiv = prototypeDiv.Clone();
            Console.WriteLine("Cloned", clonedPrototypeDiv.name);
        }
    }
}
