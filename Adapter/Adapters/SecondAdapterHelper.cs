using System;
using System.Collections.Generic;
using System.Linq;
using Adapter.Models.Interfaces;

namespace Adapter.Adapters
{
    internal class SecondAdapterHelper<T> where T : IDbEntity
    {
        internal static T Get(int id, HashSet<T> source)
        {
            var user = source.FirstOrDefault(u => u.Id == id);
            if (user is null)
                throw new Exception();
            return user;
        }

        internal static void Add(T item, HashSet<T> source)
        {
            if (!source.Contains(item))
                source.Add(item);
            else
                throw new Exception();
        }

        internal static void Remove(int id, HashSet<T> source)
        {
            var item = Get(id, source);
            source.Remove(item);
        }
    }
}