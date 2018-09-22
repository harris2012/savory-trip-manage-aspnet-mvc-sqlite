using SavoryTripManage.Vo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SavoryTripManage.Controllers.Response
{
    public class MetaTimeMachineItemsResponse : BaseResponse
    {
        [JsonProperty("items")]
        public List<MetaTimeMachineVo> Items { get; set; }
    }
}
