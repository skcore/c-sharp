using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_method
{
    internal class MaruthiFactory : CarFactory
    {
        public override ICar MakeCar()
        {
            ICar car = new Maruthi();
            return car;
        }
    }
}
