using DungeonAndDragons.Core.Models;

namespace DungeonAndDragons.Core.Managers;

/// <summary>
/// Логгер боя
/// </summary>
public static class BattleLogger
{
    private static List<BattleLog> _logs = new ();
    
    /// <summary>
    /// Добавить лог
    /// </summary>
    /// <param name="battleLog">Лог боя</param>
    public static void AddLog(BattleLog battleLog)
        => _logs.Add(battleLog);


    /// <summary>
    /// Добавить логи
    /// </summary>
    /// <param name="battleLogs">Лог боя</param>
    public static void AddLogs(params BattleLog[] battleLogs)
        => _logs.AddRange(battleLogs);

    /// <summary>
    /// Получить логи
    /// </summary>
    /// <returns></returns>
    public static List<BattleLog> GetLogs()
        => _logs;

    /// <summary>
    /// Удалить логи
    /// </summary>
    public static void RemoveAll()
        => _logs.Clear();
}