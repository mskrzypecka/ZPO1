using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO1.Reporters
{
    public class GPlusReporter : ISocialMediaReporter
    {
        public string Name => "GPlusReporter";

        public void ReportInfo(string info)
        {
            Console.WriteLine($"GPlus info: {info}");
        }
    }
}
