using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Square : Shape
    {
        float length;
        public override double CalculateArea()
        {
            return length * length;
        }

        public override double CalculateVolume()
        {
            throw new NotImplementedException();
        }

        public override void SetData()
        {
            Console.Write("Enter the length:");
            length = float.Parse(Console.ReadLine());
        }
        public override string ToString()
        {
            return "Square: length: " + length +" area: " + CalculateArea();
        }
    }
}
