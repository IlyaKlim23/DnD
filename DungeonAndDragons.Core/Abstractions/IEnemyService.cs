using DungeonAndDragons.Core.Entities;

namespace DungeonAndDragons.Core.Abstractions;

/// <summary>
/// Сервис для работы с противниками
/// </summary>
public interface IEnemyService
{
    /// <summary>
    /// Получить случайного противника
    /// </summary>
    /// <returns>Случайный противник</returns>
    public Task<Enemy> GetRandomEnemyAsync(CancellationToken cancellationToken);
}