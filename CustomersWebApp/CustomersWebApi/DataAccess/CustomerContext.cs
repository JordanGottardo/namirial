using CustomersWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomersWebApi.DataAccess;

public class CustomerContext : DbContext
{
    public CustomerContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Customer> Customers { get; set; }
}