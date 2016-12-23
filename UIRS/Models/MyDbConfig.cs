using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace UIRS.Models
{
    public class MyDbConfig : DbConfiguration 
    {
        public MyDbConfig()
        {
            SqlConnectionFactory defaultFactory =
                new SqlConnectionFactory("Server=localhost; User Id = postgres; Password = admin;");

            this.SetDefaultConnectionFactory(defaultFactory);
        }
    }
}