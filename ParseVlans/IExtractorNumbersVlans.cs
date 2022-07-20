using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseVlans
{
    public interface IExtractorNumbersVlans
    {
        List<string> GetNumbersVlans(string txtNumbersVlans);
    }
}
