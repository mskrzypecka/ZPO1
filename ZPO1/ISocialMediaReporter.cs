using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO1
{
    public interface ISocialMediaReporter
    {
        string Name { get; }

        void ReportInfo (string info);
    }
}
