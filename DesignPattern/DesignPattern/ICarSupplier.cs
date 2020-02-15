using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPattern
{
    public interface ICarSupplier
    {
        public string CarColor { get;}
        public void CarModel();
    }
}
