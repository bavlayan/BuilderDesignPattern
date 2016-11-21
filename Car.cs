using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    /// <summary>
    /// Car is product class.
    /// </summary>
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public bool HasAC { get; set; }
        public bool HasSporMode { get; set; }
    }
}
