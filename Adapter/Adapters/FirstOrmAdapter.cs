using Adapter.Clients;
using Adapter.FirstOrmLibrary;
using Adapter.Models;

namespace Adapter.Adapters
{
    public class FirstOrmAdapter : IOrmAdapter
    {
        private readonly IFirstOrm<DbUserEntity> _firstOrm1;
        private readonly IFirstOrm<DbUserInfoEntity> _firstOrm2;

        public FirstOrmAdapter(IFirstOrm<DbUserEntity> firstOrm1, IFirstOrm<DbUserInfoEntity> firstOrm2)
        {
            _firstOrm1 = firstOrm1;
            _firstOrm2 = firstOrm2;
        }

        public DbUserEntity GetUserById(int id)
        {
            return _firstOrm1.Read(id);
        }

        public void AddUser(DbUserEntity user)
        {
            _firstOrm1.Add(user);
        }

        public void RemoveUserById(int id)
        {
            _firstOrm1.Read(id);
        }

        public DbUserInfoEntity GetUserInfoById(int id)
        {
            return _firstOrm2.Read(id);
        }

        public void AddUserInfo(DbUserInfoEntity userInfo)
        {
            _firstOrm2.Add(userInfo);
        }

        public void RemoveUserInfoById(int id)
        {
            _firstOrm2.Read(id);
        }
    }
}