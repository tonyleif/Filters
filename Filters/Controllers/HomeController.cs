﻿using System;
using System.Web.Mvc;
using Filters.Infrastructure;
using System.Diagnostics;

namespace Filters.Controllers
{
    public class HomeController : Controller
    {
        //private Stopwatch timer;

        //[CustomAuth(true)]
        [Authorize(Users = "admin")]
        public string Index()
        {
            return "This is the Index action on the Home controller";
        }

        [GoogleAuth]
        [Authorize(Users = "bob@google.com")]
        public string List()
        {
            return "This is the List action on the Home controller";
        }

        //[RangeException]
        [HandleError(ExceptionType = typeof(ArgumentOutOfRangeException), View = "RangeError")]
        public string RangeTest(int id)
        {
            if (id > 100)
            {
                return String.Format("The id value is: {0}", id);
            }
            else
            {
                throw new ArgumentOutOfRangeException("id", id, "");
            }
        }

        //[CustomAction]
        [ProfileAction]
        [ProFileResult]
        [ProfileAll]
        public string FilterTest()
        {
            return "This is the FilterTest action";
        }

        //protected override void OnActionExecuting(ActionExecutingContext filterContext)
        //{
        //    timer = Stopwatch.StartNew();
        //}
        //protected override void OnResultExecuted(ResultExecutedContext filterContext)
        //{
        //    timer.Stop();
        //    filterContext.HttpContext.Response.Write(
        //    string.Format("<div>Total elapsed time: {0}</div>",
        //    timer.Elapsed.TotalSeconds));
        //}
    }
}