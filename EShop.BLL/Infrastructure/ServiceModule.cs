using System;
using System.Collections.Generic;
using System.Text;
using EShop.DAL.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Ninject.Modules;

namespace EShop.BLL.Infrastructure {
    //public class ServiceModule : NinjectModule {
    //    private static string con = "postgres://xhhlwrhoymkdmw:24947730f2ed238645449cc4acccc94653b7eaf335cbd3479bbd734b58ce104a@ec2-46-137-113-157.eu-west-1.compute.amazonaws.com:5432/d5s1tuq7s7la7u";
    //    private static PostgreSqlConnectionStringBuilder builder = new PostgreSqlConnectionStringBuilder(con) {
    //        Pooling = true,
    //        TrustServerCertificate = true,
    //        SslMode = SslMode.Require
    //    };
    //    public ServiceModule(PostgreSqlConnectionStringBuilder _builder) {
    //        builder = _builder;
    //    }
    //    public override void Load() {
    //        Bind<IUnitOfWork>().To<UnitOfWork>().WithConstructorArgument(builder);
    //    }
    //}
    public class ServiceModule {
        public ServiceModule(IServiceCollection services) {
            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}
