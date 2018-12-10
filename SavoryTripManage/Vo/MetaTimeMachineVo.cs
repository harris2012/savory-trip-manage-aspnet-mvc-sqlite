using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SavoryTripManage.Vo
{
    public class MetaTimeMachineVo
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("timeMachineId")]
        public int? TimeMachineId { get; set; }

        [JsonProperty("timeMachineName")]
        public string TimeMachineName { get; set; }
    }
}
