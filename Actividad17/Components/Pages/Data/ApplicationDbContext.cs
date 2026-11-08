using Microsoft.EntityFrameworkCore;
using Actividad17.Models;

namespace Actividad17.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Estudiante> Estudiantes { get; set; } = null!;
}