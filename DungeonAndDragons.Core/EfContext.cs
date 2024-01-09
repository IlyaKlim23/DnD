using DungeonAndDragons.Core.Abstractions;
using DungeonAndDragons.Core.Entities;
using DungeonAndDragons.Core.Extensions;
using Microsoft.EntityFrameworkCore;

namespace DungeonAndDragons.Core;

/// <summary>
/// Контекст БД
/// </summary>
public sealed class EfContext: DbContext, IDbContext
{
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="options">DbContextOptions</param>
    public EfContext(DbContextOptions options) : base(options)
    {
        Database.EnsureCreated();
    }
    
    /// <inheritdoc />
    public DbSet<Enemy> Enemies { get; set; } = null!;
    
    /// <inheritdoc />
    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default) =>
        await SaveChangesAsync(true, cancellationToken);
    
    /// <summary>
    /// Добавление моделей при запуске
    /// </summary>
    /// <param name="modelBuilder">ModelBuilder</param>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Seed();
    }
}