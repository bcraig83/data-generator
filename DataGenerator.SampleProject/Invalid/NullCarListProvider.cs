using DataGenerator.Framework;
using DataGenerator.SampleProject.Models;

namespace DataGenerator.SampleProject.Invalid
{
    public class NullCarListProvider : BaseObjectListProvider<Car>
    {
        protected override void SetupSourceList()
        {
            _sourceList = null;
        }
    }
}