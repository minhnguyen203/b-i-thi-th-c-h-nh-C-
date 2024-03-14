using Baithi1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baithi1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius:");
            double radius = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the height:");
            double height = double.Parse(Console.ReadLine());

            Cylinder cylinder = new Cylinder();
            cylinder.Process(radius, height);
            Console.WriteLine(cylinder.Result());
        }
    }
}

