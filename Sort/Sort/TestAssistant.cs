using System;
using System.Collections.Generic;
using System.Text;

namespace Sort
{
    public class TestAssistant<T> where T : IComparable<T>
    {

        public Dictionary<SortType, ISort<T>> GetSortlibrary()
        {
            return new SortFactory<T>().SortLibrary;
        }
    }
}
