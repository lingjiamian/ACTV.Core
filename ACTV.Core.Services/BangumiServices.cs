using ACTV.Core.IRepository.Base;
using ACTV.Core.IServices;
using ACTV.Core.Model.Models;
using ACTV.Core.Model.ViewModels;
using ACTV.Core.Services.BASE;
using AutoMapper;
using System.Linq;
using System.Threading.Tasks;

namespace ACTV.Core.Services
{
    public class BangumiServices : BaseServices<Bangumi>, IBangumiServices
    {
        IBaseRepository<Bangumi> _dal;
        IMapper _mapper;

        public BangumiServices(IBaseRepository<Bangumi> baseRepository, IMapper mapper)
        {
            base.BaseDal = baseRepository;
            this._dal = baseRepository;
            this._mapper = mapper;
        }

        public async Task<BangumiViewModels> GetBangumiDetails(int Id)
        {
            var bangumiDetails = (await base.Query(b => b.Id == Id)).FirstOrDefault();

            BangumiViewModels bangumiViewModels = null;

            if(bangumiDetails != null)
            {
                bangumiViewModels = _mapper.Map<BangumiViewModels>(bangumiDetails);
                //var s = bangumiViewModels.createTime.GetDateTimeFormats("yyyy/MM/dd");
                //var s = bangumiViewModels.createTime.ToShortDateString();
                //DateTime dd = DateTime.Parse(s);
                //bangumiViewModels.createTime = DateTime.Parse(bangumiViewModels.createTime.ToString("yyyy/MM/dd"));

                //TODO: 获取视频评论
            }

            return bangumiViewModels;
        }
    }
}
