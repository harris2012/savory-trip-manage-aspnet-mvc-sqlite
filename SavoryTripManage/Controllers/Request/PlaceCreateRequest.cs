using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using SavoryTripManage.Vo;

namespace SavoryTripManage.Controllers.Request
{
    public class PlaceCreateRequest
    {

        public string Name { get; set; }

        public double Longitude { get; set; }

        public double Latitude { get; set; }

        public int? TimeMachineId { get; set; }

    }
}
