//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ReportsPrinting.Models
{
    using System;
    
    public partial class uspTimetable_GetByExamId_ExamYear_Result
    {
        public string ExamID { get; set; }
        public int ExamYear { get; set; }
        public string CentreNumber { get; set; }
        public string SubjectName { get; set; }
        public string SubjectShortName { get; set; }
        public int Pack50 { get; set; }
        public int Pack15 { get; set; }
        public int Pack10 { get; set; }
        public int NumberOfCandidates { get; set; }
        public int NumberOfPapers { get; set; }
        public string ShortSubjectCode { get; set; }
        public int PaperNumber { get; set; }
        public string PaperTypeName { get; set; }
        public System.DateTime Date { get; set; }
        public System.TimeSpan StartTime { get; set; }
        public System.TimeSpan EndTime { get; set; }
        public System.DateTime DeliveryDate { get; set; }
        public bool CombinedPaper { get; set; }
        public int TadSubjectCode { get; set; }
        public string CentreVenue { get; set; }
        public string ExamName { get; set; }
        public int ExamInitial { get; set; }
        public string YearStarted { get; set; }
        public string ExamShortName { get; set; }
    }
}
