    

using ACTV.Core.IServices.BASE;
using ACTV.Core.Model.Models;
using System.Threading.Tasks;

namespace ACTV.Core.IServices
{	
	/// <summary>
	/// sysUserInfoServices
	/// </summary>	
    public interface ISysUserInfoServices :IBaseServices<sysUserInfo>
	{
        Task<sysUserInfo> SaveUserInfo(string loginName, string loginPwd);
        Task<string> GetUserRoleNameStr(string loginName, string loginPwd);
    }
}
