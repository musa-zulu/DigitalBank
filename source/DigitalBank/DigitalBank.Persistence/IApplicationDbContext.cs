using Microsoft.EntityFrameworkCore;
using DigitalBank.Domain.Entities;
using System.Threading.Tasks;

namespace DigitalBank.Persistence
{
    public interface IApplicationDbContext
    {
        DbSet<Customer> Customers { get; set; }
        Task<int> SaveChangesAsync();
    }
}
