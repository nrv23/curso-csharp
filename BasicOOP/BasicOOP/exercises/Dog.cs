using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP.exercises
{
    public class Dog
    {
        private string _name;
        private string _breed;
        private int _weight;


        public Dog(string name, string breed, int weight)
        {
            _breed = breed;
            _name = name;
            _weight = weight;
        }

        public Dog(string name, int weight)
        {
            _name = name;
            _weight = weight;
            _breed = "mixed-breed";
        }

        public string Describe()
        {
            string sizeDescription = this.GetSizeDescriptionDog(this._weight);
            return $"This dog is named {this._name}, it's a {this._breed}, and it weighs {this._weight} kilograms, so it's a {sizeDescription} dog.";
        }

        private string GetSizeDescriptionDog(int weigth)
        {
            string sizeDescription;

            if (weigth < 5)
            {
                sizeDescription = "tiny";
            }
            else if (weigth > 5 && weigth < 30)
            {
                sizeDescription = "medium";
            }
            else
            {
                sizeDescription = "large";
            }
            return sizeDescription;
        }
    }
}
