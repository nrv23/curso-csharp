using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTypes.clasess
{
    public class ObjectToTextConverter
    {
        public string Convert(object obj)
        {
            Type type = obj.GetType();
            var properties = type.GetProperties()
                .Where(p => p.Name != "EqualityContract") ;

            return String.Join(",",properties.Select(pr => $"{pr.Name} is {pr.GetValue(obj)}") );
        }

    }

    public record Pet(string Name, PetType PetType, float Weight);
    public record House(string Address, double Area,int Floors);
    public enum PetType
    {
        Dog,
        Cat,
        Fish,
        Bird,
        Hamster
    }
}
 

