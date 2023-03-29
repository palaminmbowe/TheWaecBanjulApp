using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ICTDUtilities.Objects
{
    class Deadline
    {
        private string examYear;

        public string ExamYear
        {
            get { return examYear; }
            set { examYear = value; }
        }
        private string examInitial;

        public string ExamInitial
        {
            get { return examInitial; }
            set { examInitial = value; }
        }
        private DateTime candidateModificationBegin;

        public DateTime CandidateModificationBegin
        {
            get { return candidateModificationBegin; }
            set { candidateModificationBegin = value; }
        }
        private DateTime candidateModificationEnd;

        public DateTime CandidateModificationEnd
        {
            get { return candidateModificationEnd; }
            set { candidateModificationEnd = value; }
        }
        private DateTime marksKeyingBegin;

        public DateTime MarksKeyingBegin
        {
            get { return marksKeyingBegin; }
            set { marksKeyingBegin = value; }
        }
        private DateTime marksKeyingEnd;

        public DateTime MarksKeyingEnd
        {
            get { return marksKeyingEnd; }
            set { marksKeyingEnd = value; }
        }
        private DateTime currentDate;

        public DateTime CurrentDate
        {
            get { return currentDate; }
            set { currentDate = value; }
        }

        public Deadline(string examYear, string examInitial, DateTime candModBegin, DateTime candModEnd, DateTime marksKeyBegin, DateTime marksKeyEnd, DateTime currentDate)
        {
            ExamYear = examYear;
            ExamInitial = examInitial;
            CandidateModificationBegin = candModBegin;
            CandidateModificationEnd = candModEnd;
            MarksKeyingBegin = marksKeyBegin;
            MarksKeyingEnd = marksKeyEnd;
            CurrentDate = currentDate;
        }
    }
}
