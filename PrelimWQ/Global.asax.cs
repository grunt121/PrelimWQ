using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Configuration; //Need for migrations
using System.Data.Entity.Migrations; //Need for migrations

namespace PrelimWQ
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);


            if (bool.Parse(ConfigurationManager.AppSettings["MigrateDatabaseToLatestVersion"]))
            {
                // Run the code first migrations
                var trialConfiguration = new Migrations.Configuration();
                var trialMigrator = new DbMigrator(trialConfiguration);
                trialMigrator.Update();
            }

        }
    }
}
