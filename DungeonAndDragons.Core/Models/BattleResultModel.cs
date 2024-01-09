using DungeonAndDragons.Core.Entities;
using DungeonAndDragons.Core.Enums;

namespace DungeonAndDragons.Core.Models;

/// <summary>
/// Модель результата боя
/// </summary>
public class BattleResultModel
{
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="winner">Победитель</param>
    /// <param name="logs">Логи боя</param>
    public BattleResultModel(
        Participants winner,
        List<BattleLog> logs)
    {
        Winner = winner;
        Logs = logs;
    }
    
    /// <summary>
    /// Победитель
    /// </summary>
    public Participants Winner { get; set; }

    /// <summary>
    /// Логи боя
    /// </summary>
    public List<BattleLog> Logs { get; set; }

    /// <summary>
    /// Игрок
    /// </summary>
    public Player? Player { get; set; }

    /// <summary>
    /// Противник
    /// </summary>
    public Enemy? Enemy { get; set; }
}