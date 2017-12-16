using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShamirasRestaurant.Domain.Infrastructure
{
   public class DataAccess : DbContext
    {
        public DataAccess(): base("myConnectionString")
        {
            Database.SetInitializer(
                new ShamirasRestaurant.Domain.Infrastructure.DataInitializer()
            );
        }

        public DbSet<Models.User> Users { get; set; }
    }
}
