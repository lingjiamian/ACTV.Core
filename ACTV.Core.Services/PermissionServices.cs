using ACTV.Core.IRepository.Base;
using ACTV.Core.IServices;
using ACTV.Core.Model.Models;
using ACTV.Core.Services.BASE;

namespace ACTV.Core.Services
{
    /// <summary>
    /// PermissionServices
    /// </summary>	
    public class PermissionServices : BaseServices<Permission>, IPermissionServices
    {

        IBaseRepository<Permission> _dal;
        public PermissionServices(IBaseRepository<Permission> dal)
        {
            this._dal = dal;
            base.BaseDal = dal;
        }
       
    }
}
