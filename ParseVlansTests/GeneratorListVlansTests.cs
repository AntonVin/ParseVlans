using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseVlansTests
{
    public class GeneratorListVlansTests
    {
        [Fact]
        public void GetList_SimpleCase()
        {
            var inputNumbersVlans = new FakeExtractorNumberVlans();
            var inputDictionaryVlans = new FakeExtractorDictionaryVlans();

            var expected = @"3 TSPD_SRV-TERM
14
20 564_ROJDESTVENO_ABN
";

            Assert.Equal(expected,new GeneratorListVlans(inputNumbersVlans,inputDictionaryVlans).GetText("fake","fake"));
        }
    }
}
