using ACTV.Core.IRepository.Base;
using ACTV.Core.IServices;
using ACTV.Core.Model.Models;
using ACTV.Core.Services.BASE;

namespace ACTV.Core.Services
{
    public partial class PasswordLibServices : BaseServices<PasswordLib>, IPasswordLibServices
    {
        IBaseRepository<PasswordLib> _dal;
        public PasswordLibServices(IBaseRepository<PasswordLib> dal)
        {
            this._dal = dal;
            base.BaseDal = dal;
        }

    }
}
