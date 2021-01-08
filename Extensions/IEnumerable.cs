using System;
using System.Collections.Generic;

namespace BananaTurtles.CSharp.Extensions
{
    public static partial class Extensions
    {
        public static bool IsSorted<T>(this IEnumerable<T> enumerable) where T : IComparable<T>{
            IEnumerator<T> enumerator = enumerable.GetEnumerator();

            if(!enumerator.MoveNext()){
                return true;
            }

            T prev = enumerator.Current;

            while(enumerator.MoveNext()){
                if(prev.CompareTo(enumerator.Current) > 0){
                    return false;
                }
            }

            return true;
        }
    }
}