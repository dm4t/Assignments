using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Cylinder : Shape
    {
        float radius;
        float height;

        public override double CalculateArea()
        {
            return PI * radius * radius;
        }

        public override double CalculateVolume()
        {
            return PI * radius * radius * height;
        }

        public override void SetData()
        {
            Console.Write("Enter the radius:");
            radius = float.Parse(Console.ReadLine());
            Console.Write("Enter the height:");
            height = float.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return "Cylinder: radius: " + radius + " height: "+ height + " volumen: " + CalculateVolume();
        }
    }
}
