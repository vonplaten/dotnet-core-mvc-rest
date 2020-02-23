using Microsoft.EntityFrameworkCore;

namespace CoreRest.Models
{
    public class CustomerContext : DbContext {

        public CustomerContext(DbContextOptions<CustomerContext> options) :base (options){

        }

        public DbSet<Customer> CustomerItems {get; set;}
    }
}