using DRAGONSTavern.Domain.Entities;

namespace DRAGONSTavern.Domain.Core.Interfaces.Services
{
    public interface IUserService : IBaseService<User>
    {
        User GetByEmail(string email);
    }
}
