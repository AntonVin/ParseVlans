using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseVlansTests
{
    public class FakeExtractorNumberVlans:IExtractorNumbersVlans
    {
        public List<string> GetNumbersVlans(string txtNumbersVlans)
        {
            return new List<string>(){"3","14", "20"};
        }
    }
}
