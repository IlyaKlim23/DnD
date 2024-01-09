using DungeonAndDragons.Core.Abstractions;
using DungeonAndDragons.Core.Entities;
using DungeonAndDragons.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace DungeonAndDragons.Core.Controllers;

/// <summary>
/// Контроллер боя
/// </summary>
[ApiController]
[Route("[controller]")]
public class BattleController: Controller
{
    private readonly IBattleService _battleService;
    private readonly IEnemyService _enemyService;
    private readonly CancellationToken _cancellationToken;

    /// <summary>
    /// Контроллер
    /// </summary>
    /// <param name="battleService">Сервис для работы боя</param>
    /// <param name="enemyService">Сервис для работы с противниками</param>
    public BattleController(IBattleService battleService, IEnemyService enemyService)
    {
        _battleService = battleService;
        _enemyService = enemyService;
        _cancellationToken = new CancellationToken();
    }
    
    /// <summary>
    /// Получить результат боя
    /// </summary>
    /// <param name="player">Игрок</param>
    /// <returns>Результат боя</returns>
    [HttpPost]
    [Route("getBattleResult")]
    public async Task<BattleResultModel> GetBattleResult(Player player)
    {
        var enemy = await _enemyService.GetRandomEnemyAsync(_cancellationToken);
        var result = _battleService.GetBattleResult(player, enemy);
        result.Enemy = enemy;
        result.Player = player;

        return result;
    }
}