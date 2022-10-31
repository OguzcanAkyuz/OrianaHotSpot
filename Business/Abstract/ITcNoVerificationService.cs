using Castle.Core.Resource;
using Core.Utilities.Results;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ITcNoVerificationService
    {
        IDataResult<List<TcNoVerification>> GetAll();
        IDataResult<TcNoVerification> GetByPeople(string id);
        IResult Add(TcNoVerification tcNoVerification);
        IResult Update(TcNoVerification tcNoVerification);
        IResult Delete(string id);


    }
}
