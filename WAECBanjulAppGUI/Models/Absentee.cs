using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAECBanjulAppGUI.Models
{
    public class Absentee
    {
        public string ExamId { get; set; }
        public int ExamYear { get; set; }
        public string CentreNumber { get; set; }
        public int EnglishLanguageAbsents { get; set; }
        public int MathematicsAbsents { get; set; }
        public int ScienceAbsents { get; set; }
        public int SESAbsents { get; set; }
        public int EnglishLanguagePresents { get; set; }
        public int MathematicsPresents { get; set; }
        public int SciencePresents { get; set; }
        public int SESPresents { get; set; }
        public string UserName { get; set; }
        public string PcName { get; set; }
    }
}
