using System;
using System.Collections.Generic;
using System.Text;

namespace Sort
{
    public interface ISort<T> where T : IComparable<T>
    {
        T[] Sort(T[] input, SortOrder sortOrder = SortOrder.Default);
    }
}
