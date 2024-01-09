using DungeonAndDragons.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace DungeonAndDragons.Core.Extensions;

public static class ModelBuilderExtensions
{
    /// <summary>
    /// Конфигурация моделей при запуске
    /// </summary>
    /// <param name="modelBuilder">ModelBuilder</param>
    public static void Seed(this ModelBuilder modelBuilder)
    {
       modelBuilder.CreateEnemies();
    }

    #region Private

    private static void CreateEnemies(this ModelBuilder modelBuilder)
    {
        var avi = new Enemy
        {
            Id = 1,
            Name = "Ави",
            HitPoints = 220,
            AttackModifier = 18,
            AttackPerRound = 2,
            Damage = "10d8",
            DamageModifier = 5,
            ArmorClass = 24
        };

        var allozawr = new Enemy
        {
            Id = 2,
            Name = "Аллозавр",
            HitPoints = 300,
            AttackModifier = 144,
            AttackPerRound = 1,
            Damage = "24d12",
            DamageModifier = 7,
            ArmorClass = 50
        };

        var bulezau = new Enemy
        {
            Id = 3,
            Name = "Булезау",
            HitPoints = 120,
            AttackModifier = 70,
            AttackPerRound = 1,
            Damage = "10d8",
            DamageModifier = 3,
            ArmorClass = 111
        };

        var voron = new Enemy
        {
            Id = 4,
            Name = "Ворон",
            HitPoints = 5,
            AttackModifier = 12,
            AttackPerRound = 1,
            Damage = "24d12",
            DamageModifier = -2,
            ArmorClass = 9
        };
        
        var vasilisk = new Enemy
        {
            Id = 5,
            Name = "Василиск",
            HitPoints = 100,
            AttackModifier = 0,
            AttackPerRound = 3,
            Damage = "9d8",
            DamageModifier = -2,
            ArmorClass = 50
        };

        modelBuilder.Entity<Enemy>().HasData(avi, allozawr, bulezau, voron, vasilisk);
    }

    #endregion
}