using ACTV.Core.IServices.BASE;
using ACTV.Core.Model.Models;
using ACTV.Core.Model.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ACTV.Core.IServices
{
    public interface IDanmakuServices:IBaseServices<Danmaku>
    {
        /// <summary>
        /// 根据视频Id获取弹幕
        /// </summary>
        /// <param name="Id">视频Id</param>
        /// <returns></returns>
        Task<List<DanmakuViewModels>> QueryByBangumiIdToList(int Id);
    }
}
