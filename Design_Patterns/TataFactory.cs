using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_method
{
    internal class TataFactory : CarFactory
    {
        public override ICar MakeCar()
        {
            ICar car = new Tata();
            return car;
        }
    }
}
