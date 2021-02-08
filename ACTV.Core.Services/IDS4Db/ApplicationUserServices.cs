using ACTV.Core.IRepository.Base;
using ACTV.Core.Model.IDS4DbModels;
using ACTV.Core.Services.BASE;

namespace ACTV.Core.IServices
{
    public class ApplicationUserServices : BaseServices<ApplicationUser>, IApplicationUserServices
    {

        IBaseRepository<ApplicationUser> _dal;
        public ApplicationUserServices(IBaseRepository<ApplicationUser> dal)
        {
            this._dal = dal;
            base.BaseDal = dal;
        }

    }
}