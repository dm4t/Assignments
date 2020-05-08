using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Circle : Shape
    {
        float radius;
        public override double CalculateArea()
        {
            return PI * radius * radius;
        }

        public override double CalculateVolume()
        {
            throw new NotImplementedException();
        }

        public override void SetData()
        {
            Console.WriteLine("Enter radius");
            float.Parse(Console.ReadLine());

        }

        public override string ToString()
        {
            return "Circle: radius: " + radius + " area: " + CalculateArea();
        }
    }
}
