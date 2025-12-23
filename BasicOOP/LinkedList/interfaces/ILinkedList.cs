using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.interfaces
{
    public interface ILinkedList<T>: ICollection<T>
    {
        void AddToFront(T item);
        void AddToEnd(T item);
    }
}
