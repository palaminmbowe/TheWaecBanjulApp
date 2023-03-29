using WaecCassUI.Models;

namespace WaecCassUI.Interfaces
{
    public interface ICandidateBioSubjectsRepository
    {
        //C
        public (bool status, CandidateBioSubjects candidate) Insert(List<CandidateBioSubjects> candidateBioSubjects);

        //R
        public List<CandidateBioSubjects> GetAll();

        //U

        //D
    }
}