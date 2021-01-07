using System;

namespace BananaTurtles.CSharp.Extensions
{
    public static partial class Extensions
    {
        public static void Swap<T>(this T[] arr, int index1, int index2){
            T temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;
        }
    }
}