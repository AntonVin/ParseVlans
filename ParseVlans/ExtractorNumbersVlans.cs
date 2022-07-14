using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ParseVlans
{
    static public class ExtractorNumbersVlans
    {
        public static List<string> GetNumbersVlans(string txtNumbersVlans)
        {
            var lstOutput = new List<string>();
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
                            lstOutput.Add(i.ToString());
                    }
                    else lstOutput.Add(record);
                match = match.NextMatch();
            }
            return lstOutput;         
        }
    }
}
