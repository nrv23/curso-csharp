using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedOOP.Examples
{
    public interface IFlyable
    {
        void Fly();
    }

    public interface IFuelable
    {
        void Fuel();
    }
    public class Bird: IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("The bird is flying.");
        }
    }

    public class Airplane: IFlyable, IFuelable
    {
        public void Fly()
        {
            Console.WriteLine("The airplane is flying.");
        }

        public void Fuel()
        {
            Console.WriteLine("The airplane is fueling.");
        }
    }


    public class Kite : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("The kite is flying.");
        }
    }
}
