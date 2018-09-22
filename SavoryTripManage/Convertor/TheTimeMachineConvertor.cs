using SavoryTripManage.Controllers.Request;
using SavoryTripManage.Repository.Entity;
using SavoryTripManage.Vo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SavoryTripManage.Convertor
{
    public class TheTimeMachineConvertor : ITheTimeMachineConvertor
    {
        public TheTimeMachineVo toVo(TheTimeMachineEntity entity)
        {
            TheTimeMachineVo vo = new TheTimeMachineVo();

            vo.TimeMachineId = entity.TimeMachineId;
            vo.TimeMachineName = entity.TimeMachineName;

            return vo;
        }

        public List<TheTimeMachineVo> getVoList(List<TheTimeMachineEntity> entityList)
        {
            if (entityList == null || entityList.Count == 0) {
                return null;
            }

            List<TheTimeMachineVo> voList = new List<TheTimeMachineVo>();
            foreach (TheTimeMachineEntity entity in entityList)
            {

                TheTimeMachineVo vo = toVo(entity);
                voList.Add(vo);
            }

            return voList;
        }

        public List<TheTimeMachineVo> getLessVoList(List<TheTimeMachineEntity> entityList, int key)
        {
            if (entityList == null || entityList.Count == 0) {
                return null;
            }

            foreach (TheTimeMachineEntity entity in entityList)
            {
                if (entity.TimeMachineId == key)
                {
                    return new List<TheTimeMachineVo> { toVo(entity) };
                }
            }

            return null;
        }

        public List<TheTimeMachineVo> getMoreVoList(List<TheTimeMachineEntity> entityList, int key)
        {
            if (entityList == null || entityList.Count == 0)
            {
                return null;
            }

            List<TheTimeMachineVo> voList = new List<TheTimeMachineVo>();
            foreach (TheTimeMachineEntity entity in entityList)
            {
                TheTimeMachineVo vo = toVo(entity);
                voList.Add(vo);

                if (entity.TimeMachineId == key)
                {
                    vo.Selected = true;
                }
            }

            return voList;
        }

        public List<TheTimeMachineVo> getLessVoList(List<TheTimeMachineEntity> entityList, List<int> keys)
        {
            if (entityList == null || entityList.Count == 0)
            {
                return null;
            }

            List<TheTimeMachineVo> voList = new List<TheTimeMachineVo>();
            foreach (TheTimeMachineEntity entity in entityList)
            {
                if (!keys.Contains(entity.TimeMachineId))
                {
                    continue;
                }

                TheTimeMachineVo vo = toVo(entity);
                vo.Selected = true;
                voList.Add(vo);

                if(voList.Count == keys.Count)
                {
                    break;
                }
            }

            return voList;
        }

        public List<TheTimeMachineVo> getMoreVoList(List<TheTimeMachineEntity> entityList, List<int> keys)
        {
            if (entityList == null || entityList.Count == 0)
            {
                return null;
            }

            List<TheTimeMachineVo> voList = new List<TheTimeMachineVo>();
            foreach (TheTimeMachineEntity entity in entityList)
            {
                TheTimeMachineVo vo = toVo(entity);
                if (keys.Contains(entity.TimeMachineId))
                {
                    vo.Selected = true;
                }
                voList.Add(vo);
            }

            return voList;
        }
    }
}
