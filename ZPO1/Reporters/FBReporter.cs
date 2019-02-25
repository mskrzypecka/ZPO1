using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO1.Reporters
{
    public class FBReporter : ISocialMediaReporter
    {
        public string Name => "FBReporter";

        public void ReportInfo(string info)
        {
            Console.WriteLine($"FB info: {info}");
        }
    }
}
