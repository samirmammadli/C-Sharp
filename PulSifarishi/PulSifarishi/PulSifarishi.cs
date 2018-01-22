using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;

namespace PulSifarishi
{
    

    class PulSifarishi
    {
        public string Header { get; set; }
        public string Content { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        public string Note { get; set; }
    }
}
