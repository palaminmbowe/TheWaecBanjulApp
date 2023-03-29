using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ICTDUtilities.Objects
{
    class School
    {
        private string code;

        public string Code
        {
            get { return code; }
            set { code = value; }
        }
        private string description;

        public string Description
        {
            get 
            {
                return description;
            }
        }

        public School(string code, string description)
        {
            Code = code;
            this.description = description;
        }

        public string GetSchoolName(string schoolCode)
        {
            return Description;
        }
    }
}
