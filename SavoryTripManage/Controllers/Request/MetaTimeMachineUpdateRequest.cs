using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using SavoryTripManage.Vo;

namespace SavoryTripManage.Controllers.Request
{
    public class MetaTimeMachineUpdateRequest
    {

        public int Id { get; set; }

        public int? TimeMachineId { get; set; }

        public string TimeMachineName { get; set; }
    }
}
