using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class UserDatabaseSettings
    {
        public string DatabaseName { get; set; } = null!;
        public string UserCollection { get; set; } = null!;
        public string ConnectionString { get; set; } = null!;
    }
}
