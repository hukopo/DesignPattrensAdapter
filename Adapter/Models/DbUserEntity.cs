using Adapter.Models.Interfaces;

namespace Adapter.Models
{
    public class DbUserEntity : IDbEntity
    {
        public string Login { get; set; }
        public string PasswordHash { get; set; }
        public int InfoId { get; set; }
        public int Id { get; set; }
    }
}