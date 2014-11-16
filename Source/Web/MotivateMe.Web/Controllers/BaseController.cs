﻿namespace MotivateMe.Web.Controllers
{
    using MotivateMe.Data;
    using MotivateMe.Data.Models;

    using Microsoft.AspNet.Identity;

    using System;
    using System.Web.Mvc;
    using System.Web.Routing;

    public abstract class BaseController : Controller
    {
        protected IMotivateMeData Data { get; private set; }

        protected ApplicationUser CurrentUser { get; set; }

        public BaseController(IMotivateMeData data)
        {
            this.Data = data;
        }

        protected override IAsyncResult BeginExecute(RequestContext requestContext, AsyncCallback callback, object state)
        {
            this.CurrentUser = this.Data.Users.GetById(this.User.Identity.GetUserId());

            return base.BeginExecute(requestContext, callback, state);
        }
    }
}