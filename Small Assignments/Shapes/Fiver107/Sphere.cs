using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Sphere : Shape
    {
        float radius;
        public override double CalculateArea()
        {
            throw new NotImplementedException();
        }

        public override double CalculateVolume()
        {
            return 4 / 3 * PI * Math.Pow(radius, 3);
        }

        public override void SetData()
        {
            Console.WriteLine("Enter the radius:");
            radius = float.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return "Sphere: radius: " + radius + " volumen: " + CalculateVolume();
        }
    }
}
