using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseVlansTests
{
    public class FakeExtractorDictionaryVlans:IExtractorDictionaryVlans
    {
        public Dictionary<string, string> GetDictionaryVlans(string txtVlans)
        {
            return new Dictionary<string, string>
            {
                ["3"] = "TSPD_SRV-TERM",
                ["15"] = "KSPD-ACTIVE",
                ["20"] = "564_ROJDESTVENO_ABN"
            };
        }
    }
}
