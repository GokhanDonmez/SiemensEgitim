using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilcanX.Class.OTHER
{
    public class Connection
    {
        public static string ConnectionString { get; set; } = @"Data Source=.;Initial Catalog=Northwind;Uid=sa;Pwd=123;Trust Server Certificate=true";
    }
}
