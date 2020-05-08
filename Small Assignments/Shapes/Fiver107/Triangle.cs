using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Triangle : Shape
    {
        float _base;
        float height;
        public override double CalculateArea()
        {
            throw new NotImplementedException();
        }

        public override double CalculateVolume()
        {
            return _base * height;
        }

        public override void SetData()
        {
            Console.WriteLine("Enter the base:");
            _base = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height:");
            height = float.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return "Triangle: base: " + _base + " height: " + height +" volumen: " + CalculateVolume();
        }
    }
}
