using Core.DataAccess.Databases.MongoDB;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.Databases.MongoDB;
using DataAccess.Concrete.MongoDB.Collections;

namespace DataAccess.Concrete.MongoDB
{
    public class MongoDB_OperationClaimsDal : MongoDB_RepositoryBase<OperationClaim, MongoDB_Context<OperationClaim, MongoDB_OperationClaimsCollection>>, IOperationClaimDal
    {

    }
}