using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ICTDUtilities.Objects
{
    class Disability
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
                switch (code)
                {
                    case "1":
                        return "Normal";
                    case "2":
                        return "Visually Impaired";
                    case "3":
                        return "Hearing Speech Impaired";
                    case "4":
                        return "Physically Impaired";
                    case "5":
                        return "Mentally Impaired";
                    case "6":
                        return "Spastic Palsy Epilectic Condidtions";
                    case "7":
                        return "Low Vision";
                    default:
                        return "";
                }
            }
        }

        public Disability(string code)
        {
            Code = code;
        }
    }
}
