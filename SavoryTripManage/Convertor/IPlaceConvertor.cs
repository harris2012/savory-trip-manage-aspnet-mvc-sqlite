using SavoryTripManage.Controllers.Request;
using SavoryTripManage.Repository.Entity;
using SavoryTripManage.Vo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SavoryTripManage.Convertor
{
    public interface IPlaceConvertor
    {

        /// <summary>
        /// request 转换为 entity
        /// </summary>
        PlaceEntity toEntity(PlaceCreateRequest request);

        /// <summary>
        /// request 转换为 entity
        /// </summary>
        PlaceEntity toEntity(PlaceUpdateRequest request, PlaceEntity oldEntity);

        /// <summary>
        /// 获取空 vo
        /// </summary>
        PlaceVo toEmptyVo();

        /// <summary>
        /// entity 转换为 vo
        /// </summary>
        PlaceVo toLessVo(PlaceEntity entity);

        /// <summary>
        /// entity 转换为 vo
        /// </summary>
        PlaceVo toMoreVo(PlaceEntity entity);

        /// <summary>
        /// entityList 转换为 voList
        /// </summary>
        List<PlaceVo> toLessVoList(List<PlaceEntity> entityList);
    }
}
