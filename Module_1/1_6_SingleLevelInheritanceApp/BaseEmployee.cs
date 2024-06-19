using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLevelInheritanceApp
{
    internal class BaseEmployee
    {
        protected string name;
        protected double basic;

        public BaseEmployee(string n, double b)
        {
            name = n;
            basic = b;
        }
        public string getName()
        {
            return name;
        }

        public double getSalary()
        {
            return basic + .30 * basic + .40 * basic;

        }
    }
}
