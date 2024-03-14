using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baithi2
{
    public class Animal
    {
        public int Weight { get; set; }
        public string Name { get; set; }

        public Animal(int weight, string name)
        {
            Weight = weight;
            Name = name;
        }

        public virtual void Show()
        {
            Console.WriteLine($"Name: {Name}, Weight: {Weight}");
        }

        public void SetMe(int weight, string name)
        {
            Weight = weight;
            Name = name;
        }
    }

    // Derived class called Lion
    public class Lion : Animal
    {
        public Lion(int weight, string name) : base(weight, name)
        {
        }

        public override void Show()
        {
            Console.WriteLine($"Name: {Name}, Weight: {Weight}");
        }
    }

    // Derived class called Tiger
    public class Tiger : Animal
    {
        public Tiger(int weight, string name) : base(weight, name)
        {
        }

        public override void Show()
        {
            Console.WriteLine($"Name: {Name}, Weight: {Weight}");
        }
    }
}
