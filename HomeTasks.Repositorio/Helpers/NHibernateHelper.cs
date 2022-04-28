using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Tool.hbm2ddl;
using NHibernate;
using NHibernate.Cfg;

namespace HomeTasks.Repositorio.Helpers
{
    public class NHibernateHelper
    {
        private static ISessionFactory _sessionFactory;

        private static ISessionFactory SessionFactory()
        {
            return SessionFactory(false);
        }

        private static ISessionFactory SessionFactory(bool createDatabase)
        {
            // Se a sessão já existir, retorná-la
            if (_sessionFactory != null && !createDatabase)
                return _sessionFactory;

            // Aqui o NHibernate vai procurar            // as configurações no 
            // arquivo "NHibernate.config"
            var config = new Configuration().Configure();
            // Criar DataBase
            if (createDatabase)
            {
                var schemaExport = new SchemaExport(config);
                schemaExport.Drop(false, true);
                schemaExport.Create(false, true);
            }

            _sessionFactory = config.BuildSessionFactory();

            return _sessionFactory;
        }

        public static ISession OpenSession()
        {
            return SessionFactory().OpenSession();
        }

        public static ISession OpenSession(bool createDatabase)
        {
            return SessionFactory(createDatabase).OpenSession();
        }

        public static string GetProperty(string name)
        {
            var config = new Configuration().Configure();

            return config.GetProperty(name);
        }
    }
}
