using DRAGONSTavern.Domain.Entities;

namespace DRAGONSTavern.Domain.Core.Interfaces.Repositories
{
    public interface IUserRepository : IBaseRepository<User>
    {
        User GetByEmail(string email);
    }
}
