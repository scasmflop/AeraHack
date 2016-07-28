using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackApp.Contracts
{
    public class InspectionItem
    {
        public string Condition { get; set; }
        public string Comment { get; set; }
        public bool RepairedIndicator { get; set; }
        public bool SealLeakIndicator { get; set; }
    }
}
