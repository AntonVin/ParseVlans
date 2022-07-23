using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseVlans
{
    public class GeneratorListVlans : IGeneratorListVlans
    {
        private IExtractorNumbersVlans extractorNumbersVlans;
        private IExtractorDictionaryVlans extractorDictionaryVlans;

        public GeneratorListVlans(IExtractorNumbersVlans extractorNumbersVlans, IExtractorDictionaryVlans extractorDictionaryVlans)
        {
            this.extractorNumbersVlans = extractorNumbersVlans;
            this.extractorDictionaryVlans = extractorDictionaryVlans;
        }

        public string GetText(string txtInterface, string txtVlans)
        {
            var output = new StringBuilder();
            List<string> listNumbers = this.extractorNumbersVlans.GetNumbersVlans(txtInterface);
            Dictionary<string, string> dictVlans = this.extractorDictionaryVlans.GetDictionaryVlans(txtVlans);
            foreach (string number in listNumbers)
            {
                string name = dictVlans.ContainsKey(number) ?
                    (" " + dictVlans[number]) : "";
                output.AppendLine(number + name);
            }
            return output.ToString();
        }
    }
}
