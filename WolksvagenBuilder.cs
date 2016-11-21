using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    /// <summary>
    /// WolksvagenBuilder class is concretebuilder.
    /// </summary>
    public class WolksvagenBuilder : CarBuilder
    {
        public WolksvagenBuilder()
        {
            car = new Car();
        }
        public override void SetAC()
        {
            car.HasAC = true;
        }

        public override void SetBrand()
        {
            car.Brand = "Golf Bluemotion Highline 1.6TDI";
        }

        public override void SetModel()
        {
            car.Model = "2015";
        }

        public override void SetSporMode()
        {
            car.HasSporMode = false;
        }
    }
}
