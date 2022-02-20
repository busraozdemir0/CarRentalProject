using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IUser2Dal:IEntityRepository<User2>
    {
        List<OperationClaim> GetClaims(User2 user);
    }
}
