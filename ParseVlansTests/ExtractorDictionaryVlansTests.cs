using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseVlansTests
{
    public class ExtractorDictionaryVlansTests
    {
        [Fact]
        public void GetDictionaryVlans_Ordinary()
        {
            string input = @"Te1/1/8

                                                Gi2/0/7, Gi2/0/9, Gi2/0/12, Gi2/0/17, Gi2/0/18, Gi2/0/19, Gi2/0/22, Gi2/0/23, Gi2/0/24, Gi2/0/25, Gi2/0/26, Gi2/0/27, Gi2/0/28, Gi2/0/29

                                                Gi2/0/30, Gi2/0/31, Gi2/0/32, Gi2/0/33, Gi2/0/34, Gi2/0/35, Gi2/0/36, Gi2/0/38, Gi2/0/40, Gi2/0/41, Gi2/0/42, Gi2/0/43, Gi2/0/44, Te2/1/4

                                                Te2/1/5, Te2/1/6, Te2/1/7, Te2/1/8

7    TSPD_NET-MGMT                    active

11    TSPD_SRV-CONSOLE                 active";
            var expected = new Dictionary<string, string>()
            {
                ["7"] = "TSPD_NET-MGMT",
                ["11"] = "TSPD_SRV-CONSOLE"
            };

            Dictionary<string, string> actual = ExtractorDictionaryVlans.GetDictionaryVlans(input);

            Assert.Equal(expected, actual);
        }
    }
}
