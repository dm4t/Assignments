using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Cube : Shape
    {
        float length;
        public override double CalculateArea()
        {
            throw new NotImplementedException();
        }

        public override double CalculateVolume()
        {
            return length * length * length;
        }

        public override void SetData()
        {
            Console.Write("Enter the length:");
            length = float.Parse(Console.ReadLine());
        }


        public override string ToString()
        {
            return "Cube: length: " + length + " volumen: " + CalculateVolume();
        }
    }
}
