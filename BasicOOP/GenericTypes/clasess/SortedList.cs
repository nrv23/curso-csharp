using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes.clasess
{
    public class SortedList<T> where T : IComparable<T> //your code goes here
    {
        public IEnumerable<T> Items { get; }

        public SortedList(IEnumerable<T> items)
        {
            var asList = items.ToList();
            asList.Sort();
            Items = asList;
        }
    }

    public class FullName : IComparable<FullName> // your code goes here
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }

        public int CompareTo(FullName other)
        {
            if (other is null) return 1; // convención: este objeto > null
            int lastNameComparison = LastName.CompareTo(other.LastName);
            if (lastNameComparison != 0) return lastNameComparison;
            return FirstName.CompareTo(other.FirstName);
        }

        public override string ToString() => $"{FirstName} {LastName}";

        //your code hoes here
    }
}
