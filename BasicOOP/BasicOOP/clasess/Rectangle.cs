using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP.clasess
{
    public class Rectangle
    {

        public int Width;
        public int Height;

        public Rectangle(int width, int height)
        {
            if (width < 0 || height < 0) throw new Exception("valores son menores a 0");
            this.Width = width;
            this.Height = height;
        }
    }
}
