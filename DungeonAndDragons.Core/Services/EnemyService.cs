using DungeonAndDragons.Core.Abstractions;
using DungeonAndDragons.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace DungeonAndDragons.Core.Services;

/// <inheritdoc />
public class EnemyService: IEnemyService
{
    private readonly IDbContext _dbContext;

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="dbContext">Контекст БД</param>
    public EnemyService(IDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    /// <inheritdoc />
    public async Task<Enemy> GetRandomEnemyAsync(CancellationToken cancellationToken)
    {
        var enemiesCount = await _dbContext.Enemies.CountAsync(cancellationToken);
        var randomId = new Random().Next(enemiesCount);
        var enemy = await _dbContext.Enemies.FirstOrDefaultAsync(
            x => x.Id - 1 == randomId,
            cancellationToken)
            ?? throw new Exception("Противник не должен быть null");
        
        return enemy;
    }
}