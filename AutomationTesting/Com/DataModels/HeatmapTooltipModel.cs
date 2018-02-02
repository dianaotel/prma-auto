using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTesting.Com.DataModels
{
    class HeatmapTooltipModel
    {
        public string color;

        public string colorText;
        public string colorLink;

        public string vulnerabilityText;
        public string vulnerabilityLink;

        public string ToStr()
        {
            return "color: " + color + ", colorText: " + colorText + ", colorLink: " + colorLink + ", vulnerabilityText: " + vulnerabilityText + ", vulnerabilityLink: " + vulnerabilityLink;
        }
    }
}
