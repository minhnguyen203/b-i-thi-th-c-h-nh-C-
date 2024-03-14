using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baithi1
{
    
        public class Cylinder
    {
        double Radius { get; set; }
        double Height { get; set; }
        double BaseArea { get; set; }
        double LateralArea { get; set; }
        double TotalArea { get; set; }
        double Volume { get; set; }

        public void Process(double radius, double height)
        {
            Radius = radius;
            Height = height;

            BaseArea = Radius * Radius * Math.PI;
            LateralArea = 2 * Math.PI * Radius * Height;
            TotalArea = 2 * Math.PI * Radius * (Height + Radius);
            Volume = Math.PI * Radius * Radius * Height;
        }

        public string Result()
        {
            return $"Base Area: {BaseArea}\nLateral Area: {LateralArea}\nTotal Area: {TotalArea}\nVolume: {Volume}";
        }
    }
}
