using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using SavoryTripManage.Repository;
using SavoryTripManage.Repository.Entity;

namespace SavoryTripManage.Meta
{
    public class TheTimeMachineMeta : ITheTimeMachineMeta
    {
        ITheTimeMachineRepository theTimeMachineRepository;

        public TheTimeMachineMeta(ITheTimeMachineRepository theTimeMachineRepository)
        {
            this.theTimeMachineRepository = theTimeMachineRepository;
        }

        public List<TheTimeMachineEntity> GetEntityList()
        {
            return theTimeMachineRepository.GetEntityList();
        }

        public void Refresh()
        {
            //throw new NotImplementedException();
        }
    }
}
