using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA_SOLID.LSP.Validate
{
    public class Rectangle:Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

       public double RectangleArea()
        {
            return Width * Height;
        }
    }
}
