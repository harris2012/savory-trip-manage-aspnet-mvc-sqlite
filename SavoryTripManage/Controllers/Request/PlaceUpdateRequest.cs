using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using SavoryTripManage.Vo;

namespace SavoryTripManage.Controllers.Request
{
    public class PlaceUpdateRequest
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public double Longitude { get; set; }

        public double Latitude { get; set; }

        public int? TimeMachineId { get; set; }
    }
}
