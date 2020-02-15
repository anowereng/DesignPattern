using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern
{
    public class BMW : ICarSupplier
    {
        public string CarColor { get { return "Red"; } }

        public void CarModel()
        {
            Console.WriteLine("Honda Car Model is Honda 2016");
        }
    }
}
