using AutoMapper;
using ACTV.Core.Model.Models;
using ACTV.Core.Model.ViewModels;

namespace ACTV.Core.AutoMapper
{
    public class CustomProfile : Profile
    {
        /// <summary>
        /// 配置构造函数，用来创建关系映射
        /// </summary>
        public CustomProfile()
        {
            CreateMap<BlogArticle, BlogViewModels>();
            CreateMap<BlogViewModels, BlogArticle>();
            CreateMap<Bangumi, BangumiViewModels>();
            CreateMap<BangumiViewModels, Bangumi>();
        }
    }
}
