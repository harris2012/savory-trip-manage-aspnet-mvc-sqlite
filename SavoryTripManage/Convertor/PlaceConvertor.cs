using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using SavoryTripManage.Controllers.Request;
using SavoryTripManage.Repository.Entity;
using SavoryTripManage.Vo;

namespace SavoryTripManage.Convertor
{
    public class PlaceConvertor : IPlaceConvertor
    {

        public PlaceEntity toEntity(PlaceCreateRequest request)
        {
            PlaceEntity entity = new PlaceEntity();

            entity.Name = request.Name;
            entity.Longitude = request.Longitude;
            entity.Latitude = request.Latitude;
            entity.TimeMachineId = request.TimeMachineId != null ? request.TimeMachineId.Value : 0;

            return entity;
        }

        public PlaceEntity toEntity(PlaceUpdateRequest request)
        {
            PlaceEntity entity = new PlaceEntity();

            entity.Id = request.Id;
            entity.Name = request.Name;
            entity.Longitude = request.Longitude;
            entity.Latitude = request.Latitude;
            entity.TimeMachineId = request.TimeMachineId != null ? request.TimeMachineId.Value : 0;

            return entity;
        }

        public PlaceVo toEmptyVo()
        {
            PlaceVo vo = new PlaceVo();

            return vo;
        }

        public PlaceVo toLessVo(PlaceEntity entity)
        {
            PlaceVo vo = toVo(entity);

            return vo;
        }

        public PlaceVo toMoreVo(PlaceEntity entity)
        {
            PlaceVo vo = toVo(entity);

            return vo;
        }

        public List<PlaceVo> toLessVoList(List<PlaceEntity> entityList)
        {
            if (entityList == null || entityList.Count == 0)
            {
                return null;
            }

            List<PlaceVo> voList = new List<PlaceVo>();
            foreach (PlaceEntity entity in entityList) {
                voList.Add(toLessVo(entity));
            }

            return voList;
        }

        /// <summary>
        /// 将entity转换为vo。不包括来自元数据的属性
        /// </summary>
        private PlaceVo toVo(PlaceEntity entity)
        {
            PlaceVo vo = new PlaceVo();

            vo.Id = entity.Id;
            vo.Name = entity.Name;
            vo.Longitude = entity.Longitude;
            vo.Latitude = entity.Latitude;
            vo.TimeMachineId = entity.TimeMachineId;

            return vo;
        }
    }
}
