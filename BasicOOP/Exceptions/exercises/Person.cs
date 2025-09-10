using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.exercises
{
    public class Person
    {

        public Person(string name, int yearOfBirth)
        {
            if(string.IsNullOrEmpty(name) ) throw new ArgumentException("Invalid name.");
            if(yearOfBirth < 1900 || yearOfBirth > DateTime.Now.Year) throw new ArgumentOutOfRangeException("Invalid year of birth.");
            
            Name = name;
            YearOfBirth = yearOfBirth;

        }

        public string Name { get; }
        public int YearOfBirth { get; }
    }
}
