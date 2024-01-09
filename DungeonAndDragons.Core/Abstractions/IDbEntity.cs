namespace DungeonAndDragons.Core.Abstractions;

/// <summary>
/// Сущность БД
/// </summary>
public interface IDbEntity
{
    /// <summary>
    /// Идентификатор сущности
    /// </summary>
    public int Id { get; set; }
}