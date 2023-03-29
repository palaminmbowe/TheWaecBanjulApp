using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaecCassUI.Interfaces;
using WaecCassUI.Models;
using Dapper;
using System.Data;

namespace WaecCassUI.Repository
{
    public class SchoolPinsRepository : ISchoolPinsRepository
    {
        public List<SchoolPins> GetSchoolPins()
        {
            using IDbConnection db = new SqlConnection(AppConnection.CassConnection);

            var schoolPins = db.Query<SchoolPins>(
                sql: "SELECT SchoolNumber, SchoolPin FROM SchoolPins"
                , commandType: CommandType.Text).ToList();

            return schoolPins;
        }

        public List<SchoolPins> GetSchoolPins(string schoolNumber)
        {
            throw new NotImplementedException();
        }

        public async Task<List<SchoolPins>> GetSchoolPinsAsync()
        {
            using IDbConnection db = new SqlConnection(AppConnection.CassConnection);

            var schoolPins = await db.QueryAsync<SchoolPins>(
                sql: "SELECT SchoolNumber, SchoolPin FROM SchoolPins"
                , commandType: CommandType.Text);

            return schoolPins.ToList();
        }
    }
}
