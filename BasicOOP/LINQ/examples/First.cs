using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LINQ.examples
{
    public class First
    {

        public T GetFirstElement<T>(IEnumerable<T> elements, Func<T,bool>? predicate)
        {
            if (elements is null) throw new ArgumentNullException(nameof(elements));

            if (typeof(T).IsValueType) // esto indica que si el valor es una referencia de clase devuelve false
                // si es struct, enum o cualquier valor parecido devuelve true
            {
                // comportamiento para tipos valor (struct)
                return predicate is not null ? elements.First(predicate) : elements.First();
            }
            else
            {
                // comportamiento para tipos referencia (class)
                return predicate is not null ? elements.First(predicate) : elements.First();
            }
        }

        public T GetFirstElementDefault<T>(IEnumerable<T> elements, Func<T, bool>? predicate)
        {
            if (elements is null) throw new ArgumentNullException(nameof(elements));

            if (typeof(T).IsValueType) // esto indica que si el valor es una referencia de clase devuelve false
                                       // si es struct, enum o cualquier valor parecido devuelve true
            {
                // comportamiento para tipos valor (struct)
                return predicate is not null ? elements.FirstOrDefault(predicate) : elements.FirstOrDefault();
            }
            else
            {
                // comportamiento para tipos referencia (class)
                return predicate is not null ? elements.FirstOrDefault(predicate) : elements.FirstOrDefault();
            }
        }

        public void Test<T>()
        {
            Console.WriteLine($"{typeof(T).Name} is value type? {typeof(T).IsValueType}");
        }

        //Test<int>();     // output: Int32 is value type? True
        //Test<string>();  // output: String is value type? False
        //Test<DateTime>(); // output: DateTime is value type? True
        //Test<object>();  // output: Object is value type? False

    }
}
