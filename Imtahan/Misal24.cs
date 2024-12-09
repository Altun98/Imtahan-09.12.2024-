using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imtahan
{
    public class Misal24
    {
        string name;
        int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string _name)
        {
            if (_name.Length > 2)
                this.name = _name;
        }
    }
}
