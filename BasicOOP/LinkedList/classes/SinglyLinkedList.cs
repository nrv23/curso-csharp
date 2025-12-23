using LinkedList.interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.classes
{
    public class SinglyLinkedList<T> : ILinkedList<T?>
    {
        private Node<T>? _head; // nulo al principio 
        private int _count; // contador de elementos, por defecto 0
        public int Count => _count;

        public bool IsReadOnly => false;

        public void Add(T? item)
        {
            AddToEnd(item);
        }

        public void AddToEnd(T? item)
        {   
            var node = new Node<T>(item);
            if (_head == null)
            {
                _head = node;
            }
            else
            {
                var tail = GetNodes().Last();
                tail.Next = node;
            }

            _count++;
        }

        public void AddToFront(T? item)
        {
            var newHead = new Node<T>(item)
            {
                Next = _head
            };

            _head = newHead;
            _count++;
        }

        public void Clear()
        {
            Node<T>? current = _head;
            while (current != null)
            {
                Node<T>? temporary = current;
                current = current.Next;
                temporary.Next = null;
            }
            _head = null;
            _count = 0;
        }

        public bool Contains(T? item)
        {
            return GetNodes().Any(node =>
                (node.Value is null && item is null) ||
                (node.Value is not null && node.Value.Equals(item))
            );
        }

        public void CopyTo(T?[] array, int arrayIndex)
        {
                
            if(array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if(arrayIndex < 0 || arrayIndex > array.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(arrayIndex));
            }

            if(array.Length < _count + arrayIndex)
            {
                throw new ArgumentException("The number of elements in the source" +
                    " is greater than the available space from arrayIndex to the end of the destination array.");
            }

            foreach (var node in GetNodes())
            {
                array[arrayIndex] = node.Value;
                ++arrayIndex;
            }
        }


        public bool Remove(T? item)
        {
           foreach(var node in GetNodes())
            {
                Node<T>? previous = null;
                if (
                    (node.Value is null && item is null) ||
                    (node.Value is not null && node.Value.Equals(item))

                   )
                {
                    if(previous is null)
                    {
                        _head = node.Next;
                    } else
                    {
                        previous.Next = node.Next;
                    }

                    --_count;
                    return true;

                }

                previous = node;
            }

           return false;
        }

        public IEnumerator<T?> GetEnumerator()
        {
            foreach (var node in GetNodes())
            {
                yield return node.Value;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private IEnumerable<Node<T>> GetNodes()
        {
                
            Node<T>? current = _head;
            while (current is not null)
            {
                yield return current;
                current = current.Next;
            }
        }
    }
}
