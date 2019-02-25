using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO1.Reporters
{
    public class TwittReporter : ISocialMediaReporter
    {
        public string Name => "TwittReporter";

        public void ReportInfo(string info)
        {
            Console.WriteLine($"Twitter info: {info}");
        }
    }
}
