using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.classes
{

    public class Node<T>
    {
        public T? Value { get; }

        public Node(T? value)
        {
            Value = value;
        }

        public Node<T>? Next { get; set; }

        public override string ToString() => $"Value: {Value}" +
            $"Next: {(Next is null ? "null" : Next.Value)}";

    }
}
