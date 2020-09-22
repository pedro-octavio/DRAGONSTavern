using DRAGONSTavern.Domain.Entities;

namespace DRAGONSTavern.Domain.Core.Interfaces.Services
{
    public interface ITokenService
    {
        string GenerateToken(User user);
    }
}
