using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApplication
{
    internal class OperationClass : InterfaceAddition, InterfaceMultiply, InterfaceConcatenation
    {
        public double multiply(double n1, double n2)
        {
            return n1 * n2;
        }

        public String concatination(String s1, String s2)
        {
            return s1 + s2;
        }

        public int add(int n1, int n2)
        {
            return n1 + n2;
        }
    }
}
