using ACTV.Core.IServices.BASE;
using ACTV.Core.Model.Models;
using ACTV.Core.Model.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ACTV.Core.IServices
{
    public interface IBlogArticleServices :IBaseServices<BlogArticle>
    {
        Task<List<BlogArticle>> GetBlogs();
        Task<BlogViewModels> GetBlogDetails(int id);

    }

}
