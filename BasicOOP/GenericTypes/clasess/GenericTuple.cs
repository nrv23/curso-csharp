using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes.clasess
{
    // cada tipo de generico T1, T2, T3 puede ser diferente
    public class GenericTuple<T1,T2,T3>
    {
        public T1 Item1 { get; }
        public T2 Item2 { get; }
        public T3 Item3 { get; }
        public GenericTuple(T1 item1, T2 item2, T3 item3)
        {
            Item1 = item1;
            Item2 = item2;
            Item3 = item3;
        }
    }
    // se podria llamar sobre cargando la clase GenericTuple pero con diferente numero de tipos genericos
    public class GenericTuple<T1, T2>
    {
        public T1 Item1 { get; }
        public T2 Item2 { get; }
        public GenericTuple(T1 item1, T2 item2)
        {
            Item1 = item1;
            Item2 = item2;
        }
    }
}
