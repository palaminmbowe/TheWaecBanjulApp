using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ICTDUtilities.Objects
{
    class Subject
    {
        private string shortCode;

        public string ShortCode
        {
            get { return shortCode; }
            set { shortCode = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Subject(string shortCode)
        {
            ShortCode = shortCode;
        }

        public Subject(string shortCode, string name)
        {
            ShortCode = shortCode;
            Name = name;
        }

        public void GetSubjectName(string shortCode)
        {
            throw new System.NotImplementedException();
        }
    }
}
