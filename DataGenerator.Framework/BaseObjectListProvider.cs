using System.Collections.Generic;

namespace DataGenerator.Framework
{
    public abstract class BaseObjectListProvider<T> : IObjectListProvider<T>
    {
        protected IList<T> _sourceList;

        // Implementers should setup the _sourceList in this method...
        protected abstract void SetupSourceList();

        public BaseObjectListProvider()
        {
            SetupSourceList();
        }

        public IList<T> Fetch()
        {
            return _sourceList;
        }
    }
}
