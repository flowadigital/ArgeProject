using ArgeProject.Domain.Entities;
using FlowNetFramework.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace ArgeProject.Persistence.Data
{
    public class ArgeDbContext : BaseDbContext
    {
        public ArgeDbContext(DbContextOptions options, IHttpContextAccessor httpContextAccessor) : base(options, httpContextAccessor)
        {
        }

        public DbSet<TempTable> TempTable { get; set; }
    }
}
