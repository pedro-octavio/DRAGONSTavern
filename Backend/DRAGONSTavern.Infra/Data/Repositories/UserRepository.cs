using DRAGONSTavern.Domain.Core.Interfaces.Repositories;
using DRAGONSTavern.Domain.Entities;
using System;
using System.Linq;

namespace DRAGONSTavern.Infra.Data.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private readonly DataContext _dataContext;

        public UserRepository(DataContext dataContext) : base(dataContext) => _dataContext = dataContext;

        public User GetByEmail(string email)
        {
            try
            {
                return _dataContext.Users.Where(x => x.Email == email).FirstOrDefault();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
