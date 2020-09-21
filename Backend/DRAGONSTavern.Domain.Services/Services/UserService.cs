using DRAGONSTavern.Domain.Core.Interfaces.Repositories;
using DRAGONSTavern.Domain.Core.Interfaces.Services;
using DRAGONSTavern.Domain.Entities;
using DRAGONSTavern.Domain.Helpers.Validator;
using System;

namespace DRAGONSTavern.Domain.Services.Services
{
    public class UserService : BaseService<User>, IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository, Validator<User> validator) : base(userRepository, validator) => _userRepository = userRepository;

        public override void Add(User obj)
        {
            try
            {
                var user = _userRepository.GetByEmail(obj.Email);

                switch (user)
                {
                    case null: _userRepository.Add(obj); break;
                    default: throw new Exception("This email already exists.");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public User GetByEmail(string email)
        {
            try
            {
                var user = _userRepository.GetByEmail(email);

                return user switch
                {
                    null => throw new Exception("This Email is invalid."),
                    _ => user,
                };
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
