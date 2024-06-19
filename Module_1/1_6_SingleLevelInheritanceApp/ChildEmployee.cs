using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLevelInheritanceApp
{
    internal class ChildEmployee : BaseEmployee
    {
        public ChildEmployee(string n, double b) : base(n, b)
        { 
        }

    }
}
