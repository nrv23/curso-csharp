using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncAndActions.exercises
{
    public class Exercise
    {
        public void TestMethod()
        {
            /*your code goes here*/
            Func<int,bool,double> someMethod1 = Method1;
            /*your code goes here*/
            Func< DateTime>  someMethod2 = Method2; // Func se usa para metodos que devuelven algo (no void)
            /*your code goes here*/
            Action<string,string> someMethod3 = Method3; // Action se usa para metodos que no devuelven nada (void)
        }

        public double Method1(int a, bool b) => 0;
        public DateTime Method2() => default(DateTime);
        public void Method3(string a, string b) { }
    }
}
