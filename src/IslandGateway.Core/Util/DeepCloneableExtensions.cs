﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Linq;

namespace IslandGateway.Core
{
    internal static class DeepCloneableExtensions
    {
        public static T DeepClone<T>(this T item)
            where T : IDeepCloneable<T>
        {
            return item.DeepClone();
        }

        public static IList<T> DeepClone<T>(this IList<T> list)
            where T : IDeepCloneable<T>
        {
            return list.Select(entry => entry.DeepClone()).ToList();
        }

        public static IDictionary<string, string> DeepClone(this IDictionary<string, string> dictionary, IEqualityComparer<string> comparer)
        {
            return dictionary.ToDictionary(entry => entry.Key, entry => entry.Value, comparer);
        }
    }
}