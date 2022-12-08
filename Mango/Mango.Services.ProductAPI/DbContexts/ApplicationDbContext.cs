using Mango.Services.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Mango.Services.ProductAPI.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductID = 1,
                ProductName = "Samosa",
                ProductPrice = 15,
                ProductDescription = "Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.",
                ProductImgURL = "https://mangoweb.blob.core.windows.net/mango/11.jpg",
                ProductCategory = "Appetizer"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductID = 2,
                ProductName = "Paneer Tikka",
                ProductPrice = 13.99,
                ProductDescription = "Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.",
                ProductImgURL = "https://mangoweb.blob.core.windows.net/mango/12.jpg",
                ProductCategory = "Appetizer"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductID = 3,
                ProductName = "Sweet Pie",
                ProductPrice = 10.99,
                ProductDescription = "Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.",
                ProductImgURL = "https://mangoweb.blob.core.windows.net/mango/13.jpg",
                ProductCategory = "Dessert"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductID = 4,
                ProductName = "Pav Bhaji",
                ProductPrice = 15,
                ProductDescription = "Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.",
                ProductImgURL = "https://mangoweb.blob.core.windows.net/mango/14.jpg",
                ProductCategory = "Entree"
            });
        }
    }
}
