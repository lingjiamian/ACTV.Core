using ACTV.Core.IRepository.Base;
using ACTV.Core.IServices;
using ACTV.Core.Model.Models;
using ACTV.Core.Services.BASE;

namespace ACTV.Core.Services
{
    /// <summary>
    /// ModuleServices
    /// </summary>	
    public class ModuleServices : BaseServices<Modules>, IModuleServices
    {

        IBaseRepository<Modules> _dal;
        public ModuleServices(IBaseRepository<Modules> dal)
        {
            this._dal = dal;
            base.BaseDal = dal;
        }
       
    }
}
