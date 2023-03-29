using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace WAECBanjulAppGUI.Models
{
    public class AbsenteeRepository : IAbsenteeRepository
    {
        public List<Absentee> GetAbsentees()
        {
            using (IDbConnection db = new SqlConnection(AppConnection.NatconnectionString))
            {
                //var sql = $"SELECT [ExamID], [ExamYear] ,[CentreNumber] ,[EnglishLanguageAbsents] ,[MathematicsAbsents] ,[ScienceAbsents] ,[SESAbsents] ,[EnglishLanguagePresents] ,[MathematicsPresents] ,[SciencePresents],[SESPresents] ,[UserName] ,[PcName] FROM [nat].[Absentees] ";

                var sql = "EXECUTE [nat].[uspGetAbsenteeInfo] ";

                try
                {
                    var absentees = db.Query<Absentee>(sql).ToList();
                    return absentees;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error getting records: {ex.Message}");
                }

                return null;
            }
        }

        public (bool status, string message) Insert(Absentee absentee)
        {
            using (IDbConnection db = new SqlConnection(AppConnection.NatconnectionString))
            {
                var sql = $"EXECUTE [nat].[uspAddAbsenteeInfo] @examID,@ExamYear,@CentreNumber,@EnglishLanguageAbsents,@MathematicsAbsents,@ScienceAbsents,@SESAbsents,@EnglishLanguagePresents,@MathematicsPresents,@SciencePresents,@SESPresents,@UserName,@PcName";

                try
                {
                    var absentees = db.Query<Absentee>(sql, absentee).ToList();

                    return (true, $"Record saved successfully.");
                }
                catch (Exception ex)
                {
                    return (false, $"Error saving records - {ex.Message}");
                }
            }
        }
    }
}
