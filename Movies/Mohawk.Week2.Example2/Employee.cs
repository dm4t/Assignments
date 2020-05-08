using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mohawk.Week2.Example2
{
    class Employee
    {
        private string name;
        private int number;
        private decimal rate;
        private double hours;
        private decimal gross;

        public Employee()
        {

        }


        //Create Getters and Setters to store our movie data
        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }

        public decimal GetRatee()
        {
            return rate;
        }
        public void SetRate(decimal rate)
        {
            this.rate = rate;
        }

        public double GetHours()
        {
            return hours;
        }
        public void SetHours(double hours)
        {
            this.hours = hours;
        }

        public decimal GetGross()
        {
            return gross;
        }
        public void SetGross(decimal gross)
        {
            this.gross = gross;
        }

        public int GetNumber()
        {
            return number;
        }
        public void SetNumber(int number)
        {
            this.number = number;
        }
        
    }
}
