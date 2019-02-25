using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZPO1.Reporters;

namespace ZPO1
{
    public class Container
    {
        List<ISocialMediaReporter> reporters;

        public Container()
        {
            reporters = new List<ISocialMediaReporter>();
            reporters.Add(new FBReporter());
            reporters.Add(new GPlusReporter());
            reporters.Add(new TwittReporter());
        }

        public void DisplayReporters()
        {
            reporters.ForEach(report => Console.WriteLine(report.Name));
        }

        public void ReportInfo(string info)
        {
            reporters.ForEach(report => report.ReportInfo(info));
        }
    }
}
