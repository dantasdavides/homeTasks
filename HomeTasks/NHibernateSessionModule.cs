using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using NHibernate.Context;
using HomeTasks.Repositorio.Helpers;


namespace HomeTasks
{
    public class NHibernateSessionModule : IHttpModule
    {
        public void Dispose()
        {
        }
        public void Init(HttpApplication context)
        {
            context.BeginRequest +=
                delegate
                {
                    SessionManager.Instance.OpenConversation();
                    //CurrentSessionContext.Bind(Odonto.Repositorio.Helpers.SessionManager.Instance.OpenSession());
                };
            context.EndRequest +=
                delegate
                {
                    SessionManager.Instance.EndConversation();
                    //CurrentSessionContext.Unbind(Odonto.Repositorio.Helpers.SessionManager.Instance);
                };
        }

    }
}
