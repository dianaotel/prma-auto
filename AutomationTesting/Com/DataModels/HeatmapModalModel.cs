using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTesting.Com.DataModels
{
    class HeatmapModalModel
    {
        public string Title { get; set; }
        public string TotalReqs { get; set; }
        public string TotalKVs { get; set; }
        public string ReqMet { get; set; }
        public string ReqMetKV { get; set; }
        public string ReqPartiallyMet { get; set; }
        public string ReqPartiallyMetKV { get; set; }
        public string ReqNotMet { get; set; }
        public string ReqNotMetKV { get; set; }
    }
}
