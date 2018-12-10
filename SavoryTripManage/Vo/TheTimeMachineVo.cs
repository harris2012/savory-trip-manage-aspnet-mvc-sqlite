using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SavoryTripManage.Vo
{
    public class TheTimeMachineVo
    {
        [JsonProperty("timeMachineId")]
        public int TimeMachineId { get; set; }

        [JsonProperty("timeMachineName")]
        public string TimeMachineName { get; set; }

        [JsonProperty("selected")]
        public bool Selected { get; set; }
    }
}
