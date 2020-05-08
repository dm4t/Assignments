using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace App
{
    class Rectangle : Shape
    {
        float length;
        float width;

        

        public override double CalculateArea()
        {
            return length * width;
        }

        public override double CalculateVolume()
        {
            throw new NotImplementedException();
        }

        public override void SetData()
        {
            Console.Write("Enter the length:");
            length = float.Parse(Console.ReadLine());
            Console.Write("Enter the widht:");
            width = float.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return "Rectangle: radius: " + length + " width: " + width + " volumen: " + CalculateArea();
        }
    }
}
