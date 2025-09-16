using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes.extensions
{
    public static class ListExtension // no genera una instancia de la clase por lo que no se usan genericos en la clase
    {

        public static void AddToFront<T>(this List<T> list, T item) // metodo generico de extension
        {
            list.Insert(0, item);
        }

        public static List<T2> ConvertTo<T1,T2>(this List<T1> elements)
        {
            var newList = new List<T2>();

            foreach (var element in elements)
            {
                T2 itemAfterCasting = (T2) Convert.ChangeType(element, typeof(T2)); 
                //Convert.ChangeType este metodo devuelve un valor de tipo object, por eso se hace el casting a T2
                newList.Add((T2)itemAfterCasting);
            }

            return newList;
        }
    }
}
