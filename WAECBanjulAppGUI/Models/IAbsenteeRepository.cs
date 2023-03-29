using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAECBanjulAppGUI.Models
{
    public interface IAbsenteeRepository
    {
        //C
        (bool status, string message) Insert(Absentee absentee);

        //R
        List<Absentee> GetAbsentees();

        //U

        //D
    }
}
