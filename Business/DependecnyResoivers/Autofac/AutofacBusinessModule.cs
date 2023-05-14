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

            builder.RegisterType<CourseManager>().As<ICourseService>();
            builder.RegisterType<EfCourseDal>().As<ICourseDal>();

            builder.RegisterType<CourseVideoManager>().As<ICourseVideoService>();
            builder.RegisterType<EfCourseVideoDal>().As<ICourseVideoDal>();

            builder.RegisterType<VideoDetailsManager>().As<IVideoDetailsService>();
            builder.RegisterType<EfVideoDetailsDal>().As<IVideoDetailsDal>();

            builder.RegisterType<CategoryManager>().As<ICategoryService>();
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>();

            builder.RegisterType<CommentManager>().As<ICommentService>();
            builder.RegisterType<EfCommentDal>().As<ICommentDal>();

            builder.RegisterType<PaymentManager>().As<IPaymentService>();
            builder.RegisterType<EfPaymentDal>().As<IPaymentDal>();

            builder.RegisterType<TeacherManager>().As<ITeacherService>();
            builder.RegisterType<EfTeacherDal>().As<ITeacherDal>();

            builder.RegisterType<TeacherCourseManager>().As<ITeacherCourseService>();
            builder.RegisterType<EfTeacherCourseDal>().As<ITeacherCourseDal>();

            builder.RegisterType<SupportContactManager>().As<ISupportContactService>();
            builder.RegisterType<EfSupportContactDal>().As<ISupportContactDal>();

            builder.RegisterType<SoldCourseManager>().As<ISoldCourseService>();
            builder.RegisterType<EfSoldCourseDal>().As<ISoldCourseDal>();

            builder.RegisterType<TeacherStudentContactManager>().As<ITeacherStudentContactService>();
            builder.RegisterType<EfTeacherStudentContactDal>().As<ITeacherStudentContactDal>();

            builder.RegisterType<TeacherStudentManager>().As<ITeacherStudentService>();
            builder.RegisterType<EfTeacherStudentDal>().As<ITeacherStudentDal>();

            builder.RegisterType<CourseUserManager>().As<ICourseUserService>();
            builder.RegisterType<EfCourseUserDal>().As<ICourseUserDal>();

            builder.RegisterType<UserContactManager>().As<IUserContactService>();
            builder.RegisterType<EfUserContactDal>().As<IUserContactDal>();

            builder.RegisterType<UserVerifyManager>().As<IUserVerifyService>(
                );
            builder.RegisterType<EfUserVerifyDal>().As<IUserVerifyDal>();
            builder.RegisterType<UserOperationClaimManager>().As<IUserOperationClaimService>();
            builder.RegisterType<EfUserOperationClaimDal>().As<IUserOperationClaimDal>();

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
