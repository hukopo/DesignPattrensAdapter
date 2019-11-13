using System;
using Adapter.Models.Interfaces;

namespace Adapter.Models
{
    public class DbUserInfoEntity : IDbEntity
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public int Id { get; set; }
    }
}