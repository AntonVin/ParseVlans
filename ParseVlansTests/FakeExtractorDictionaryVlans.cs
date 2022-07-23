using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseVlansTests
{
    public class FakeExtractorDictionaryVlans:IExtractorDictionaryVlans
    {
        private Dictionary<string, string> dictionaryVlans;
        public FakeExtractorDictionaryVlans(Dictionary<string, string> dictionaryVlans)
        {
            this.dictionaryVlans = dictionaryVlans;
        }

        public Dictionary<string, string> GetDictionaryVlans(string txtVlans)
        {
            return this.dictionaryVlans;
        }
    }
}
