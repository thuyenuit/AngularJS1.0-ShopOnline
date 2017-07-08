using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.DataProtection;
using Owin;
using ShopOnline.Data;
using ShopOnline.Data.Infrastructure.Implements;
using ShopOnline.Data.Infrastructure.Interfaces;
using ShopOnline.Data.Repositories;
using ShopOnline.Model.Model;
using ShopOnline.Service.Services;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

[assembly: OwinStartupAttribute(typeof(ShopOnline.Web.Startup))]
namespace ShopOnline.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            ConfigAutofac(app);
        }

        public void ConfigAutofac(IAppBuilder app)
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            // register web api controller
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();
            builder.RegisterType<DbFactory>().As<IDbFactory>().InstancePerRequest();

            builder.RegisterType<ShopOnlineDbcontext>().AsSelf().InstancePerRequest();

            // ASP.NET Identity
            builder.RegisterType<ApplicationUserStore>().As<IUserStore<ApplicationUser>>().InstancePerRequest();
            builder.RegisterType<ApplicationUserManager>().AsSelf().InstancePerRequest();
            builder.RegisterType<ApplicationSignInManager>().AsSelf().InstancePerRequest();
            builder.Register(x => HttpContext.Current.GetOwinContext().Authentication).InstancePerRequest();
            builder.Register(x => app.GetDataProtectionProvider()).InstancePerRequest();

            // repository
            builder.RegisterAssemblyTypes(typeof(ProductRepository).Assembly)
                .Where(x => x.Name.EndsWith("Repository")).AsImplementedInterfaces().InstancePerRequest();
            builder.RegisterAssemblyTypes(typeof(ProductCategoryRepository).Assembly)
               .Where(x => x.Name.EndsWith("Repository")).AsImplementedInterfaces().InstancePerRequest();

            // service
            builder.RegisterAssemblyTypes(typeof(ProductService).Assembly)
                .Where(x => x.Name.EndsWith("Service")).AsImplementedInterfaces().InstancePerRequest();
            builder.RegisterAssemblyTypes(typeof(ProductCategoryService).Assembly)
                .Where(x => x.Name.EndsWith("Service")).AsImplementedInterfaces().InstancePerRequest();


            Autofac.IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver((IContainer)container);

        }
    }
}
