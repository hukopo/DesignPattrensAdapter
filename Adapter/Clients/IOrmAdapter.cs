using Adapter.Models;

namespace Adapter.Clients
{
    public interface IOrmAdapter // ITarget
    {
        DbUserEntity GetUserById(int id);
        void AddUser(DbUserEntity user);
        void RemoveUserById(int id);
        
        DbUserInfoEntity GetUserInfoById(int id);
        void AddUserInfo(DbUserInfoEntity userInfo);
        void RemoveUserInfoById(int id);
    }
}