using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP.exercises
{
    public class DailyAccountState
    {
        public int InitialState { get; }
        public int SumOfOperations { get; }

        public DailyAccountState(
            int initialState,
            int sumOfOperations)
        {
            InitialState = initialState;
            SumOfOperations = sumOfOperations;
        }
        // esto es lo que se conoce como computed properties
        // propiedades que retornan una expresion que puede ser 
        // una operacion simple o muy compleja o la creacion de un string con variables dinamicas
        public int EndOfDayState => InitialState + SumOfOperations;

        public string Report =>
            $"Day: {DateTime.Now.Day}, month: {DateTime.Now.Month}, year: {DateTime.Now.Year}, initial state: {InitialState}, end of day state: {EndOfDayState}";
    }
}
