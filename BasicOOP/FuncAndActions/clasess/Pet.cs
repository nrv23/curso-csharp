using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FuncAndActions.clasess
{
    public enum PetType { Dog, Cat, Fish }
    public class Pet
    {
        public PetType PetType { get; init; }
        public double Weight { get; init; }

        public Pet(PetType petType, double weight)
        {
            PetType = petType;
            Weight = weight;
        }

        public static Dictionary<PetType, double> FindMaxWeights(IEnumerable<Pet> pers)
        {
            var weightPerPetType = new Dictionary<PetType, List<Pet>>();

            foreach (var pet in pers)
            {
                if (!weightPerPetType.ContainsKey(pet.PetType))
                {
                    weightPerPetType[pet.PetType] = new List<Pet>(); // lista vacia 
                }
                weightPerPetType[pet.PetType].Add(pet);
            }

            var averageWeightPerPetType = new Dictionary<PetType, double>();

            foreach (var petType in weightPerPetType) // este diccionario tiene como key el nombre del petType y como value la lista de pets de ese petType
            {
                double maxWeight = 0;
                foreach (var dataPet in petType.Value) // petType.Value es la lista de pets de ese petType
                {
                    if (dataPet.Weight > maxWeight)
                    {
                        maxWeight = dataPet.Weight;
                    }
                }
                // asignar de dos formas
                //averageWeightPerPetType.Add(petType.Key, maxWeight); // petType.Key es el nombre del petType
                averageWeightPerPetType[petType.Key] = maxWeight; // el key trae el nombre del petType
            }
            return averageWeightPerPetType;
        }
        public override string ToString() => $"{PetType}, {Weight} kilos";
    }
}
