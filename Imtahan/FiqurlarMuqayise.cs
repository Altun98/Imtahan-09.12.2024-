using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Imtahan
{
    public class FiqurlarMuqayise
    {
        public int a;
        public int b;
        public static FiqurlarMuqayise operator +(FiqurlarMuqayise f1, FiqurlarMuqayise f2)
        {
            FiqurlarMuqayise fq = new FiqurlarMuqayise();
            fq.a = f1.a + f2.a;
            fq.b = f1.b + f2.b;
            return fq;
        }
        public static FiqurlarMuqayise operator -(FiqurlarMuqayise f1, FiqurlarMuqayise f2)
        {
            FiqurlarMuqayise fq = new FiqurlarMuqayise();
            fq.a = f1.a - f2.a;
            fq.b = f1.b - f2.b;
            return fq;
        }
        public static bool operator ==(FiqurlarMuqayise f1, FiqurlarMuqayise f2)
        {
            if (f1.a != f2.a && f1.b != f2.b)
            {
                return false;
            }
            return true;
        }
        public static bool operator !=(FiqurlarMuqayise f1, FiqurlarMuqayise f2)
        {
            if (f1.a == f2.a && f1.b == f2.b)
            {
                return false;
            }
            return true;
        }

    }
}



