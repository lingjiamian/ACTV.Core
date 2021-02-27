using ACTV.Core.IServices.BASE;
using ACTV.Core.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTV.Core.IServices
{
    public interface IDanmakuServices:IBaseServices<Danmaku>
    {
        Task<Danmaku> QueryById(int Id)
    }
}
