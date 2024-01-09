using DungeonAndDragons.Core.Models;

namespace DungeonAndDragons.Core.Abstractions;

/// <summary>
/// Сервис для работы боя
/// </summary>
public interface IBattleService
{
    /// <summary>
    /// Получить результат боя
    /// </summary>
    /// <returns>Модель результата боя</returns>
    public BattleResultModel GetBattleResult(
        IEntity firstEntity,
        IEntity secondEntity);
}