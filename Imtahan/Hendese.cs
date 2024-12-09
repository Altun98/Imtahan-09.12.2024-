using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imtahan
{
    public abstract class Hendese
    {
        public abstract double Sahe();
        public abstract double Peremetir();

        public virtual void Print()
        {
            Console.WriteLine("Men Hendese clasiyam");
        }
    }
    public class Ucnucaq : Hendese
    {
        public override double Peremetir()
        {
            throw new NotImplementedException();
        }

        public override double Sahe()
        {
            throw new NotImplementedException();
        }
    }
    public class Duzbucaqli() : Hendese
    {
        public override double Peremetir()
        {
            throw new NotImplementedException();
        }

        public override double Sahe()
        {
            throw new NotImplementedException();
        }
        public override void Print()
        {
            Console.WriteLine("Duzbucaqli klasiyam");
        }
    }
}
