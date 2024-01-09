using DungeonAndDragons.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace DungeonAndDragons.Core.Abstractions;

/// <summary>
/// Контекст БД
/// </summary>
public interface IDbContext
{
    /// <summary>
    /// Противники
    /// </summary>
    DbSet<Enemy> Enemies { get; set; }
    
    /// <summary>
    /// Сохранить изменения в БД
    /// </summary>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Количество обновленных записей</returns>
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}