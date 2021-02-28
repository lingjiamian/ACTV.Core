using ACTV.Core.IRepository.Base;
using ACTV.Core.IServices;
using ACTV.Core.Model.Models;
using ACTV.Core.Model.ViewModels;
using ACTV.Core.Services.BASE;
using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ACTV.Core.Services
{
    public class DanmakuServices : BaseServices<Danmaku>, IDanmakuServices
    {
        IBaseRepository<Danmaku> baseRepository;
        IMapper mapper;

        public DanmakuServices(IBaseRepository<Danmaku> baseRepository, IMapper mapper)
        {
            base.BaseDal = baseRepository;
            this.baseRepository = baseRepository;
            this.mapper = mapper;
        }

        //public Task<List<DanmakuViewModels>> QueryByBangumiIdToList(int Id)
        //{
        //    throw new System.NotImplementedException();
        //}


        public async Task<List<DanmakuViewModels>> QueryByBangumiIdToList(int Id)
        {

            var danmakuList = await baseRepository.Query(danmaku => danmaku.BangumiId == Id);
            var danmakuViewModelsList = new List<DanmakuViewModels>();
            if (danmakuList != null)
            {
                danmakuViewModelsList = mapper.Map<List<DanmakuViewModels>>(danmakuList);
            }

            return danmakuViewModelsList;
        }
    }
}
