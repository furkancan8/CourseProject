using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrate;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrate.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependecnyResoivers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

            builder.RegisterType<UserOperationClaimManager>().As<IUserOperationClaimService>();
            builder.RegisterType<EfUserOperationClaimDal>().As<IUserOperationClaimDal>();

            builder.RegisterType<CourseManager>().As<ICourseService>();
            builder.RegisterType<EfCourseDal>().As<ICourseDal>();

            builder.RegisterType<PaymentManager>().As<IPaymentService>();
            builder.RegisterType<EfPaymentDal>().As<IPaymentDal>();


            builder.RegisterType<CourseUserManager>().As<ICourseUserService>();
            builder.RegisterType<EfCourseUserDal>().As<ICourseUserDal>();
            builder.RegisterType<UserContactManager>().As<IUserContactService>();
            builder.RegisterType<EfUserContactDal>().As<IUserContactDal>();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
