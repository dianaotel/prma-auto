using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTesting.Com.DataModels
{
    class ProjectCardModel
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Description { get; set; }
        public string RequirementSummary { get; set; }
        public string ReqMet { get; set; }
        public string ReqMetKV { get; set; }
        public string ReqPartiallyMet { get; set; }
        public string ReqPartiallyMetKV { get; set; }
        public string ReqNotMet { get; set; }
        public string ReqNotMetKV { get; set; }
    }
}
