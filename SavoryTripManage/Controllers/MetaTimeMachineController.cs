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
using SavoryTripManage.Meta;

namespace SavoryTripManage.Controllers
{
    [RoutePrefix("api/meta-time-machine")]
    public class MetaTimeMachineController : BaseController
    {
        /// <summary>
        /// 分页，每页个数
        /// </summary>
        private static readonly int PAGE_SIZE = 15;

        private IMetaTimeMachineRepository metaTimeMachineRepository;

        private IMetaTimeMachineConvertor metaTimeMachineConvertor;

        private ITheTimeMachineMeta theTimeMachineMeta;

        public MetaTimeMachineController(
            ITheTimeMachineMeta theTimeMachineMeta,
            IMetaTimeMachineRepository metaTimeMachineRepository,
            IMetaTimeMachineConvertor metaTimeMachineConvertor)
        {
            this.metaTimeMachineRepository = metaTimeMachineRepository;
            this.metaTimeMachineConvertor = metaTimeMachineConvertor;
            this.theTimeMachineMeta = theTimeMachineMeta;
        }

        [HttpPost]
        [Route("items")]
        public MetaTimeMachineItemsResponse Items([FromBody]MetaTimeMachineItemsRequest request)
        {
            MetaTimeMachineItemsResponse response = new MetaTimeMachineItemsResponse();

            List<MetaTimeMachineEntity> entityList = metaTimeMachineRepository.GetEntityList(request.PageIndex, PAGE_SIZE);

            response.Items = metaTimeMachineConvertor.toLessVoList(entityList);

            response.Status = 1;
            return response;
        }

        [HttpPost]
        [Route("count")]
        public MetaTimeMachineCountResponse Count([FromBody]MetaTimeMachineCountRequest request)
        {
            MetaTimeMachineCountResponse response = new MetaTimeMachineCountResponse();

            int count = metaTimeMachineRepository.GetCount();

            response.TotalCount = count;

            response.Status = 1;
            return response;
        }

        [HttpPost]
        [Route("item")]
        public MetaTimeMachineItemResponse Item([FromBody]MetaTimeMachineItemRequest request)
        {
            MetaTimeMachineItemResponse response = new MetaTimeMachineItemResponse();

            if (request.Id <= 0)
            {
                response.Status = -1;
                return response;
            }

            MetaTimeMachineEntity entity = metaTimeMachineRepository.GetById(request.Id);
            if (entity == null)
            {
                response.Status = 404;
                return response;
            }

            response.Item = metaTimeMachineConvertor.toLessVo(entity);

            response.Status = 1;
            return response;
        }

        [HttpPost]
        [Route("create")]
        public MetaTimeMachineCreateResponse Create([FromBody]MetaTimeMachineCreateRequest request)
        {
            MetaTimeMachineCreateResponse response = new MetaTimeMachineCreateResponse();

            metaTimeMachineRepository.Create(metaTimeMachineConvertor.toEntity(request));

            theTimeMachineMeta.Refresh();

            response.Status = 1;
            return response;
        }

        [HttpPost]
        [Route("empty")]
        public MetaTimeMachineEmptyResponse Empty([FromBody]MetaTimeMachineEditableRequest request)
        {
            MetaTimeMachineEmptyResponse response = new MetaTimeMachineEmptyResponse();

            response.Item = metaTimeMachineConvertor.toEmptyVo();

            response.Status = 1;
            return response;
        }

        [HttpPost]
        [Route("editable")]
        public MetaTimeMachineEditableResponse Editable([FromBody]MetaTimeMachineEditableRequest request)
        {

            MetaTimeMachineEditableResponse response = new MetaTimeMachineEditableResponse();

            if (request.Id <= 0)
            {
                response.Status = -1;
                return response;
            }

            MetaTimeMachineEntity entity = metaTimeMachineRepository.GetById(request.Id);
            if (entity == null)
            {
                response.Status = 404;
                return response;
            }

            response.Item = metaTimeMachineConvertor.toMoreVo(entity);

            response.Status = 1;
            return response;
        }

        [HttpPost]
        [Route("update")]
        public MetaTimeMachineUpdateResponse Update([FromBody]MetaTimeMachineUpdateRequest request)
        {

            MetaTimeMachineUpdateResponse response = new MetaTimeMachineUpdateResponse();

            if (request.Id == 0 || request.Id < 0)
            {
                response.Status = -1;
                return response;
            }

            MetaTimeMachineEntity entity = metaTimeMachineRepository.GetById(request.Id);
            if (entity == null)
            {
                response.Status = 404;
                return response;
            }

            metaTimeMachineRepository.Update(metaTimeMachineConvertor.toEntity(request));

            theTimeMachineMeta.Refresh();

            response.Status = 1;
            return response;
        }
    }
}
