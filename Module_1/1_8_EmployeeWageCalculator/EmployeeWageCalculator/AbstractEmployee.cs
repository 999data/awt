using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageCalculator
{
    abstract class AbstractEmployee
    {
        string ename = "", dname = "";
        public string Ename { get {  return ename; } set { ename = value; } }
        public string Dname { get { return dname; } set { dname = value; } }

        public abstract double getSalary();
    }

    class HEmp : AbstractEmployee
    {
        int hrs;
        public int Hrs { get { return hrs; } set { hrs = value; } }
        public override double getSalary() { return hrs * 500; }
    }

    class Manager : AbstractEmployee
    {
        int basic;
        double da = .5, ta = .2, pf = .4;
        public int Basic { get { return basic; } set { basic = value; } }

        public override double getSalary() { return basic + (basic * da) + (basic * ta) - (basic * pf); }
    }
}
