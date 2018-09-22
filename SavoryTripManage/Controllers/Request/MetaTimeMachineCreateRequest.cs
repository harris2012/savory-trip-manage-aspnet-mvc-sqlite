using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using SavoryTripManage.Vo;

namespace SavoryTripManage.Controllers.Request
{
    public class MetaTimeMachineCreateRequest
    {

        public int? TimeMachineId { get; set; }

        public string TimeMachineName { get; set; }

    }
}
