using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUser2Service
    {
        List<OperationClaim> GetClaims(User2 user);
        void Add(User2 user);
        User2 GetByMail(string email);
    }
}
