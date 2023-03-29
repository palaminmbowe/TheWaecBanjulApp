using WaecCassUI.Models;

namespace WaecCassUI.Interfaces
{
    public interface ISchoolPinsRepository
    {
        //C
        public List<SchoolPins> GetSchoolPins();
        public Task<List<SchoolPins>> GetSchoolPinsAsync();
        public List<SchoolPins> GetSchoolPins(string schoolNumber);

        //R

        //U

        //D
    }
}