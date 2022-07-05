using ParseVlans;
namespace ParseVlansTests
{
    public class ExtractorNumbersVlansTest
    {
        [Fact]
        public void GetVlans_return200to300()
        {
            string input = "vlan add 200-210";
            List<string> output = new List<string>() { "200", "201", "202", "203", "204", "205", "206", "207", "208", "209","210" };
            ExtractorNumbersVlans extractorNumbersVlans = new ExtractorNumbersVlans(input);
            Assert.Equal(extractorNumbersVlans.NumbersVlans, output);
        }
        [Fact]
        public void GetVlans_returnCommaVlans()
        {
            string input = "vlan 205,209,100,300";
            List<string> output = new List<string>() { "205", "209", "100", "300" };
            ExtractorNumbersVlans extractorNumbersVlans = new ExtractorNumbersVlans(input);
            Assert.Equal(extractorNumbersVlans.NumbersVlans, output);
        }
    }
}