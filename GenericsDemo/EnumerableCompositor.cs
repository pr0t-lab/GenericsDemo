using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace GenericsDemo
{
    class EnumerableCompositor<T> : IEnumerable<T>
    {
        private List<IEnumerable<T>> _collections;

        // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/object-and-collection-initializers
        public EnumerableCompositor()
        {
            _collections = new List<IEnumerable<T>>();
        }

        public EnumerableCompositor(IEnumerable<IEnumerable<T>> collections)
        {
            _collections = collections.ToList();
        }

        // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/object-and-collection-initializers
        public void Add(IEnumerable<T> collection)
        {
            _collections.Add(collection);
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach(var collection in _collections)
            {
                foreach(var item in collection)
                {
                    yield return item;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    } // end of EnumerableCompositor class
}
