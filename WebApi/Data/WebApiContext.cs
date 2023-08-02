using Microsoft.EntityFrameworkCore;
using WebApi.Models;

namespace WebApi.Data
{
    public class WebApiContext : DbContext
    {
        public WebApiContext(DbContextOptions<WebApiContext> options)
            : base(options)
        {
        }

        public DbSet<WebApi.Models.Emplr> Emplr { get; set; } = default!;

        public DbSet<WebApi.Models.Whs> Whs { get; set; } = default!;

        public DbSet<WebApi.Models.Unit> Unit { get; set; } = default!;

        public DbSet<WebApi.Models.Proj> Proj { get; set; } = default!;

        public DbSet<WebApi.Models.Department> Department { get; set; } = default!;

        public DbSet<WebApi.Models.Coor> Coor { get; set; } = default!;

        public DbSet<WebApi.Models.Corp> Corp { get; set; } = default!;

        public DbSet<WebApi.Models.Accbook> Accbook { get; set; } = default!;

        public DbSet<WebApi.Models.Acchart> Acchart { get; set; } = default!;

        public DbSet<WebApi.Models.RefType> RefType { get; set; } = default!;

        public DbSet<WebApi.Models.Book> Book { get; set; } = default!;

        public DbSet<WebApi.Models.Branch> Branch { get; set; } = default!;

        public DbSet<WebApi.Models.Job> Job { get; set; } = default!;

        public DbSet<WebApi.Models.ProductType> ProductType { get; set; } = default!;

        public DbSet<WebApi.Models.Product> Product { get; set; } = default!;
    }
}
