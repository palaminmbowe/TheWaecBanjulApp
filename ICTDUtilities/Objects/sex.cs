using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ICTDUtilities.Objects
{
    public class Sex
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
                switch (Code)
                {
                    case "1":
                        return "MALE";
                    case "2":
                        return "FEMALE";
                    default:
                        return "";
                }
            }
        }

        public Sex(string code)
        {
            Code = code;
        }
    }
}
