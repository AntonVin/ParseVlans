using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseVlans
{
    public class Vlan
    {
        public string Number { get; }
        public string Name { get; }
        public Vlan(string Number,string Name)
        {
            this.Number = Number;
            this.Name = Name;
        }
    }
}
