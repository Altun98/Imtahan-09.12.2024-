using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Imtahan
{
    public class Student
    {

        public required int ID { get; set; }
        public string Name { get; init; }
        public string Gebder { get; set; }
        public int Age { get; set; }
    }
}
