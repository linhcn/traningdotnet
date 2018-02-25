using AspNetDemo.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;


namespace AspNetDemo
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {

            //set trinh khoi tao, database se bị xoa va tao lai moi khi chay ung dung (*khong nen dung)
            //Database.SetInitializer<StudentContext>(new DropCreateDatabaseIfModelChanges<StudentContext>());

            Database.SetInitializer<StudentContext>(new StudentInitilizer());

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
