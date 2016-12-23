using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace UIRS.Models
{
    [DbConfigurationType(typeof(Devart.Data.PostgreSql.Entity.PgSqlEntityProviderServicesConfiguration))]
    //[DbConfigurationType(typeof(MyDbConfig))]
    public class ObrashenieContext : DbContext
    {
        public ObrashenieContext() : base() { }
        public ObrashenieContext(string dbNameOrConnection) : base(dbNameOrConnection) {}
        //"Server=127.0.0.1;User Id=postgres;Password=admin;Database=ForUsers;"
        public DbSet<Obrashenie> Obrashenie { get; set; }
    }
}