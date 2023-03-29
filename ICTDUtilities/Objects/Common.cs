using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ICTDUtilities.Objects
{
    static class Common
    {
        private static List<Subject> subjectsGabece = new List<Subject>();
        private static List<Subject> subjectsWassce = new List<Subject>();
        private static List<SchoolOfChoice> schoolOfChoice = new List<SchoolOfChoice>();
        private static List<School> schoolsGabece = new List<School>();
        private static List<School> schoolsWassce = new List<School>();
        private static List<Deadline> deadlines = new List<Deadline>();

        internal static List<Deadline> Deadline
        {
            get { return Common.deadlines; }
            set { Common.deadlines = value; }
        }

        internal static List<School> SchoolsGabece
        {
            get { return Common.schoolsGabece; }
            set { Common.schoolsGabece = value; }
        }

        internal static List<School> SchoolsWassce
        {
            get { return Common.schoolsWassce; }
            set { Common.schoolsWassce = value; }
        }

        public static List<SchoolOfChoice> SchoolOfChoice
        {
            get { return Common.schoolOfChoice; }
            set { Common.schoolOfChoice = value; }
        }

        public static List<Subject> SubjectsWassce
        {
            get { return Common.subjectsWassce; }
            set { Common.subjectsWassce = value; }
        }

        public static List<Subject> SubjectsGabece
        {
            get { return Common.subjectsGabece; }
            set { Common.subjectsGabece = value; }
        }

        public static string GetSubjectName(string shortCode)
        {
            foreach (Subject s in SubjectsGabece)
            {
                if (shortCode == s.ShortCode)
                    return s.Name;
            }

            foreach (Subject s in SubjectsWassce)
            {
                if (shortCode == s.ShortCode)
                    return s.Name;
            }
            return "";
        }

        public static string GetSchoolOfChoiceName(string code)
        {
            foreach (SchoolOfChoice s in SchoolOfChoice)
            {
                if (code == s.Code)
                    return s.Name;
            }
            return "";
        }
    }
}
