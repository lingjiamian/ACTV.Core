using ACTV.Core.IServices.BASE;
using ACTV.Core.Model.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ACTV.Core.IServices
{
    public interface ITopicDetailServices : IBaseServices<TopicDetail>
    {
        Task<List<TopicDetail>> GetTopicDetails();
    }
}
