using ACTV.Core.IServices.BASE;
using ACTV.Core.Model.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ACTV.Core.IServices
{
    public interface ITopicServices : IBaseServices<Topic>
    {
        Task<List<Topic>> GetTopics();
    }
}
