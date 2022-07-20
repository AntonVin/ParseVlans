using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseVlans
{
    public interface IExtractorDictionaryVlans
    {
        Dictionary<string, string> GetDictionaryVlans(string txtDictionaryVlans);
    }
}
