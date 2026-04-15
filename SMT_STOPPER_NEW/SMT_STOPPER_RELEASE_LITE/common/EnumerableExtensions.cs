using System;
using System.Collections.Generic;

namespace SMT_STOPPER_RELEASE.common
{
    public static class EnumerableExtensions
    {
        public static void Do<T>(this IEnumerable<T> sequence, Action<T> action)
        {
            foreach (T obj in sequence)
                action(obj);
        }
    }
}
