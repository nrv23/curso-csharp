using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypes.clasess
{
    public class Person : IComparable<Person>
    {
        public string Name { get; init; } = string.Empty;
        public int YearOfBirth { get; init; }

        public int CompareTo(Person? other)
        {
            if (other is null) return 1; // convención: este objeto > null

            // Mantengo la semántica original:
            // si this.YearOfBirth < other.YearOfBirth => 1
            // si this.YearOfBirth > other.YearOfBirth => -1
            // si iguales => 0
            if (this.YearOfBirth < other.YearOfBirth) return 1;
            if (this.YearOfBirth > other.YearOfBirth) return -1;
            return 0;
        }

        public override string ToString()
        {
            return $"{Name} ({YearOfBirth})";
        }
    }

    public class Employee : Person
    {
        public void GoToWork()
        {
            Console.WriteLine($"{Name} is going to work");
        }
    }
}

