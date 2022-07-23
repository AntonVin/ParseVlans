using System.Linq;
namespace ParseVlansTests
{
    public class ExtractorNumbersVlansTest
    {
        [Theory]
        [InlineData("vlan 200-210")]
        [InlineData("vlan add 200-210")]
        public void GetNumbersVlans_Dash(string input)
        {
            var exeptedList = new List<string>(Enumerable.Range(200,11).ToList().ConvertAll(x=>x.ToString()));

            List<string> actualtList = new ExtractorNumbersVlans().GetNumbersVlans(input);

            Assert.Equal(actualtList, exeptedList);
            //Assert.All(actualtList, x => x.StartsWith("ooo")); //������ ��� ����������� ��� ��?������ ������ ��������,
            //���������� �� ��� ������ � ����� � "���". ��� � ���-�� �� ��� �����?
        }
        [Theory]
        [InlineData("vlan 205,209,100,300")]
        [InlineData("vlan add 205,209,100,300")]
        public void GetNumbersVlans_Comma(string input)
        {
            var exeptedList = new List<string>() { "205", "209", "100", "300" };

            List<string> actualtList =new ExtractorNumbersVlans().GetNumbersVlans(input);

            Assert.Equal(actualtList, exeptedList);
        }
        [Theory]
        [InlineData("vlan 205-206,209,100-103,300")]
        [InlineData("vlan add 205-206,209,100-103,300")]
        public void GetNumbersVlans_CommaAndDash(string input)
        {
            var exeptedList = new List<string>() { "205", "206", "209", "100", "101", "102", "103", "300" };

            List<string> actualtList = new ExtractorNumbersVlans().GetNumbersVlans(input);

            Assert.Equal(actualtList, exeptedList);
        }
    }
}