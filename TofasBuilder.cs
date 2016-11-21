using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    /// <summary>
    /// TofasBuilder class is concretebuilder.
    /// </summary>
    public class TofasBuilder : CarBuilder
    {
        public TofasBuilder()
        {
            car = new Car();
        }

        public override void SetAC()
        {
            car.HasAC = false;
        }

        public override void SetBrand()
        {
            car.Brand = "Doğan SLX 1.6ie";
        }

        public override void SetModel()
        {
            car.Model = "1998";
        }

        public override void SetSporMode()
        {
            car.HasSporMode = false;
        }
    }
}
