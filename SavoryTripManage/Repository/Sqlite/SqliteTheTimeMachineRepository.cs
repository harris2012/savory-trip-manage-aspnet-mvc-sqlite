using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Dapper;

using SavoryTripManage.Repository.Entity;

namespace SavoryTripManage.Repository.Sqlite
{
    public class SqliteTheTimeMachineRepository : ITheTimeMachineRepository
    {

        private SqliteConnectionProvider connectionProvider;

        public SqliteTheTimeMachineRepository(SqliteConnectionProvider connectionProvider)
        {
            this.connectionProvider = connectionProvider;
        }

        public TheTimeMachineEntity GetById(int id)
        {
            string sql = "select time_machine_id as TimeMachineId, time_machine_name as TimeMachineName from meta_time_machine where Id = ?";

            using (var sqliteConn = connectionProvider.GetConnection())
            {
                return sqliteConn.QueryFirstOrDefault<TheTimeMachineEntity>(sql, new { Id = id });
            }
        }

        public List<TheTimeMachineEntity> GetEntityList()
        {
            string sql = "select time_machine_id as TimeMachineId, time_machine_name as TimeMachineName from meta_time_machine";

            using (var sqliteConn = connectionProvider.GetConnection())
            {
                return sqliteConn.Query<TheTimeMachineEntity>(sql).ToList();
            }
        }
    }
}
