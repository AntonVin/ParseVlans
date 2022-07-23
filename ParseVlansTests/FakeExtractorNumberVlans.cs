using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseVlansTests
{
    public class FakeExtractorNumberVlans:IExtractorNumbersVlans
    {
        private List<string> listNumbersVlans;
        public FakeExtractorNumberVlans(List<string> listNumbersVlans)
        {
            this.listNumbersVlans = listNumbersVlans;
        }

        public List<string> GetNumbersVlans(string txtNumberVlans)
        {
            return this.listNumbersVlans;
        }
    }
}
