using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ICTDUtilities.Objects
{
    class SchoolOfChoice
    {
        private string code;

        public string Code
        {
            get { return code; }
            set { code = value; }
        }
        private string name = "";

        public string Name
        {
            get 
            {
                return name;
            }
        }

        public SchoolOfChoice(string code, string name)
        {
            Code = code;
            this.name = name;
        }
    }
}
