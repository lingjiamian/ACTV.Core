using ACTV.Core.Services.BASE;
using ACTV.Core.Model.Models;
using ACTV.Core.IRepository;
using ACTV.Core.IServices;
using ACTV.Core.IRepository.Base;

namespace ACTV.Core.Services
{	
	/// <summary>
	/// ModulePermissionServices
	/// </summary>	
	public class ModulePermissionServices : BaseServices<ModulePermission>, IModulePermissionServices
    {

        IBaseRepository<ModulePermission> _dal;
        public ModulePermissionServices(IBaseRepository<ModulePermission> dal)
        {
            this._dal = dal;
            base.BaseDal = dal;
        }
       
    }
}
