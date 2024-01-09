using System.Text.Json.Serialization;
using DungeonAndDragons.Core.Enums;

namespace DungeonAndDragons.Core.Models;

/// <summary>
/// Лог боя
/// </summary>
public class BattleLog
{
    /// <summary>
    /// Конструктор
    /// </summary>
    public BattleLog(int attackPerRound)
    {
        DiceRoll = new int[attackPerRound];
        Damage = new int[attackPerRound];
        Hit = new Hits[attackPerRound];
        EnemyHp = new int[attackPerRound];
    }
    
    [JsonConstructor]
    public BattleLog(){}
    
    /// <summary>
    /// Имя атакующего
    /// </summary>
    public string ParticipantName { get; set; } = default!;
    
    /// <summary>
    /// Имя противника
    /// </summary>
    public string EnemyName { get; set; } = default!;
    
    /// <summary>
    /// Модификатор атаки
    /// </summary>
    public int AttackModifier { get; set; }

    /// <summary>
    /// Бросок кубиков
    /// </summary>
    public int[] DiceRoll { get; set; }
    
    /// <summary>
    /// Урон
    /// </summary>
    public int[] Damage { get; set; }
    
    /// <summary>
    /// Удар
    /// </summary>
    public Hits[] Hit { get; set; }
    
    /// <summary>
    /// Здоровье противника
    /// </summary>
    public int[] EnemyHp { get; set; }
}