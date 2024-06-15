using Microsoft.EntityFrameworkCore;

namespace PrimerApi.Data;

public class ContextDb : DbContext
{
    public ContextDb(DbContextOptions<ContextDb> options) : base(options) { }

    //public DbSet<Tipo> Tipos { get; set; }

}