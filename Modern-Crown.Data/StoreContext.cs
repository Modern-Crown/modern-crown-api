using Modern.Crown.Domain.Catalog;
using Microsoft.EntityFrameworkCore;

namespace Modern_Crown.Data;
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        { }

        public Db<Item> Items { get; set; }
    }
}