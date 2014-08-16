using System.IO;
using Envoy.CustomRegistrar.Core.Models;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace Envoy.CustomRegistrar.Core.Repositories
{
    public class UserRepository : IUserRepository
    {
        public void Register(User user)
        {
            var sessionFactory = CreateSessionFactory();

            using (var session = sessionFactory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.SaveOrUpdate(user);
                }
            }
        }

        private static ISessionFactory CreateSessionFactory()
        {
            return Fluently.Configure()
                .Database(SQLiteConfiguration.Standard.InMemory)//UsingFile("firstProject.db")
            .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Mappings.UserMap>())
             .ExposeConfiguration(BuildSchema)
            .BuildSessionFactory();
        }
        private static void BuildSchema(Configuration config)
        {
            new SchemaExport(config)
                .Create(false, true);
            //// delete the existing db on each run
            //if (File.Exists("temp"))
            //    File.Delete("temp");

            //// this NHibernate tool takes a configuration (with mapping info in)
            //// and exports a database schema from it
            //new SchemaExport(config)
            //  .Create(false, true);
        }
    }
}
