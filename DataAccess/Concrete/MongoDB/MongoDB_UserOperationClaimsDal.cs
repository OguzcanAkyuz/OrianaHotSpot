using Core.DataAccess.Databases.MongoDB;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.Databases.MongoDB;
using DataAccess.Concrete.MongoDB.Collections;

namespace DataAccess.Concrete.MongoDB
{
    public class MongoDB_UserOperationClaimsDal : MongoDB_RepositoryBase<UserOperationClaim, MongoDB_Context<UserOperationClaim, MongoDB_UserOperationClaimsCollection>>, IUserOperationClaimDal
    {

    }
}