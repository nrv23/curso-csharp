using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedOOP
{
    public abstract class Cheese: Ingredients
    {
        public Cheese(int _PrinceIfExtraTopping) :base(_PrinceIfExtraTopping)
        {
            
        }

        // evita que se implemente una clase abstracta si la clase hija es abstracta tambien
    }
}
  