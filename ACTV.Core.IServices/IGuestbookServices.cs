using ACTV.Core.IServices.BASE;
using ACTV.Core.Model;
using ACTV.Core.Model.Models;
using System.Threading.Tasks;

namespace ACTV.Core.IServices
{
    public partial interface IGuestbookServices : IBaseServices<Guestbook>
    {
        Task<MessageModel<string>> TestTranInRepository();
        Task<bool> TestTranInRepositoryAOP();
    }
}
