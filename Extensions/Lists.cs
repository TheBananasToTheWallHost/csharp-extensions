using System;
using System.Collections.Generic;

namespace BananaTurtles.CSharp.Extensions
{
    public static partial class Extensions
    {
        public static void Swap<T>(this List<T> list, int index1, int index2){
            T temp = list[index1];
            list[index1] = list[index2];
            list[index2] = temp;
        }
    }
}