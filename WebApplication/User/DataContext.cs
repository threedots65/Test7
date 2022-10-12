using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DataContext : IDataContext
    {
        public DataContext()
        {
            this.UserContext = new UserEntityContext();
        }
      
        public IEntityContext<User> UserContext { get ; }
        
    }
}
