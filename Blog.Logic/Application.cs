using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using Umbraco.Core;
using Umbraco.Core.Models;
using Umbraco.Core.Services;
using Umbraco.Web;

namespace Bit10.LawrenceSheriff.Logic
{
    public class Application : IApplicationEventHandler
    {
        public void OnApplicationInitialized(UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
        {
        }

        public void OnApplicationStarted(UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
        {
            var builder = new ContainerBuilder();

            // Register umbraco context, mvc controllers and api controllers
            builder.Register(c => UmbracoContext.Current).AsSelf();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterApiControllers(typeof(UmbracoApplication).Assembly);
            //builder.RegisterApiControllers(typeof(Umbraco.Forms.Web.Trees.FormTreeController).Assembly);
            builder.RegisterApiControllers(typeof(Application).Assembly);
            builder.RegisterApiControllers(typeof(Lecoati.LeBlender.Extension.Helper).Assembly);

            var logic = typeof(Application).Assembly;

            builder.RegisterAssemblyTypes(logic)
                   .Where(t => t.Name.EndsWith("Service"))
                   .AsImplementedInterfaces();
            //builder.RegisterType<Services.EmailService>().As<Domain.Services.IRegistrationEmailService>();

            builder.RegisterInstance(applicationContext.Services.MemberService).As<IMemberService>();
            builder.RegisterInstance(applicationContext.Services.RelationService).As<IRelationService>();

            var container = builder.Build();
            var resolver = new AutofacWebApiDependencyResolver(container);
            GlobalConfiguration.Configuration.DependencyResolver = resolver;
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

        }

        public void OnApplicationStarting(UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
        {
        }
    }
}
