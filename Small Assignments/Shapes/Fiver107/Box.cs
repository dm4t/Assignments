using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Box : Shape
    {
        float length;
        float width;
        float height;

        public override double CalculateArea()
        {
            throw new NotImplementedException();
        }

        public override double CalculateVolume()
        {
            return length * width * height;
        }

        public override void SetData()
        {
            Console.Write("Enter the length:");
            length = float.Parse(Console.ReadLine());
            Console.Write("Enter the widht:");
            width = float.Parse(Console.ReadLine());
            Console.Write("Enter the height:");
            height = float.Parse(Console.ReadLine());
        }
        public override string ToString()
        {
            return "Box:  length:" + length + " width:" + width + " height: " + height + " volumen: "+CalculateVolume();
        }
    }
}
