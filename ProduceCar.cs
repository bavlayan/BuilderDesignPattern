using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    /// <summary>
    /// ProduceCar class is director
    /// </summary>
    public class ProduceCar
    {
        public void CreateCar(CarBuilder carBuilder)
        {
            carBuilder.SetAC();
            carBuilder.SetBrand();
            carBuilder.SetModel();
            carBuilder.SetSporMode();
        }
    }
}
