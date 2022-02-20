using Business.Abstract;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class User2Manager : IUser2Service
    {
        IUser2Dal _user2Dal;

        public User2Manager(IUser2Dal user2Dal)
        {
            _user2Dal = user2Dal;
        }

        public void Add(User2 user)
        {
            _user2Dal.Add(user);
        }

        public User2 GetByMail(string email)
        {
            return _user2Dal.Get(u => u.Email == email);
        }

        public List<OperationClaim> GetClaims(User2 user)
        {
            return _user2Dal.GetClaims(user);
        }
    }
}
