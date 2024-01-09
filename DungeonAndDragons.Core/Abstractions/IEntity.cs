using DungeonAndDragons.Core.Enums;

namespace DungeonAndDragons.Core.Abstractions;

/// <summary>
/// Сущность
/// </summary>
public interface IEntity
{
    /// <summary>
    /// Имя
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Здоровье
    /// </summary>
    public int HitPoints { get; set; }
    
    /// <summary>
    /// Модификатор атаки
    /// </summary>
    public int AttackModifier { get; set; }
    
    /// <summary>
    /// Кол-во атак за раунд
    /// </summary>
    public int AttackPerRound { get; set; }
    
    /// <summary>
    /// Урон (кол-во бросков)d(максимальный урон)
    /// </summary>
    public string Damage { get; set; }
    
    /// <summary>
    /// Модификатор урона
    /// </summary>
    public int DamageModifier { get; set; }
    
    /// <summary>
    /// Броня
    /// </summary>
    public int ArmorClass { get; set; }

    /// <summary>
    /// Получить наименование участника боя
    /// </summary>
    public Participants GetParticipant();
}