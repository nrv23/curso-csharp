using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.exercises
{
    public class PairOfArrays<TLeft, TRight>
    {
        private readonly TLeft[] _left;
        private readonly TRight[] _right;

        public ValueTuple<TLeft, TRight> this[int leftIndex, int rightIndex]
        {
            get => new ValueTuple<TLeft, TRight>(_left[leftIndex], _right[rightIndex]);
            set
            {
                _left[leftIndex] = value.Item1;
                _right[rightIndex] = value.Item2;
            }
        }

        public PairOfArrays(
            TLeft[] left, TRight[] right)
        {
            _left = left;
            _right = right;
        }
    }
}
