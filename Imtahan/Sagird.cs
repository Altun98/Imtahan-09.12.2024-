using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imtahan
{
    public class Sagird
    {
        int ID { set; get; }
        string Name { set; get; }
        public Sagird()
        {

        }
        public Sagird(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }
    }
    public class SagirdXususi : Sagird
    {
        public int SumQiymet { get; set; }

        public SagirdXususi() : base()
        {

        }
        public SagirdXususi(int id, string name, int sumQiymet) : base(id, name)
        {
            this.SumQiymet = sumQiymet;
        }
    }
}
