using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ASP.NETMVC5withLambdaExpressions.Models;

namespace ASP.NETMVC5withLambdaExpressions.Context
{
    public class BookContext :DbContext
    {
        public DbSet<Book> Books { get; set; }
    }
}