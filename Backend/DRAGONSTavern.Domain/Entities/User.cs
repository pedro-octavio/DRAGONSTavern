using DRAGONSTavern.Domain.ValueObjects;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace DRAGONSTavern.Domain.Entities
{
    public class User : Shared
    {
        [JsonConstructor]
        public User(string email, string password, string id) : base(id)
        {
            Email = email;
            Password = password;
        }

        [Required]
        [MaxLength(50)]
        public string Email { get; private set; }
        [Required]
        [MaxLength(200)]
        public string Password { get; private set; }
    }
}
