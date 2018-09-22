using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;

using SavoryTripManage.Controllers;
using SavoryTripManage.Convertor;
using SavoryTripManage.Repository;
using SavoryTripManage.Repository.Sqlite;
using SavoryTripManage.Meta;

namespace SavoryTripManage
{
    public class AutofacConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //asp.net mvc
            {
                var builder = new ContainerBuilder();
                builder.RegisterControllers(typeof(MvcApplication).Assembly);

                DependencyResolver.SetResolver(new AutofacDependencyResolver(builder.Build()));
            }

            //asp.net webapi
            {
                var builder = new ContainerBuilder();
                builder.RegisterApiControllers(typeof(MvcApplication).Assembly);
                builder.RegisterType<SqliteConnectionProvider>();

                builder.RegisterType<SqlitePlaceRepository>().As<IPlaceRepository>().SingleInstance();
                builder.RegisterType<SqliteMetaTimeMachineRepository>().As<IMetaTimeMachineRepository>().SingleInstance();

                builder.RegisterType<SqliteTheTimeMachineRepository>().As<ITheTimeMachineRepository>().SingleInstance();

                builder.RegisterType<PlaceConvertor>().As<IPlaceConvertor>().SingleInstance();
                builder.RegisterType<MetaTimeMachineConvertor>().As<IMetaTimeMachineConvertor>().SingleInstance();

                builder.RegisterType<TheTimeMachineConvertor>().As<ITheTimeMachineConvertor>().SingleInstance();

                builder.RegisterType<TheTimeMachineMeta>().As<ITheTimeMachineMeta>().SingleInstance();

                config.DependencyResolver = new AutofacWebApiDependencyResolver(builder.Build());
            }
        }
    }
}