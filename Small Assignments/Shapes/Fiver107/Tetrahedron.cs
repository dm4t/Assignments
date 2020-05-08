using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Tetrahedron : Shape
    {
        float length;
        public override double CalculateArea()
        {
            throw new NotImplementedException();
        }

        public override double CalculateVolume()
        {
            return Math.Pow(length, 3) / 6 * Math.Sqrt(2);
        }

        public override void SetData()
        {
            Console.WriteLine("Enter the length");
            length = float.Parse(Console.ReadLine()); ;
        }

        public override string ToString()
        {
            return "Tetrahedron: length: " + length + " volumen: " + CalculateVolume();
        }
    }
}
