using SavoryTripManage.Controllers.Request;
using SavoryTripManage.Repository.Entity;
using SavoryTripManage.Vo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SavoryTripManage.Convertor
{
    public interface IMetaTimeMachineConvertor
    {

        /// <summary>
        /// request 转换为 entity
        /// </summary>
        MetaTimeMachineEntity toEntity(MetaTimeMachineCreateRequest request);

        /// <summary>
        /// request 转换为 entity
        /// </summary>
        MetaTimeMachineEntity toEntity(MetaTimeMachineUpdateRequest request, MetaTimeMachineEntity oldEntity);

        /// <summary>
        /// 获取空 vo
        /// </summary>
        MetaTimeMachineVo toEmptyVo();

        /// <summary>
        /// entity 转换为 vo
        /// </summary>
        MetaTimeMachineVo toLessVo(MetaTimeMachineEntity entity);

        /// <summary>
        /// entity 转换为 vo
        /// </summary>
        MetaTimeMachineVo toMoreVo(MetaTimeMachineEntity entity);

        /// <summary>
        /// entityList 转换为 voList
        /// </summary>
        List<MetaTimeMachineVo> toLessVoList(List<MetaTimeMachineEntity> entityList);
    }
}
