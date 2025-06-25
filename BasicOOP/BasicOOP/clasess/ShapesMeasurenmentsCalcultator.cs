using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP.clasess
{
    public  class ShapesMeasurementsCalcultator
    {

        public int CalculateArea(Rectangle rectangle) => rectangle.Width * rectangle.Height;
        

        public int CalculateCircumference(Rectangle rectangle) => 2 * (rectangle.Width * rectangle.Height);
        
    }
}
