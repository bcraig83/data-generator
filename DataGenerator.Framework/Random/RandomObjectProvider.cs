using System;
using System.Collections.Generic;
using System.Linq;

namespace DataGenerator.Framework.Random
{
    public class RandomObjectProvider<T> : IObjectProvider<T>
    {
        private readonly IList<T> _sourceList;

        public RandomObjectProvider(IObjectListProvider<T> itemsProvider)
        {
            _sourceList = itemsProvider.Fetch();
        }

        public T Fetch()
        {
            if (_sourceList == null || _sourceList.Count == 0)
            {
                throw new InvalidOperationException("No source list setup!");
            }

            return _sourceList
                .OrderBy(s => Guid.NewGuid())
                .First();
        }
    }
}
