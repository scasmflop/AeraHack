using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackApp.Contracts
{
    public class Completion
    {
        public decimal CompletionId { get; set; }
        public string  CompletionName { get; set; }
        public string APINumber { get; set; }        
        public string State { get; set; }
        public string PrimaryPurpose { get; set; }
        public string Material { get; set; }
        public string Status { get; set; }
        public string Manifold { get; set; }
    }
}
