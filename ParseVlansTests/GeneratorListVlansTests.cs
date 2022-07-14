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
            var inputNumbers = new List<string>() { "3"/*,"14", "20"*/ };
            var inputDict = new Dictionary<string, string>
            {
                ["3"] = "TSPD_SRV-TERM",
                ["14"] = "KSPD-ACTIVE",
                ["20"] = "564_ROJDESTVENO_ABN"
            };

            var expected = new List<Vlan>()
            {
                new Vlan("3","TSPD_SRV-TERM"),
                //new Vlan("14","KSPD-ACTIVE"),
                //new Vlan("20","564_ROJDESTVENO_ABN")
            };
            List<Vlan> actual = GeneratorListVlans.GetList(inputNumbers, inputDict);

            Assert.Equal(expected,actual);//не работает, а почему?:(
        }
    }
}
