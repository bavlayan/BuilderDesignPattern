using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    /// <summary>
    /// MercedesBuilder class is concretebuilder.
    /// </summary>
    public class MercedesBuilder : CarBuilder
    {
        public MercedesBuilder()
        {
            car = new Car();
        }

        public override void SetAC()
        {
            car.HasAC = true;
        }

        public override void SetBrand()
        {
            car.Brand = "CLA 180 AMG - Kompressor";
        }

        public override void SetModel()
        {
            car.Model = "2015";
        }

        public override void SetSporMode()
        {
            car.HasSporMode = true;
        }
    }
}
