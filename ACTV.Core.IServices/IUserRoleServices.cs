using ACTV.Core.IServices.BASE;
using ACTV.Core.Model.Models;
using System.Threading.Tasks;

namespace ACTV.Core.IServices
{	
	/// <summary>
	/// UserRoleServices
	/// </summary>	
    public interface IUserRoleServices :IBaseServices<UserRole>
	{

        Task<UserRole> SaveUserRole(int uid, int rid);
        Task<int> GetRoleIdByUid(int uid);
    }
}

