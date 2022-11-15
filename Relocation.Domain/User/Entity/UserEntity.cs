using Relocation.Domain.Shared;

namespace Relocation.Domain.User.Entity
{
    public class UserEntity : BaseEntity
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}