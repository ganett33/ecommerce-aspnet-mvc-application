using Microsoft.EntityFrameworkCore;

namespace eTickets.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContext<AppDbContext> options) : base(options) 
        {
        }
    }
}
