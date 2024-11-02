using Microsoft.EntityFrameworkCore;

public class VisitasDbContext : DbContext{

    public DbSet<Visitas> Visitas { get; set; } = null;

    public VisitasDbContext(DbContextOptions<VisitasDbContext> options) : base(options) {} 
}