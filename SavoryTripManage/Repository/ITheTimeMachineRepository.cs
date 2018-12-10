using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using SavoryTripManage.Repository.Entity;

namespace SavoryTripManage.Repository
{
    public interface ITheTimeMachineRepository
    {
        /// <summary>
        /// 获取所有实体
        /// </summary>
        List<TheTimeMachineEntity> GetEntityList();

        /// <summary>
        /// 获取单个实体
        /// </summary>
        TheTimeMachineEntity GetById(int id);
    }
}
