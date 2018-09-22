using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using SavoryTripManage.Controllers.Request;
using SavoryTripManage.Repository.Entity;
using SavoryTripManage.Vo;

namespace SavoryTripManage.Convertor
{
    public class MetaTimeMachineConvertor : IMetaTimeMachineConvertor
    {

        public MetaTimeMachineEntity toEntity(MetaTimeMachineCreateRequest request)
        {
            MetaTimeMachineEntity entity = new MetaTimeMachineEntity();

            entity.TimeMachineId = request.TimeMachineId != null ? request.TimeMachineId.Value : 0;
            entity.TimeMachineName = request.TimeMachineName;

            return entity;
        }

        public MetaTimeMachineEntity toEntity(MetaTimeMachineUpdateRequest request)
        {
            MetaTimeMachineEntity entity = new MetaTimeMachineEntity();

            entity.Id = request.Id;
            entity.TimeMachineId = request.TimeMachineId != null ? request.TimeMachineId.Value : 0;
            entity.TimeMachineName = request.TimeMachineName;

            return entity;
        }

        public MetaTimeMachineVo toEmptyVo()
        {
            MetaTimeMachineVo vo = new MetaTimeMachineVo();

            return vo;
        }

        public MetaTimeMachineVo toLessVo(MetaTimeMachineEntity entity)
        {
            MetaTimeMachineVo vo = toVo(entity);

            return vo;
        }

        public MetaTimeMachineVo toMoreVo(MetaTimeMachineEntity entity)
        {
            MetaTimeMachineVo vo = toVo(entity);

            return vo;
        }

        public List<MetaTimeMachineVo> toLessVoList(List<MetaTimeMachineEntity> entityList)
        {
            if (entityList == null || entityList.Count == 0)
            {
                return null;
            }

            List<MetaTimeMachineVo> voList = new List<MetaTimeMachineVo>();
            foreach (MetaTimeMachineEntity entity in entityList) {
                voList.Add(toLessVo(entity));
            }

            return voList;
        }

        /// <summary>
        /// 将entity转换为vo。不包括来自元数据的属性
        /// </summary>
        private MetaTimeMachineVo toVo(MetaTimeMachineEntity entity)
        {
            MetaTimeMachineVo vo = new MetaTimeMachineVo();

            vo.Id = entity.Id;
            vo.TimeMachineId = entity.TimeMachineId;
            vo.TimeMachineName = entity.TimeMachineName;

            return vo;
        }
    }
}
