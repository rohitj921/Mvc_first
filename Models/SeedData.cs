using Microsoft.EntityFrameworkCore;
using MVC_First.Data;

namespace MVC_First.Models
{
    public class SeedData
    {
        public static void Seed(IServiceProvider serviceProvider)
        {
            using (var context = new MVC_FirstContext(serviceProvider.GetRequiredService<DbContextOptions<MVC_FirstContext>>()))
            {
                
                if (context.Employee.Any())
                {
                    return; 
                }

                context.Employee.AddRange(
                    new Employee { id = 1, name = "John Doe", age = 30, dob = new DateTime(1994, 5, 21), city = "New York" },
                    new Employee { id = 2, name = "Alice Johnson", age = 28, dob = new DateTime(1996, 8, 10), city = "Los Angeles" },
                    new Employee { id = 3, name = "Bob Smith", age = 35, dob = new DateTime(1989, 11, 15), city = "Chicago" },
                    new Employee { id = 4, name = "Emma Davis", age = 32, dob = new DateTime(1992, 3, 5), city = "Houston" },
                    new Employee { id = 5, name = "Michael Brown", age = 40, dob = new DateTime(1984, 7, 30), city = "San Francisco" }
                );

                context.SaveChanges();
            }
        }
    }
}
