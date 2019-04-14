using System.Collections.Generic;
using System.Linq;

namespace Common.Extensions {

    /// <summary>
    /// Contains extension methods for IEnumerable{T}>
    /// </summary>
    public static class IEnumerableExtensions {

        /// <summary>
        /// Converts the source to a <see cref="List{T}"/> if the source not a List, Array, or HashSet.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">The source.</param>
        /// <returns></returns>
        public static IEnumerable<T> ToNonYielding<T>(this IEnumerable<T> source) {
            var isNonYielding
                = source is List<T>
                || source is T[]
                || source is HashSet<T>;

            if (isNonYielding) {
                return source;
            } else {
                return source.ToList();
            }
        }

    }
}