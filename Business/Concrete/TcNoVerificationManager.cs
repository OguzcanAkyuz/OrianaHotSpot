using Business.Abstract;
using Business.Constans;
using Castle.Core.Resource;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;


namespace Business.Concrete
{
    public class TcNoVerificationManager : ITcNoVerificationService
    {
        private readonly ITcNoVerificationDal _tcNoVerificationDal;

        public TcNoVerificationManager(ITcNoVerificationDal tcNoVerificationDal)
        {
             _tcNoVerificationDal= tcNoVerificationDal;
        }


        public IResult Add(TcNoVerification tcNoVerification)
        {
            _tcNoVerificationDal.Add(tcNoVerification);
            return new SuccessResult(Messages.NewPeopleAdd);
        }

        public IResult Delete(string id)
        {
            var tcPeople = _tcNoVerificationDal.Get(t => t.Id == id);
            _tcNoVerificationDal.Delete(tcPeople);
            return new SuccessDataResult<List<TcNoVerification>>(Messages.Deleted);
        }

        public IDataResult<List<TcNoVerification>> GetAll()
        {
            return new SuccessDataResult<List<TcNoVerification>>(_tcNoVerificationDal.GetAll(), Messages.PeopleList);
        }

        public IDataResult<TcNoVerification> GetByPeople(string id)
        {
            return new SuccessDataResult<TcNoVerification>(_tcNoVerificationDal.Get(t => t.Id == id));
        }

        public IResult Update(TcNoVerification tcNoVerification)
        {
           _tcNoVerificationDal.Update(tcNoVerification);
            return new SuccessDataResult<List<TcNoVerification>> (Messages.Update);
        }

      
    }
}
