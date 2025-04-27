using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RO.DevTest.Domain.Entities;

namespace RO.DevTest.Persistence;

public class DefaultContext : IdentityDbContext<User> {

    public DefaultContext() { }

    public DefaultContext(DbContextOptions<DefaultContext> options) : base(options) {
        public DbSet<Product> Products => Set<Product>();
        public DbSet<Client> Clients => Set<Client>();
        public DbSet<Sale> Sales => Set<Sale>();
    }

    protected override void OnModelCreating(ModelBuilder builder) {
        builder.HasPostgresExtension("uuid-ossp");
        builder.ApplyConfigurationsFromAssembly(typeof(DefaultContext).Assembly);

        base.OnModelCreating(builder);
    }
}