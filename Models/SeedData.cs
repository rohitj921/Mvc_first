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
                    new Employee
                    {
                        Name = "Rohit Sharma",
                        Age = 30,
                        Dob = new DateTime(1994, 1, 10),
                        Email = "rohit@example.com",
                        Phone = "9876543210",
                        Gender = "Male",
                        City = "Mumbai"
                    },
                    new Employee
                    {

                        Name = "Priya Mehta",
                        Age = 26,
                        Dob = new DateTime(1998, 5, 22),
                        Email = "priya@example.com",
                        Phone = "9123456789",
                        Gender = "Female",
                        City = "Delhi"
                    },
                    new Employee
                    {
                        Name = "Aman Verma",
                        Age = 28,
                        Dob = new DateTime(1996, 3, 15),
                        Email = "aman@example.com",
                        Phone = "9988776655",
                        Gender = "Male",
                        City = "Bangalore"
                    },
                    new Employee
                    {
                        Name = "Sneha Iyer",
                        Age = 24,
                        Dob = new DateTime(2000, 9, 5),
                        Email = "sneha@example.com",
                        Phone = "9001234567",
                        Gender = "Female",
                        City = "Chennai"
                    },
                    new Employee
                    {
                        Name = "Arjun Singh",
                        Age = 32,
                        Dob = new DateTime(1992, 11, 20),
                        Email = "arjun@example.com",
                        Phone = "9811122233",
                        Gender = "Male",
                        City = "Lucknow"
                    },
                    new Employee
                    {
                        Name = "Neha Kapoor",
                        Age = 27,
                        Dob = new DateTime(1997, 7, 8),
                        Email = "neha@example.com",
                        Phone = "9022334455",
                        Gender = "Female",
                        City = "Pune"
                    },
                    new Employee
                    {
                        Name = "Kunal Joshi",
                        Age = 29,
                        Dob = new DateTime(1995, 12, 2),
                        Email = "kunal@example.com",
                        Phone = "9090909090",
                        Gender = "Male",
                        City = "Ahmedabad"
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
