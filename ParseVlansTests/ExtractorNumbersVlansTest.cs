using ParseVlans;
namespace ParseVlansTests
{
    public class ExtractorNumbersVlansTest
    {
        [Fact]
        public void GetVlans_return200to300()
        {
            string input = "vlan add 200-210";
            var exeptedList = new List<string>() { "200", "201", "202", "203", "204", "205", "206", "207", "208", "209","210" };

            List<string> resultList = ExtractorNumbersVlans.GetNumbersVlans(input);

            Assert.Equal(resultList, exeptedList);
        }
        [Fact]
        public void GetVlans_returnCommaVlans()
        {
            string input = "vlan 205,209,100,300";
            var exeptedList = new List<string>() { "205", "209", "100", "300" };

            List<string> resultList = ExtractorNumbersVlans.GetNumbersVlans(input);

            Assert.Equal(resultList, exeptedList);
        }
    }
}