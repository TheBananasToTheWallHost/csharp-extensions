using System;

namespace CSharpExtensions
{
    public static partial class Extensions
    {
        public static void Swap<T>(this Span<T> span, int index1, int index2){
            T temp = span[index1];
            span[index1] = span[index2];
            span[index2] = temp;
        }
    }
}