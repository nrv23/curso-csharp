using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTypes.clasess
{
    public class SomeClass
    {
        [MustBeLargerThan(100)]
        public int Value { get; }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class MustBeLargerThanAttribute : Attribute
    { // todos los atributos deben derivar de la clase Attribute
        // y el nombre de la clase hija debe termina ren Attribute

        public int Min { get; }


        public MustBeLargerThanAttribute(int min)
        {
            Min = min;
        }

        class Validator
        {
            public bool validate(object obj)
            {
                var type = obj.GetType();
                var properties = type.GetProperties()
                    .Where(p => Attribute.IsDefined(p, typeof(MustBeLargerThanAttribute)));
                foreach (var property in properties)
                {
                    object? propertyValue = property.GetValue(obj);
                    if (propertyValue is not int) // indica si el tipo de la var es string
                    {
                        throw new InvalidOperationException("Only ints properties are supported");
                    }

                    var value = (string)propertyValue;
                    var attribute = (MustBeLargerThanAttribute)property.GetCustomAttributes(typeof(MustBeLargerThanAttribute), true).First();

                    if (value.Length < attribute.Min)
                    {
                        return false;
                    }
                }

                return true;
            }
        }
    }
}
