using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterestApplication
{
    internal class SimpleInterestCalculator
    {

        double pamount;
        int year;
        double interest;
        public double Pamount
        { 
            get 
            { 
                return pamount; 
            } 
            set 
            { 
                pamount = value; 
            } 
        }
        public int Year
        { 
            get 
            { 
                return year; 
            } 
            set 
            { 
                year = value; 
            } 
        }
        public double Interest
        { 
            get 
            { 
                return interest; 
            } 
            set 
            { 
                interest = value; 
            } 
        }

        public double getSI()
        { 
            return ((pamount * year * interest) / 100); 
        }

    }
}
