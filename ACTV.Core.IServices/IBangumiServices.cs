using ACTV.Core.IServices.BASE;
using ACTV.Core.Model.Models;
using ACTV.Core.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTV.Core.IServices
{
    public interface IBangumiServices:IBaseServices<Bangumi>
    {
        Task<BangumiViewModels> GetBangumiDetails(int Id);
    }
}
