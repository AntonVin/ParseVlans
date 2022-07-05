using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ParseVlans
{
    internal class ExtractorDictionaryVlans
    {
        Dictionary<string, string> dictionaryVlans;
        public Dictionary<string, string> DictionaryVlans => dictionaryVlans;//only get

        public ExtractorDictionaryVlans(string txtDictionaryVlans)
        {
            this.dictionaryVlans = new Dictionary<string, string>();
            SetDictionaryVlans(txtDictionaryVlans);
        }

        private void SetDictionaryVlans(string txtDictionaryVlans)
        {
            string pattern = @"\n(\d+)\s+([\w-]+)";
            Match match = Regex.Match(txtDictionaryVlans, pattern);
            while (match.Success)
            {
                this.dictionaryVlans.Add(match.Groups[1].Value, match.Groups[2].Value);
                match = match.NextMatch();
            }
        }
    }
}
