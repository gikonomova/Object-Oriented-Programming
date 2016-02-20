using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_01.CustomLINQExtensionMethods
{
    public static class Extensions
    {
        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            List<T> result = new List<T>();

            foreach (var item in collection)
            {
                if (!predicate(item))
                {
                    result.Add(item);
                }
            }

            return result;
        }


        public static TSelector Max<TSource, TSelector>(this IEnumerable<TSource> collection, Func<TSource, TSelector> criteria)
            where TSelector : IComparable<TSelector>
        {
            TSelector max = criteria(collection.FirstOrDefault());

            foreach (var item in collection)
            {
                if (max.CompareTo(criteria(item)) < 0)
                {
                    max = criteria(item);
                }
            }

            return max;
        }
    }
}
