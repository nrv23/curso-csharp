using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP.clasess
{
    public class Rectangle
    {

        private int _width;
        private int _height;

        // forma como se puede usar properties 

        public int Width
        {
            get => this._width;
            set => this._width = this.SetDefaultValueIfNotPositive(value, nameof(this._width));
        }
        public int Height
        {
            get => this._height;
            private set => this._height = this.SetDefaultValueIfNotPositive(value, nameof(this._height));
        }

        // otra forma de definir properties

        //public int Width { get; private set; } de esta manera se puede definir un property directamente

        public Rectangle(int width, int height)
        {
     
            this._width = this.SetDefaultValueIfNotPositive(width, nameof(this._width));
            this._height = this.SetDefaultValueIfNotPositive(height,nameof(this._height));
    
        }

        public int GetHeight() => this._height;
        

        private int SetDefaultValueIfNotPositive(int value, string prop)
        {
         
            const int defaultValueifNotPositive = 1;
            if(value < 0 || value == 0)
            {
                Console.WriteLine($"{prop} es negativo, se asigna el valor por defecto de 1");
                return defaultValueifNotPositive;
            }
               
            return value;
        }
    }
}
