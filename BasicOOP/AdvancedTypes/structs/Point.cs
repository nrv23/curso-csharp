using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTypes.structs
{
   // public struct Point: IComparable
    public struct Point: IEquatable<Point> // los struct implmentan intrfaces
    {
        public int X { get; init; } // init solo permite asignar el valor en la inicializacion
        public int Y { get; init; }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString() => $"({X},{Y})";
        // Se genera sobrecarga de metodos porque se evita el unboxing y boxing 
        // y se separa la logica de comparacion en un metodo aparte especifico para Point
        public override bool Equals(object? obj)
        {
            return obj is Point point &&
                  Equals(obj);
        }

        public bool Equals(Point other) => X == other.X && Y == other.Y;

        // sobrearga de operadores
        public static Point operator + (Point left, Point right) => new Point(left.X + right.X, left.Y + right.Y);
        // si el operador == se sobrecarga,  se recomienda sobrecargar tambien !=
        public static bool operator == (Point left, Point right) => left.Equals(right);
        public static bool operator != (Point left, Point right) => !left.Equals(right);

        // conversiones implicitas en una estrcutra 

        public static implicit operator Point(Tuple<int,int> tuple) => new Point(tuple.Item1, tuple.Item2);

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }

        //public int CompareTo(Point obj)
        //{
        //    if (ob) 
        //}
    }
}
