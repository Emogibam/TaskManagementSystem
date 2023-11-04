using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementSystem.Infrastruture.Context
{
    public class ReadWriteContext : AppDbContext
    {
        public ReadWriteContext(): base("ReadWriteContext")
        {

        }
    }
}
