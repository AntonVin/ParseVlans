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
        public void GetList_NullNameCase()
        {
            var inputNumbersVlans = new FakeExtractorNumberVlans(new List<string>(){"3","14", "20"});
            var inputDictionaryVlans = new FakeExtractorDictionaryVlans(
            new Dictionary<string, string>
            {
                ["3"] = "TSPD_SRV-TERM",
                ["15"] = "KSPD-ACTIVE",
                ["20"] = "564_ROJDESTVENO_ABN"
            });

            string expected = @"3 TSPD_SRV-TERM
14
20 564_ROJDESTVENO_ABN
";

            Assert.Equal(expected,new GeneratorListVlans(inputNumbersVlans,inputDictionaryVlans).GetText("fake","fake"));
        }
    }
}
