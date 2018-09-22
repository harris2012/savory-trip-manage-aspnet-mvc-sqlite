using SavoryTripManage.Vo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SavoryTripManage.Controllers.Response
{
    public class PlaceCountResponse : BaseResponse
    {
        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }
    }
}
