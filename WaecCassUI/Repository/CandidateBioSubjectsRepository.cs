using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using WaecCassUI.Interfaces;
using WaecCassUI.Models;

namespace WaecCassUI.Repository
{
    public class CandidateBioSubjectsRepository : ICandidateBioSubjectsRepository
    {
        private const string NAME = "CandidateBioSubjectsRepository";
        public List<CandidateBioSubjects> GetAll()
        {
            throw new NotImplementedException();
        }

        public (bool status, CandidateBioSubjects candidate) Insert(List<CandidateBioSubjects> candidateBioSubjects)
        {
            using (IDbConnection db = new SqlConnection(AppConnection.CassConnection))
            {
                var total = 0;

                var sql = "EXECUTE [dbo].[uspInsertCandidateBioSubjects] @cassRefNo,@fullName,@sex,@dateOfBirth,@subjectYear1,@subjectYear2,@subjectYear3,@scoresYear1,@scoresYear2,@scoresYear3 ";

                foreach (var c in candidateBioSubjects)
                {
                    try
                    {
                        var results = db.Query<CandidateBioSubjects>(sql, c).ToList();
                        total++;
                    }
                    catch (Exception ex)
                    {
                        Console.Write($"Error in {NAME} - {ex.Message}");
                    }
                    
                }

                //var results = db.Query<List<CandidateBioSubjects>>(sql, candidateBioSubjects).ToList();

                if (total > 0) return (true, candidateBioSubjects[0]);
            }
            
            return (false, new CandidateBioSubjects());
        }
    }
}
