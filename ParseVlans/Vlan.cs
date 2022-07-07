using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseVlans
{
    public class Vlan
    {
        public string Name { get; }
        public string Number { get; }
        public Vlan(string Number,string Name)
        {
            this.Number = Number;
            this.Name = Name;
        }
    }
}
