using Autofac;
using Business.Abstract;
using Business.Adapters.SmsService;
using Business.Concrete;
using Core.CrossCuttingConcerns.EMailService;
using Core.Utilities.Security.Jwt;
using DataAccess.Abstract;
using DataAccess.Concrete.MongoDB;
using Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Business.DependencyRevolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<TcNoVerificationManager>().As<ITcNoVerificationService>().SingleInstance();
            builder.RegisterType<AuthManager>().As<IAuthService>().SingleInstance();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>().SingleInstance();
            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();

           
            //   ***********************************************************************************************
            builder.RegisterType<EMailManager>().As<IEMailManager>().SingleInstance();
            builder.RegisterType<MongoDB_TcNoVerificationDal>().As<ITcNoVerificationDal>().SingleInstance();
            builder.RegisterType<MongoDB_UserDal>().As<IUserDal>().SingleInstance();
            builder.RegisterType<MongoDB_UserOperationClaimsDal>().As<IUserOperationClaimDal>().SingleInstance();
            builder.RegisterType<MongoDB_OperationClaimsDal>().As<IOperationClaimDal>().SingleInstance();
        }
    }
}
