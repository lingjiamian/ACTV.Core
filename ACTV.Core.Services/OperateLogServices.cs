using ACTV.Core.IRepository.Base;
using ACTV.Core.IServices;
using ACTV.Core.Model.Models;
using ACTV.Core.Services.BASE;

namespace ACTV.Core.Services
{
    public partial class OperateLogServices : BaseServices<OperateLog>, IOperateLogServices
    {
        IBaseRepository<OperateLog> _dal;
        public OperateLogServices(IBaseRepository<OperateLog> dal)
        {
            this._dal = dal;
            base.BaseDal = dal;
        }

    }
}
