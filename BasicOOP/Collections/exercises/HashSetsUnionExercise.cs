using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.exercises
{
    public static class HashSetsUnionExercise
    {
        public static HashSet<T> CreateUnion<T>(HashSet<T> set1, HashSet<T> set2)
        {
            var union = new HashSet<T>(set1); 
            union.UnionWith(set2);
            return union;
        }
    }
}
