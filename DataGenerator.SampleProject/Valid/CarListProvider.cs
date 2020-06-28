using DataGenerator.Framework;
using DataGenerator.SampleProject.Models;
using System.Collections.Generic;

namespace DataGenerator.SampleProject.Valid
{
    public class CarListProvider : BaseObjectListProvider<Car>
    {
        protected override void SetupSourceList()
        {
            _sourceList = new List<Car>
            {
                new Car{ Make = "Toyota", Model = "Avensis", NumberPlate = "201-DL-123" },
                new Car{ Make = "Ford", Model = "Fiesta", NumberPlate = "98-D-5318" },
                new Car{ Make = "Fiat", Model = "Punto", NumberPlate = "11-G-9102" }
            };
        }
    }
}
