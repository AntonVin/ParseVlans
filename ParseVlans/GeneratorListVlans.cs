using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseVlans
{
    internal class GeneratorListVlans
    {
        List<Vlan> listVlans;
        public List<Vlan> ListVlans => listVlans;
        public GeneratorListVlans(ExtractorNumbersVlans extractorNumbersVlans, ExtractorDictionaryVlans extractorDictionaryVlans)
        {
            this.listVlans = new List<Vlan>();
            SetList(extractorNumbersVlans, extractorDictionaryVlans);
        }
        public void SetList(ExtractorNumbersVlans extractorNumbersVlans, ExtractorDictionaryVlans extractorDictionaryVlans)
        {
            foreach(string number in extractorNumbersVlans.NumbersVlans)
            {
                string nameVlan = null;
                if (extractorDictionaryVlans.DictionaryVlans.ContainsKey(number))
                    nameVlan = extractorDictionaryVlans.DictionaryVlans[number];
                Vlan currentVlan = new Vlan(number, nameVlan);
                this.listVlans.Add(currentVlan);
            }
        }
    }
}
