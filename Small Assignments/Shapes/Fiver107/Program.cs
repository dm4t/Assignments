using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            char input;

            List<Shape> Shapes = new List<Shape>();

            while (true)
            {

                Console.WriteLine("A - Rectangle \n" +
                    "B - Square \n" +
                    "C - Box \n" +
                    "D - Cube \n" +
                    "E - Ellipse \n" +
                    "F - Circle \n" +
                    "G - Cylinder \n" +
                    "H - Sphere \n" +
                    "I - Triangle \n" +
                    "J - Tetrahedron \n " +
                    "\n0 - List all shapes and Exit      ("+ Shapes.Count + " Size)");
                
                input = Char.Parse(Console.ReadLine());

                switch (input)
                {

                    case 'A':
                    case 'a':
                        var newRectangle = new Rectangle();
                        newRectangle.SetData();
                        Shapes.Add(newRectangle);
                        break;
                    case 'B':
                    case 'b':
                        var newSquare = new Square();
                        newSquare.SetData();
                        Shapes.Add(newSquare);
                        break;
                    case 'C':
                    case 'c':
                        var newBox = new Box();
                        newBox.SetData();
                        Shapes.Add(newBox);
                        break;
                    case 'D':
                    case 'd':
                        var newCube = new Cube();
                        newCube.SetData();
                        Shapes.Add(newCube);
                        break;
                    case 'E':
                    case 'e':
                        var newEllipse = new Ellipse();
                        newEllipse.SetData();
                        Shapes.Add(newEllipse);
                        break;
                    case 'F':
                    case 'f':
                        var newCircle = new Circle();
                        newCircle.SetData();
                        Shapes.Add(newCircle);
                        break;
                    case 'G':
                    case 'g':
                        var newCylinder = new Cylinder();
                        newCylinder.SetData();
                        Shapes.Add(newCylinder);
                        break;
                    case 'H':
                    case 'h':
                        var newSphere = new Sphere();
                        newSphere.SetData();
                        Shapes.Add(newSphere);
                        break;
                    case 'I':
                    case 'i':
                        var newTriangle = new Triangle();
                        newTriangle.SetData();
                        Shapes.Add(newTriangle);

                        break;
                    case 'J':
                    case 'j':
                        var newTetrahedron = new Tetrahedron();
                        newTetrahedron.SetData();
                        Shapes.Add(newTetrahedron);

                        break;
                    case '0':

                        foreach (Shape temp in Shapes)
                        {
                            
                            Console.WriteLine(temp.ToString());

                        }
                        Console.Read();
                       
                        break;

                }

                
                
                Console.Clear();
            }


        }
    }
}
