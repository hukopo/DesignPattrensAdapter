using System;
using Adapter.Clients;
using Adapter.Models;
using Adapter.SecondOrmLibrary;

namespace Adapter.Adapters
{
    public class SecondOrmAdapter : IOrmAdapter
    {
        private readonly ISecondOrm _secondOrm;

        public SecondOrmAdapter(ISecondOrm secondOrm)
        {
            _secondOrm = secondOrm;
        }

        public DbUserEntity GetUserById(int id)
        {
            return SecondAdapterHelper<DbUserEntity>.Get(id, _secondOrm.Context.Users);
        }

        public void AddUser(DbUserEntity user)
        {
            SecondAdapterHelper<DbUserEntity>.Add(user, _secondOrm.Context.Users);
        }

        public void RemoveUserById(int id)
        {
            SecondAdapterHelper<DbUserEntity>.Remove(id, _secondOrm.Context.Users);
        }

        public DbUserInfoEntity GetUserInfoById(int id)
        {
            return SecondAdapterHelper<DbUserInfoEntity>.Get(id, _secondOrm.Context.UserInfos);
        }

        public void AddUserInfo(DbUserInfoEntity userInfo)
        {
            SecondAdapterHelper<DbUserInfoEntity>.Add(userInfo, _secondOrm.Context.UserInfos);
        }

        public void RemoveUserInfoById(int id)
        {
            SecondAdapterHelper<DbUserInfoEntity>.Remove(id, _secondOrm.Context.UserInfos);
        }
    }
}