using System.Linq;
namespace ParseVlansTests
{
    public class ExtractorNumbersVlansTest
    {
        [Theory]
        [InlineData("vlan add 200-210")]
        [InlineData("vlan 200-210")]
        public void GetNumbersVlans_Dash(string input)
        {
            var exeptedList = new List<string>() { "200", "201", "202", "203", "204", "205", "206", "207", "208", "209","210" };
            //А так можно(см ниже)? или тесты должны быть более понятными?
            //var exeptedList = new List<string>(Enumerable.Range(200,11).ToList().ConvertAll(x=>x.ToString()));

            List<string> actualtList = ExtractorNumbersVlans.GetNumbersVlans(input);

            Assert.Equal(actualtList, exeptedList);
            //Assert.All(actualtList, x => x.StartsWith("ooo")); //почему это срабатывает как ОК?Должна пройти проверка,
            //начинаются ли все строки в листе с "ооо". Или я что-то не так понял?
        }
        [Theory]
        [InlineData("vlan 205,209,100,300")]
        [InlineData("vlan add 205,209,100,300")]
        public void GetNumbersVlans_Comma(string input)
        {
            var exeptedList = new List<string>() { "205", "209", "100", "300" };

            List<string> actualtList = ExtractorNumbersVlans.GetNumbersVlans(input);

            Assert.Equal(actualtList, exeptedList);
        }
    }
}