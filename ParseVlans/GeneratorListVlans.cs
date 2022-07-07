using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseVlans
{
    public static class GeneratorListVlans
    {
        public static List<Vlan> GetList(List<string> numbersVlans, Dictionary<string,string> dictVlans)
        {
            var listVlans = new List<Vlan>();
            foreach (string number in numbersVlans)
            {
                string nameVlan = null;
                if (dictVlans.ContainsKey(number))
                    nameVlan = dictVlans[number];
                Vlan currentVlan = new Vlan(number, nameVlan);
                listVlans.Add(currentVlan);
            }
            return listVlans;
        }
    }
}
