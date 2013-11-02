using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Duudelides;
using Duudelides.Repositories;


namespace Duudelides.Framework
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public class TransactionAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.HttpContext.Items[BaseRepository.DbContext] = new DoodelDBEntities();

            base.OnActionExecuting(filterContext);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            var context = filterContext.HttpContext.Items[BaseRepository.DbContext] as DoodelDBEntities;
            if (context != null)
            {
                context.Dispose();
            }

            filterContext.HttpContext.Items[BaseRepository.DbContext] = null;

            base.OnResultExecuted(filterContext);
        }

    }
}