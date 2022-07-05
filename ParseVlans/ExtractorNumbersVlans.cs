using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ParseVlans
{
    public class ExtractorNumbersVlans
    {
        List<string> numbersVlans;
        public List<string> NumbersVlans =>numbersVlans;

        public ExtractorNumbersVlans(string txtNumbersVlans)
        {
            this.numbersVlans = new List<string>();
            SetNumbersVlans(txtNumbersVlans);
        }

        private void SetNumbersVlans(string txtNumbersVlans)
        {
            string pattern = @"vlan\s(add)?\s?([0-9,-]+)";
            Match match = Regex.Match(txtNumbersVlans, pattern);
            while (match.Success)
            { 
                string rowVlans = match.Groups[2].Value;
                string[] records = rowVlans.Split(',');
                foreach(var record in records)
                    if (record.Contains('-'))
                    {
                        int[] vlansInRecord = record.Split('-').Select(int.Parse).ToArray();
                        for (int i = vlansInRecord[0]; i <= vlansInRecord[1]; i++)
                            this.numbersVlans.Add(i.ToString());
                    }
                    else this.numbersVlans.Add(record);
                match = match.NextMatch();
            }
        }


    }
}
