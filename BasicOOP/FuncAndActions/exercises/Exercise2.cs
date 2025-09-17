using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncAndActions.exercises
{
    public class Exercise2
    {
        // funciones lambda
        public Func<string, int> GetLength = n => n.Length; // your code goes here;
        public Func<int> GetRandomNumberBetween1And10 = () => new Random().Next(1,11); // your code goes here;
    }
}
