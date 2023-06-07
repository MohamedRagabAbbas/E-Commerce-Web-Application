using Microsoft.EntityFrameworkCore;

namespace E_CommerceWebApplication.Server.Data
{
    public class DBContextClass:DbContext
    {
        public DBContextClass(DbContextOptions<DBContextClass> options) : base(options)
        {

        }
        
    }
}
