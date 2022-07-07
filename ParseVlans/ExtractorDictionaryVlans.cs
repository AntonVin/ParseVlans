using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ParseVlans
{
    public static class ExtractorDictionaryVlans
    {
        public static Dictionary<string,string> GetDictionaryVlans(string txtDictionaryVlans)
        {
            Dictionary<string,string> dictVlans = new Dictionary<string,string>();
            string pattern = @"\n(\d+)\s+([\w-]+)";
            Match match = Regex.Match(txtDictionaryVlans, pattern);
            while (match.Success)
            {
                dictVlans.Add(match.Groups[1].Value, match.Groups[2].Value);
                match = match.NextMatch();
            }
            return dictVlans;
        }
    }
}
