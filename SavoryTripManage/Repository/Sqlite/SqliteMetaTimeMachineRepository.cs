using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Dapper;

using SavoryTripManage.Repository.Entity;

namespace SavoryTripManage.Repository.Sqlite
{
    public class SqliteMetaTimeMachineRepository : IMetaTimeMachineRepository
    {

        private SqliteConnectionProvider connectionProvider;

        public SqliteMetaTimeMachineRepository(SqliteConnectionProvider connectionProvider)
        {
            this.connectionProvider = connectionProvider;
        }

        public void Create(MetaTimeMachineEntity entity)
        {
            string sql = "insert into meta_time_machine(time_machine_id, time_machine_name) values (@TimeMachineId, @TimeMachineName);";

            using (var sqliteConn = connectionProvider.GetConnection())
            {
                sqliteConn.Execute(sql, new { TimeMachineId = entity.TimeMachineId, TimeMachineName = entity.TimeMachineName });
            }
        }

        public MetaTimeMachineEntity GetById(long id)
        {
            string sql = "select id, time_machine_id as TimeMachineId, time_machine_name as TimeMachineName from meta_time_machine where Id = ?";

            using (var sqliteConn = connectionProvider.GetConnection())
            {
                return sqliteConn.QueryFirstOrDefault<MetaTimeMachineEntity>(sql, new { Id = id });
            }
        }

        public int GetCount()
        {
            string sql = "select count(1) from meta_time_machine";

            using (var sqliteConn = connectionProvider.GetConnection())
            {
                return sqliteConn.QuerySingle<int>(sql);
            }
        }

        public List<MetaTimeMachineEntity> GetEntityList()
        {
            string sql = "select id, time_machine_id as TimeMachineId, time_machine_name as TimeMachineName from meta_time_machine";

            using (var sqliteConn = connectionProvider.GetConnection())
            {
                return sqliteConn.Query<MetaTimeMachineEntity>(sql).ToList();
            }
        }

        public List<MetaTimeMachineEntity> GetEntityList(int pageIndex, int pageSize)
        {
            string sql = "select id, time_machine_id as TimeMachineId, time_machine_name as TimeMachineName from meta_time_machine limit @Start, @Count";

            using (var sqliteConn = connectionProvider.GetConnection())
            {
                return sqliteConn.Query<MetaTimeMachineEntity>(sql, new { Start = (pageIndex - 1) * pageSize, Count = pageSize }).ToList();
            }
        }

        public void Update(MetaTimeMachineEntity entity)
        {
            string sql = "update meta_time_machine set time_machine_id = @TimeMachineId, time_machine_name = @TimeMachineName where id = @Id;";

            using (var sqliteConn = connectionProvider.GetConnection())
            {
                sqliteConn.Execute(sql, new { id = entity.Id, TimeMachineId = entity.TimeMachineId, TimeMachineName = entity.TimeMachineName });
            }
        }
    }
}
