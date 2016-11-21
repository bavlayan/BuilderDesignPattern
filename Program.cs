using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ProduceCar produceCar = new ProduceCar();

            CarBuilder mercedesCarBuilder = new MercedesBuilder();
            CarBuilder tofasCarBuilder = new TofasBuilder();
            CarBuilder wolksvagenCarBuilder = new WolksvagenBuilder();
            
            produceCar.CreateCar(mercedesCarBuilder);
            DisplayCarProperties(mercedesCarBuilder.Car);

            produceCar.CreateCar(tofasCarBuilder);
            DisplayCarProperties(tofasCarBuilder.Car);

            produceCar.CreateCar(wolksvagenCarBuilder);
            DisplayCarProperties(wolksvagenCarBuilder.Car);

            Console.ReadKey();
        }

        public static void DisplayCarProperties(Car car)
        {
            Console.WriteLine("Marka:{0} | Model:{1} | Klima:{2} | Spor Mod:{3}",
                             car.Brand, car.Model, car.HasAC ? "Var": "Yok" , car.HasSporMode ? "Var": "Yok");
        }
    }
}
