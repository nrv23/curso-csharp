using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTypes.clasess
{
    public class Person
    {
        public int Id { get; init; }
        [StringLengthValidate(2,10)]
        public string Name { get; }

        [StringLengthValidate(2, 10)]
        public string Name2 { get; }
        public int YearOfBirth { get; }


        public override bool Equals(object? obj)
        {
            return obj is Person person && // patron matching
                                        // pregunta primero si obj es de tipo Person y si es asi lo asigna a la variable person
                   Id == person.Id;
        }

        public override int GetHashCode()
        {
            return Id;
        }
        public Person(string name, string name2, int yearOfBirth, int id)
        {
            Name = name;
            Name2 = name2;
            YearOfBirth = yearOfBirth;
            Id = id;
        }

        public Person(string name) => Name = name;
    }

    public class Dog
    {
        [StringLengthValidate(2, 10)]
        public string Name { get; }

        public Dog(string name) => Name = name;
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class StringLengthValidateAttribute: Attribute    { // todos los atributos deben derivar de la clase Attribute
        // y el nombre de la clase hija debe termina ren Attribute

        public int Min { get; }
        public int Max { get; }


        public StringLengthValidateAttribute(int min, int max)
        {
            Min = min;
            Max = max;
        }
    }

    class Validator
    {
        public bool validate(object obj)
        {
            var type = obj.GetType();
            var properties = type.GetProperties()
                .Where(p => Attribute.IsDefined(p,typeof(StringLengthValidateAttribute)));
            foreach (var property in properties)
            {
                object? propertyValue = property.GetValue(obj);
                if(propertyValue is not string) // indica si el tipo de la var es string
                {
                    throw new InvalidOperationException("Only string properties are supported");
                }

                var value = (string)propertyValue;
                var attribute =  (StringLengthValidateAttribute) property.GetCustomAttributes( typeof(StringLengthValidateAttribute), true).First();

                if(value.Length < attribute.Min || value.Length > attribute.Max)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
