using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    /// <summary>
    /// CarBuilder is builder class.
    /// </summary>
    public abstract class CarBuilder
    {
        protected Car car;
        public Car Car
        {
            get
            {
                return car;
            }
        }

        public abstract void SetBrand();
        public abstract void SetModel();
        public abstract void SetAC();
        public abstract void SetSporMode();
    }
}
