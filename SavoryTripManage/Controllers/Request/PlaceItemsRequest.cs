using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SavoryTripManage.Controllers.Request
{
    public class PlaceItemsRequest : PlaceCountRequest
    {
        public int PageIndex { get; set; }
    }
}
