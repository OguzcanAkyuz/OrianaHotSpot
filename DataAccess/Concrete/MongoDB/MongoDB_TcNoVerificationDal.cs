using Core.DataAccess.Databases.MongoDB;
using DataAccess.Abstract;
using DataAccess.Concrete.Databases.MongoDB;
using DataAccess.Concrete.MongoDB.Collections;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.MongoDB
{
    public class MongoDB_TcNoVerificationDal : MongoDB_RepositoryBase<TcNoVerification,MongoDB_Context<TcNoVerification,MongoDB_TcNoVerificationCollection>>, ITcNoVerificationDal
    {

    }
}
