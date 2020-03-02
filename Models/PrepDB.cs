using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace CoreRest.Models
{
    public static class PrepDB
    {
        public static void PrepPopulation(IApplicationBuilder application)
        {
            using (var serviceScope = application.ApplicationServices.CreateScope())
            {
                CustomerContext c = serviceScope.ServiceProvider.GetService<CustomerContext>();
                PrepDB.SeedData(c);
            }
        }

        public static void SeedData(CustomerContext context)
        {
            System.Console.WriteLine("Applying migrations! ...");

            context.Database.Migrate();

            // do we have data?
            if (!context.CustomerItems.Any())
            {
                System.Console.WriteLine("Adding data! seeding ..");
                context.CustomerItems.AddRange(
                    new Customer() { Name = "Lernia" },
                    new Customer() { Name = "Kone" },
                    new Customer() { Name = "DHL" },
                    new Customer() { Name = "Bonnier" }
                );
            }
            else
            {
                System.Console.WriteLine("Already have data - not seeding data!");
            }
        }
    }
}