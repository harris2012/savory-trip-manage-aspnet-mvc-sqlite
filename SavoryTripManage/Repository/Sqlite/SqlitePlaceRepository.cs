using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Dapper;

using SavoryTripManage.Repository.Entity;

namespace SavoryTripManage.Repository.Sqlite
{
    public class SqlitePlaceRepository : IPlaceRepository
    {

        private SqliteConnectionProvider connectionProvider;

        public SqlitePlaceRepository(SqliteConnectionProvider connectionProvider)
        {
            this.connectionProvider = connectionProvider;
        }

        public void Create(PlaceEntity entity)
        {
            string sql = "insert into place(name, longitude, latitude, time_machine_id) values (@Name, @Longitude, @Latitude, @TimeMachineId);";

            using (var sqliteConn = connectionProvider.GetConnection())
            {
                sqliteConn.Execute(sql, new { Name = entity.Name, Longitude = entity.Longitude, Latitude = entity.Latitude, TimeMachineId = entity.TimeMachineId });
            }
        }

        public PlaceEntity GetById(long id)
        {
            string sql = "select id, name as Name, longitude as Longitude, latitude as Latitude, time_machine_id as TimeMachineId from place where Id = ?";

            using (var sqliteConn = connectionProvider.GetConnection())
            {
                return sqliteConn.QueryFirstOrDefault<PlaceEntity>(sql, new { Id = id });
            }
        }

        public int GetCount()
        {
            string sql = "select count(1) from place";

            using (var sqliteConn = connectionProvider.GetConnection())
            {
                return sqliteConn.QuerySingle<int>(sql);
            }
        }

        public List<PlaceEntity> GetEntityList()
        {
            string sql = "select id, name as Name, longitude as Longitude, latitude as Latitude, time_machine_id as TimeMachineId from place";

            using (var sqliteConn = connectionProvider.GetConnection())
            {
                return sqliteConn.Query<PlaceEntity>(sql).ToList();
            }
        }

        public List<PlaceEntity> GetEntityList(int pageIndex, int pageSize)
        {
            string sql = "select id, name as Name, longitude as Longitude, latitude as Latitude, time_machine_id as TimeMachineId from place limit @Start, @Count";

            using (var sqliteConn = connectionProvider.GetConnection())
            {
                return sqliteConn.Query<PlaceEntity>(sql, new { Start = (pageIndex - 1) * pageSize, Count = pageSize }).ToList();
            }
        }

        public void Update(PlaceEntity entity)
        {
            string sql = "update place set name = @Name, longitude = @Longitude, latitude = @Latitude, time_machine_id = @TimeMachineId where id = @Id;";

            using (var sqliteConn = connectionProvider.GetConnection())
            {
                sqliteConn.Execute(sql, new { Name = entity.Name, Longitude = entity.Longitude, Latitude = entity.Latitude, TimeMachineId = entity.TimeMachineId });
            }
        }
    }
}
