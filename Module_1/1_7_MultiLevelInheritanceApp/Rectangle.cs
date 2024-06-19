using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelInheritanceApp
{
    internal class Rectangle : Shape
    {
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        public double getArea()
        {
            return height * width;
        }
    }
}
