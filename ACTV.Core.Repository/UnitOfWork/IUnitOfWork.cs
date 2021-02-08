using SqlSugar;

namespace ACTV.Core.IRepository.UnitOfWork
{
    public interface IUnitOfWork
    {
        SqlSugarClient GetDbClient();

        void BeginTran();

        void CommitTran();
        void RollbackTran();
    }
}
