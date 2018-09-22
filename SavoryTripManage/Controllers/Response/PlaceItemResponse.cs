using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using SavoryTripManage.Vo;

namespace SavoryTripManage.Controllers.Response
{
    public class PlaceItemResponse : BaseResponse
    {
        [JsonProperty("item")]
        public PlaceVo Item { get; set; }
    }
}
