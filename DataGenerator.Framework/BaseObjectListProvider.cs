using System.Collections.Generic;

namespace DataGenerator.Framework
{
    public abstract class BaseObjectListProvider<T> : IObjectListProvider<T>
    {
        protected IList<T> _sourceList;
        private bool isInitialized = false;

        // Implementers should setup the _sourceList in this method...
        protected abstract void SetupSourceList();

        public IList<T> Fetch()
        {
            if (!isInitialized)
            {
                SetupSourceList();
                isInitialized = true;
            }

            return _sourceList;
        }
    }
}
