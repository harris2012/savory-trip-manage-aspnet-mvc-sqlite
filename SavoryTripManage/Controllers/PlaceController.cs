using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Web.Http;

using SavoryTripManage.Controllers.Request;
using SavoryTripManage.Controllers.Response;
using SavoryTripManage.Convertor;
using SavoryTripManage.Repository;
using SavoryTripManage.Repository.Entity;

namespace SavoryTripManage.Controllers
{
    [RoutePrefix("api/place")]
    public class PlaceController : BaseController
    {
        /// <summary>
        /// 分页，每页个数
        /// </summary>
        private static readonly int PAGE_SIZE = 15;

        private IPlaceRepository placeRepository;

        private IPlaceConvertor placeConvertor;

        public PlaceController(
            IPlaceRepository placeRepository,
            IPlaceConvertor placeConvertor)
        {
            this.placeRepository = placeRepository;
            this.placeConvertor = placeConvertor;
        }

        [HttpPost]
        [Route("items")]
        public PlaceItemsResponse Items([FromBody]PlaceItemsRequest request)
        {
            PlaceItemsResponse response = new PlaceItemsResponse();

            List<PlaceEntity> entityList = placeRepository.GetEntityList(request.PageIndex, PAGE_SIZE);

            response.Items = placeConvertor.toLessVoList(entityList);

            response.Status = 1;
            return response;
        }

        [HttpPost]
        [Route("count")]
        public PlaceCountResponse Count([FromBody]PlaceCountRequest request)
        {
            PlaceCountResponse response = new PlaceCountResponse();

            int count = placeRepository.GetCount();

            response.TotalCount = count;

            response.Status = 1;
            return response;
        }

        [HttpPost]
        [Route("item")]
        public PlaceItemResponse Item([FromBody]PlaceItemRequest request)
        {
            PlaceItemResponse response = new PlaceItemResponse();

            if (request.Id <= 0)
            {
                response.Status = -1;
                return response;
            }

            PlaceEntity entity = placeRepository.GetById(request.Id);
            if (entity == null)
            {
                response.Status = 404;
                return response;
            }

            response.Item = placeConvertor.toLessVo(entity);

            response.Status = 1;
            return response;
        }

        [HttpPost]
        [Route("create")]
        public PlaceCreateResponse Create([FromBody]PlaceCreateRequest request)
        {
            PlaceCreateResponse response = new PlaceCreateResponse();

            placeRepository.Create(placeConvertor.toEntity(request));

            response.Status = 1;
            return response;
        }

        [HttpPost]
        [Route("empty")]
        public PlaceEmptyResponse Empty([FromBody]PlaceEditableRequest request)
        {
            PlaceEmptyResponse response = new PlaceEmptyResponse();

            response.Item = placeConvertor.toEmptyVo();

            response.Status = 1;
            return response;
        }

        [HttpPost]
        [Route("editable")]
        public PlaceEditableResponse Editable([FromBody]PlaceEditableRequest request)
        {

            PlaceEditableResponse response = new PlaceEditableResponse();

            if (request.Id <= 0)
            {
                response.Status = -1;
                return response;
            }

            PlaceEntity entity = placeRepository.GetById(request.Id);
            if (entity == null)
            {
                response.Status = 404;
                return response;
            }

            response.Item = placeConvertor.toMoreVo(entity);

            response.Status = 1;
            return response;
        }

        [HttpPost]
        [Route("update")]
        public PlaceUpdateResponse Update([FromBody]PlaceUpdateRequest request)
        {

            PlaceUpdateResponse response = new PlaceUpdateResponse();

            if (request.Id == 0 || request.Id < 0)
            {
                response.Status = -1;
                return response;
            }

            PlaceEntity entity = placeRepository.GetById(request.Id);
            if (entity == null)
            {
                response.Status = 404;
                return response;
            }

            placeRepository.Update(placeConvertor.toEntity(request, entity));

            response.Status = 1;
            return response;
        }
    }
}
