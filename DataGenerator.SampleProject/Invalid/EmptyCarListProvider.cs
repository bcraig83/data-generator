using DataGenerator.Framework;
using DataGenerator.SampleProject.Models;
using System.Collections.Generic;

namespace DataGenerator.SampleProject.Invalid
{
    public class EmptyCarListProvider : BaseObjectListProvider<Car>
    {
        protected override void SetupSourceList()
        {
            _sourceList = new List<Car>();
        }
    }
}