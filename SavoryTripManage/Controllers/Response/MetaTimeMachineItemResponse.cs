using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using SavoryTripManage.Vo;

namespace SavoryTripManage.Controllers.Response
{
    public class MetaTimeMachineItemResponse : BaseResponse
    {
        [JsonProperty("item")]
        public MetaTimeMachineVo Item { get; set; }
    }
}
