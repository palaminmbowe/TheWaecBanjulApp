using System.ComponentModel.DataAnnotations;

namespace WaecCassUI.Models
{
    public class CandidateBioSubjects
    {
        [Key]
        public string? CassRefNo { get; set; }
        public string? FullName { get; set; }
        public string? Sex { get; set; }
        public DateTime DateOfBirth { get; set; }
        //public object? passport { get; set; }
        public string? SubjectYear1 { get; set; }
        public string? SubjectYear2 { get; set; }
        public string? SubjectYear3 { get; set; }
        //public string? subjectYear4 { get; set; }
        public string? ScoresYear1 { get; set; }
        public string? ScoresYear2 { get; set; }
        public string? ScoresYear3 { get; set; }
        //public string? scoresYear4 { get; set; }
    }

}
