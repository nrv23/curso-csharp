using LINQ.clasess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.examples
{
    public class OrderBy
    {

        public IOrderedEnumerable<Pet> Order(IEnumerable<Pet> pets)
        {
            var result = pets.OrderBy(p => p.Name);
            return result;
        }

        public static void ToString(IEnumerable<Pet> pets)
        {
            Console.WriteLine();
            foreach (var pet in pets) { 
                Console.WriteLine($"{pet.Name} {pet.PetType} {pet.Id}");
            }
        }

        public IOrderedEnumerable<Pet> OrderDescendingOrAscending(IEnumerable<Pet> pets, int direction)
        {

            if(direction == 0)
            {
                return pets.OrderByDescending(p => p.Name);
            } else
            {
                return pets.OrderBy(p => p.Name);
            }
        }
    }
}
