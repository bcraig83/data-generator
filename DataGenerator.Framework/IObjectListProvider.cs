using System.Collections.Generic;

namespace DataGenerator.Framework
{
    public interface IObjectListProvider<T>
    {
        IList<T> Fetch();
    }
}
