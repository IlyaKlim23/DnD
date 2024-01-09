using DungeonAndDragons.Core.Abstractions;
using DungeonAndDragons.Core.Enums;
using DungeonAndDragons.Core.Managers;
using DungeonAndDragons.Core.Models;

namespace DungeonAndDragons.Core.Services;

/// <inheritdoc />
public class BattleService: IBattleService
{
    /// <inheritdoc />
    public BattleResultModel GetBattleResult(
        IEntity firstEntity,
        IEntity secondEntity)
    {
        BattleLogger.RemoveAll();
        
        while (firstEntity.HitPoints > 0 && secondEntity.HitPoints > 0)
        {
            if (firstEntity.HitPoints > 0) 
                StartRound(firstEntity, secondEntity);
            if (secondEntity.HitPoints > 0)
                StartRound(secondEntity, firstEntity);
        }

        var result = new BattleResultModel(
            winner: firstEntity.HitPoints > 0 
                ? firstEntity.GetParticipant() 
                : secondEntity.GetParticipant() ,
            logs: BattleLogger.GetLogs());
        
        return result;
    }

    private void StartRound(
        IEntity firstEntity,
        IEntity secondEntity)
    {
        var log = GetRoundResult(firstEntity, secondEntity);
        log.ParticipantName = firstEntity.Name;
        log.EnemyName = secondEntity.Name;
        BattleLogger.AddLog(log);
    }
    
    private BattleLog GetRoundResult(
        IEntity firstEntity,
        IEntity secondEntity)
    {
        var log = new BattleLog(firstEntity.AttackPerRound);
        var replays = int.Parse(firstEntity.Damage.Split('d')[0]);
        var damage = int.Parse(firstEntity.Damage.Split('d')[1]);
        log.AttackModifier = firstEntity.AttackModifier;
        for (var i = 0; i < firstEntity.AttackPerRound && secondEntity.HitPoints > 0; i++)
        {
            var resultOfAttack = DoAttack(
                log,
                firstEntity,
                secondEntity,
                i,
                replays,
                damage);
            
            if (resultOfAttack == 0)
                break;
        }

        return log;
    }

    private int DoAttack(
        BattleLog log, 
        IEntity firstEntity,
        IEntity secondEntity,
        int numberOfAttack,
        int replays,
        int damage)
    {
        var hitRoll = new Random().Next(1, 21);
        log.DiceRoll[numberOfAttack] = hitRoll;
        log.EnemyHp[numberOfAttack] = secondEntity.HitPoints;
        if (hitRoll == 1 || log.DiceRoll[numberOfAttack] < secondEntity.ArmorClass)
        {
            log.Hit[numberOfAttack] = Hits.CriticalMiss;
            return -1;
        }

        if (hitRoll == 20)
            log.Hit[numberOfAttack] = Hits.CriticalHit;
        else log.Hit[numberOfAttack] = Hits.Hit;
        for (var j = 0; j < replays; j++)
            log.Damage[numberOfAttack] += (new Random().Next(1, damage + 1) + firstEntity.DamageModifier) * hitRoll / 10;
        secondEntity.HitPoints -= Math.Min(secondEntity.HitPoints, log.Damage[numberOfAttack]);
        log.EnemyHp[numberOfAttack] = secondEntity.HitPoints;

        return secondEntity.HitPoints;
    }
}