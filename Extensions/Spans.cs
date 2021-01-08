using System;

namespace BananaTurtles.CSharp.Extensions
{
    public static partial class Extensions
    {
        public static void Swap<T>(this Span<T> span, int index1, int index2){
            T temp = span[index1];
            span[index1] = span[index2];
            span[index2] = temp;
        }       

        public static void BlockSwap<T>(this Span<T> span, (int start, int end) range1, (int start, int end) range2){
            Span<T> group1 = span.Slice(range1.start, range1.end - range1.start);
            Span<T> group2 = span.Slice(range2.start, range2.end - range2.start);

            int minGroup = Math.Min(group1.Length, group2.Length);
            for(int i = 0; i < minGroup; i++){
                group1.CrossSwap(i, group2, i);
            }
        }
        public static void BlockSwap<T>(this Span<T> span, Range range1, Range range2){
            Span<T> group1 = span[range1];
            Span<T> group2 = span[range2];

            int minGroup = Math.Min(group1.Length, group2.Length);
            for(int i = 0; i < minGroup; i++){
                group1.CrossSwap(i, group2, i);
            }
        }

        public static void CrossSwap<T>(this Span<T> span, int selfIndex, Span<T> otherSpan, int otherIndex){
            T temp = span[selfIndex];
            span[selfIndex] = otherSpan[otherIndex];
            otherSpan[otherIndex] = temp;
        }

        public static bool IsSorted<T>(this Span<T> span) where T : IComparable<T> {
            for (int i = 0; i < span.Length - 1; i++) {
                if (span[i].CompareTo(span[i + 1]) > 0) {
                    return false;
                }
            }
            return true;
        }
    }
}