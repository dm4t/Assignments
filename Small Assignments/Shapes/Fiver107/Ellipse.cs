using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Ellipse : Shape

    {
        float semimajor;
        float semiminor;


        public override double CalculateArea()
        {
            return PI * semimajor * semimajor;
        }

        public override double CalculateVolume()
        {
            throw new NotImplementedException();
        }

        public override void SetData()
        {
            Console.Write("Enter the semi-major axis length:");
            semimajor = float.Parse(Console.ReadLine());
            Console.Write("Enter the semi-minor axis length:");
            semiminor = float.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return "Ellipse: semimajor: " + semimajor + " semiminor: "+ semiminor +" area: " + CalculateArea();
        }
    }
}
