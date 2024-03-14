using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baithi2
{
    internal class Program
    {
       static void Main(string[] args)
        {
            // Create instances of derived classes and call the Show() method
            Lion lion = new Lion(200, "lion");
            lion.Show();

            Tiger tiger = new Tiger(100, "tiger");
            tiger.Show();
        }
    }
}
