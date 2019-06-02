using System.Collections;
using System.Collections.Generic;

namespace Force.Pagination
{
    public class PagedEnumerable
    {
        public IEnumerable Items { get; protected set; }

        public long Total { get; protected set;}

        public PagedEnumerable(IEnumerable items, long total)
        {
            Total = total;
            Items = items;
        }

    }
    public class PagedEnumerable<T>: PagedEnumerable, IEnumerable<T>
    {
        public new IEnumerable<T> Items { get; }

        public PagedEnumerable(IEnumerable<T> items, long total)
            // ReSharper disable once PossibleMultipleEnumeration
            : base(items, total)
        {
            // ReSharper disable once PossibleMultipleEnumeration
            Items = items;
        }

        public PagedEnumerable(params T[] items)
            : base(items, items.Length)        
        {
            Items = items;
        }

        public IEnumerator<T> GetEnumerator()
            => Items.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => Items.GetEnumerator();
    }
}