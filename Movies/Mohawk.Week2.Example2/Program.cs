using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Mohawk.Week2.Example2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Call method to read all temp_emp data into an array
            //Note: previously I was calling this method inside of my while loop
            //I've now moved the code here, so that the file is only read once at the start of my program
            Employee[] employess = ReadFileData("employees.txt");


            //We want to loop until a user enters the number 4
            //If we use an infinite loop, we need to make sure we have a break conidition
            while (true)
            {

                //Display a menu and prompt user for input
                Console.WriteLine("Please select an option");
                Console.WriteLine("1.Sort by Employee Name");
                Console.WriteLine("2.Sort by Employee Number");
                Console.WriteLine("3.Sort by Employee Pay Rate");
                Console.WriteLine("4.Sort by Employee Pay Haurs");
                Console.WriteLine("5.Sort by Employee Gross Pay");
                Console.WriteLine();
                Console.WriteLine("6.Exit");
                Console.WriteLine();


                string userInput = Console.ReadLine();

                //Check to see if the user entered a number
                if (int.TryParse(userInput, out int selection))
                {
                    //If the user chooses option 6, we can break out of our infinite loop
                    if (selection == 6)
                    {
                        break;
                    }

        
                    //Perform a different action based on user input
                    switch (selection)
                    {
                        case 1:
                            Console.Clear();
                            //Sort the employess and then output the list to the Console
                            SortName(employess);
                            Console.WriteLine("***Sorted by Employee Name***");
                            OutputName(employess);
                            break;
                        case 2:
                            Console.Clear();
                            SortNumber(employess);
                            Console.WriteLine("***Sorted by Employee Number***");
                            OutputNumber(employess);
                            break;
                        case 3:
                            Console.Clear();
                            SortRate(employess);
                            Console.WriteLine("***Sorted by Employee Rate***");
                            OutputRate(employess);
                            break;
                        case 4:
                            Console.Clear();
                            SortHours(employess);
                            Console.WriteLine("***Sorted by Employee Haurs***");
                            OutputHour(employess);
                            break;
                        case 5:
                            Console.Clear();
                            SortGross(employess);
                            Console.WriteLine("***Sorted by Employee Gross Pay***");
                            OutputGross(employess);
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Wrong input");
                            break;

                        
                    }

                }
                else
                {
                    //User entered an invalid selection
                    //Show an error message
                    Console.WriteLine("Please enter a number");
                }
            }
            //As soon as a user enters 4, we can exit the program
            //We don't need to wait for additional user input here, so there is no call to  Console.ReadKey()
        }


        /// <summary>
        ///  Reads temp_emp data from a specified file
        /// </summary>
        /// <param name="path">The path to a file containing temp_emp data</param>
        /// <returns>An array of employess</returns>
        static Employee[] ReadFileData(string path)
        {
            //Open a FileStream to a text file
            FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            //The first line of employess.txt contains a "Header" row
            //We want to read this line without processing it.
            //If we don't do this, the parsing logic below will fail on the first line
            reader.ReadLine();

            //For the purposes of this example, I am assuming the file will only contain 100 employess
            Employee[] allemployess = new Employee[100];

            //Keep track of the current line of where the reader is
            //We can use this as an array index
            int currentLine = 0;

            //Read until the end of the stream (end of the file)
            while (!reader.EndOfStream)
            {
                //Read a line from the FileStream
                //This will advance the Reader to the next line automatically
                string line = reader.ReadLine();
              
                //The employess.txt file contains values seperated by the '|' character
                //The string.Split method breaks a string into multiple strings wherever it finds a specified character
                string[] splitLine = line.Split(',');

                //Create a new instance of the temp_emp class
                Employee temp_employee = new Employee();

                //Call setters for our temp_emp using data from the file.
                temp_employee.SetName((splitLine[0]));
                temp_employee.SetNumber(int.Parse(splitLine[1]));
                temp_employee.SetRate(decimal.Parse(splitLine[2])); //Name does not need to be parsed because it is already a string
                temp_employee.SetHours(double.Parse(splitLine[3]));
                //if (double.Parse(splitLine[3]) > 40) { temp_emp.SetGross((decimal.Parse(splitLine[2]) * 40) + ((decimal.Parse(splitLine[3]) - 40)) * 1.5m); }
                //else { temp_emp.SetGross(decimal.Parse(splitLine[2]) * decimal.Parse(splitLine[3]));  }                
                //temp_emp.SetGross(decimal.Parse(temp_emp.GetHours()) * temp_emp.GetRatee()); 
                //temp_emp.SetGross(decimal.Parse(splitLine[4]));
                temp_employee.SetGross(decimal.Parse(splitLine[2]) * decimal.Parse(splitLine[3]));
                if (double.Parse(splitLine[3]) > 40) {
                    temp_employee.SetGross((decimal.Parse(splitLine[3])-40)*((decimal.Parse(splitLine[2])*1.5m))+ decimal.Parse(splitLine[2])*40);
                }
                else { temp_employee.SetGross(decimal.Parse(splitLine[2]) * decimal.Parse(splitLine[3])); }

                //Insert the temp_emp into our array, and then update our line counter
                allemployess[currentLine] = temp_employee;
                currentLine++;
            }

            //Always close your Stream!!
            stream.Close();


            return allemployess;
        }
        
        

        /// <summary>
        /// Takes an input array and reorders the elements to sort by year.This method uses a traditional Bubble Sort.
        /// </summary>
        /// <param name="employess">An array of employess to reorder</param>
        public static void SortName(Employee[] employess)
        {
            //Bubble sort implementation
            //In your assignment, you must research an alternative sorting algorithm
            //Look into Insertion Sort, or Selection Sort for examples
            //https://www.csharpstar.com/csharp-sorting-algorithms/
            Employee temp;

            for(int j = 0; j < employess.Length; j++)
            {
                for (int i = 0; i < employess.Length - 1; i++)
                {
                    try
                    {
                        Employee currentEmployee = employess[i];
                        Employee nextEmployee = employess[i + 1];
                        if (currentEmployee.GetName().CompareTo(nextEmployee.GetName()) > 0)
                        {
                            temp = nextEmployee;
                            nextEmployee = currentEmployee;
                            currentEmployee = temp;
                            employess[i + 1] = nextEmployee;
                            employess[i] = currentEmployee;
                        }
                    }
                    catch { break; }
                }
            }

        }
        

        /// <summary>
        /// Takes an array of employess and outputs them to the Console
        /// </summary>
        /// <param name="employess">The employess you would like to output</param>
        static void OutputName(Employee[] employess)
        {
            try
            {
                //Loop through each temp_emp and output them to the Console
                Console.WriteLine("{0,-30} {1,6} {2,8} {3,8} {4,10} {5,30} \n", "Name", "Number", "Rate", "Haurs", "Grose","Company Name");
                Console.WriteLine("{0,-30} {1,6} {2,8} {3,8} {4,10} {5,30}\n", new String('=', 30), new String('=', 6), new String('=', 8), new String('=', 8), new String('=', 10),new String('-',12));

                foreach (Employee temp_emp in employess)
                {
                    //This will call the ToString method of the temp_emp class
                    Console.WriteLine("{0,-30} {1,6} {2,8} {3,8} {4,10:N2}", temp_emp.GetName(), temp_emp.GetNumber(),temp_emp.GetRatee(),temp_emp.GetHours(), temp_emp.GetGross());
                }
            }
            catch { }

            //Writes an empty line to the console
            Console.WriteLine();
        }
        

        public static void SortNumber(Employee[] employess)
        {
            //Bubble sort implementation
            //In your assignment, you must research an alternative sorting algorithm
            //Look into Insertion Sort, or Selection Sort for examples
            //https://www.csharpstar.com/csharp-sorting-algorithms/
            Employee temp;

            for (int j = 0; j < employess.Length; j++)
            {
                for (int i = 0; i < employess.Length - 1; i++)
                {
                    try
                    {
                        Employee currentEmployee = employess[i];
                        Employee nextEmployee = employess[i + 1];
                        if (currentEmployee.GetNumber() > nextEmployee.GetNumber())
                        {
                            temp = nextEmployee;
                            nextEmployee = currentEmployee;
                            currentEmployee = temp;
                            employess[i + 1] = nextEmployee;
                            employess[i] = currentEmployee;
                        }
                    }
                    catch { break; }
                }
            }

        }

        static void OutputNumber(Employee[] employess)
        {
            try
            {
                //Loop through each temp_emp and output them to the Console
                Console.WriteLine("{0,-30} {1,6} {2,8} {3,8} {4,10} {5,30} \n", "Name", "Number", "Rate", "Haurs", "Grose", "Company Name");
                Console.WriteLine("{0,-30} {1,6} {2,8} {3,8} {4,10} {5,30}\n", new String('=', 30), new String('=', 6), new String('=', 8), new String('=', 8), new String('=', 10), new String('-', 12));

                foreach (Employee temp_emp in employess)
                {
                    //This will call the ToString method of the temp_emp class
                    Console.WriteLine("{0,-30} {1,6} {2,8} {3,8} {4,10:N2}", temp_emp.GetName(), temp_emp.GetNumber(),"$"+temp_emp.GetRatee(), temp_emp.GetHours(),temp_emp.GetGross());
                }
            }
            catch { }

            //Writes an empty line to the console
            Console.WriteLine();
        }


        public static void SortRate(Employee[] employess)
        {
            //Bubble sort implementation
            //In your assignment, you must research an alternative sorting algorithm
            //Look into Insertion Sort, or Selection Sort for examples
            //https://www.csharpstar.com/csharp-sorting-algorithms/
            Employee temp;

            for (int j = 0; j < employess.Length; j++)
            {
                for (int i = 0; i < employess.Length - 1; i++)
                {
                    try
                    {
                        Employee currentEmployee = employess[i];
                        Employee nextEmployee = employess[i + 1];
                        if (currentEmployee.GetRatee() < nextEmployee.GetRatee())
                        {
                            temp = nextEmployee;
                            nextEmployee = currentEmployee;
                            currentEmployee = temp;
                            employess[i + 1] = nextEmployee;
                            employess[i] = currentEmployee;
                        }
                    }
                    catch { break; }
                }
            }

        }

        static void OutputRate(Employee[] employess)
        {
            try
            {
                //Loop through each temp_emp and output them to the Console
                Console.WriteLine("{0,-30} {1,6} {2,8} {3,8} {4,10} {5,30} \n", "Name", "Number", "Rate", "Haurs", "Grose", "Company Name");
                Console.WriteLine("{0,-30} {1,6} {2,8} {3,8} {4,10} {5,30}\n", new String('=', 30), new String('=', 6), new String('=', 8), new String('=', 8), new String('=', 10), new String('-', 12));

                foreach (Employee temp_emp in employess)
                {
                    //This will call the ToString method of the temp_emp class
                    Console.WriteLine("{0,-30} {1,6} {2,8} {3,8} {4,10:N2}", temp_emp.GetName(), temp_emp.GetNumber(),"$"+temp_emp.GetRatee(),temp_emp.GetHours(),temp_emp.GetGross());
                }
            }
            catch { }

            //Writes an empty line to the console
            Console.WriteLine();
        }

        public static void SortHours(Employee[] employess)
        {
            //Bubble sort implementation
            //In your assignment, you must research an alternative sorting algorithm
            //Look into Insertion Sort, or Selection Sort for examples
            //https://www.csharpstar.com/csharp-sorting-algorithms/
            Employee temp;

            for (int j = 0; j < employess.Length; j++)
            {
                for (int i = 0; i < employess.Length - 1; i++)
                {
                    try
                    {
                        Employee currentEmployee = employess[i];
                        Employee nextEmployee = employess[i + 1];
                        if (currentEmployee.GetHours() < nextEmployee.GetHours())
                        {
                            temp = nextEmployee;
                            nextEmployee = currentEmployee;
                            currentEmployee = temp;
                            employess[i + 1] = nextEmployee;
                            employess[i] = currentEmployee;
                        }
                    }
                    catch { break; }
                }
            }

        }

        static void OutputHour(Employee[] employess)
        {
            try
            {
                //Loop through each temp_emp and output them to the Console
                Console.WriteLine("{0,-30} {1,6} {2,8} {3,8} {4,10} {5,30} \n", "Name", "Number", "Rate", "Haurs", "Grose", "Company Name");
                Console.WriteLine("{0,-30} {1,6} {2,8} {3,8} {4,10} {5,30}\n", new String('=', 30), new String('=', 6), new String('=', 8), new String('=', 8), new String('=', 10), new String('-', 12));

                foreach (Employee temp_emp in employess)
                {
                    //This will call the ToString method of the temp_emp class
                    Console.WriteLine("{0,-30} {1,6} {2,8} {3,8} {4,10:N2}", temp_emp.GetName(), temp_emp.GetNumber(),"$"+temp_emp.GetRatee(), temp_emp.GetHours(),temp_emp.GetGross());
                }
            }
            catch { }

            //Writes an empty line to the console
            Console.WriteLine();
        }

        public static void SortGross(Employee[] employess)
        {
            //Bubble sort implementation
            //In your assignment, you must research an alternative sorting algorithm
            //Look into Insertion Sort, or Selection Sort for examples
            //https://www.csharpstar.com/csharp-sorting-algorithms/
            Employee temp;

            for (int j = 0; j < employess.Length; j++)
            {
                for (int i = 0; i < employess.Length - 1; i++)
                {
                    try
                    {
                        Employee currentEmployee = employess[i];
                        Employee nextEmployee = employess[i + 1];
                        if (currentEmployee.GetGross() < nextEmployee.GetGross())
                        {
                            temp = nextEmployee;
                            nextEmployee = currentEmployee;
                            currentEmployee = temp;
                            employess[i + 1] = nextEmployee;
                            employess[i] = currentEmployee;
                        }
                    }
                    catch { break; }
                }
            }

        }

        static void OutputGross(Employee[] employess)
        {
            try
            {
                //Loop through each temp_emp and output them to the Console
                Console.WriteLine("{0,-30} {1,6} {2,8} {3,8} {4,10} {5,30} \n", "Name", "Number", "Rate", "Haurs", "Grose", "Company Name");
                Console.WriteLine("{0,-30} {1,6} {2,8} {3,8} {4,10} {5,30}\n", new String('=', 30), new String('=', 6), new String('=', 8), new String('=', 8), new String('=', 10), new String('-', 12));

                foreach (Employee temp_emp in employess)
                {
                    //This will call the ToString method of the temp_emp class
                    Console.WriteLine("{0,-30} {1,6} {2,8} {3,8} {4,10:N2}", temp_emp.GetName(), temp_emp.GetNumber(), "$"+temp_emp.GetRatee(), temp_emp.GetHours(), temp_emp.GetGross());
                }
            }
            catch { }

            //Writes an empty line to the console
            Console.WriteLine();
        }






    }
}
