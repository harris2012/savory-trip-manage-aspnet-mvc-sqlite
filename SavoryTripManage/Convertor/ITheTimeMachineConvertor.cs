using SavoryTripManage.Controllers.Request;
using SavoryTripManage.Repository.Entity;
using SavoryTripManage.Vo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SavoryTripManage.Convertor
{
    public interface ITheTimeMachineConvertor
    {

        /// <summary>
        /// entity 转换为 vo
        /// </summary>
        TheTimeMachineVo toVo(TheTimeMachineEntity entity);

        /// <summary>
        /// 获取所有的选项
        /// </summary>
        List<TheTimeMachineVo> getVoList(List<TheTimeMachineEntity> entityList);

        /// <summary>
        /// 获取被标记为已经选择的。
        /// </summary>
        List<TheTimeMachineVo> getLessVoList(List<TheTimeMachineEntity> entityList, int key);

        /// <summary>
        /// 获取所有的元数据。标记已经选择的。
        /// </summary>
        List<TheTimeMachineVo> getMoreVoList(List<TheTimeMachineEntity> entityList, int key);

        /// <summary>
        /// 获取被标记为已经选择的。
        /// </summary>
        List<TheTimeMachineVo> getLessVoList(List<TheTimeMachineEntity> entityList, List<int> keys);

        /// <summary>
        /// 获取所有的元数据。标记已经选择的。
        /// </summary>
        List<TheTimeMachineVo> getMoreVoList(List<TheTimeMachineEntity> entityList, List<int> keys);

    }
}
