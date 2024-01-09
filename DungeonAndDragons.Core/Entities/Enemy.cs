using System.ComponentModel.DataAnnotations;
using DungeonAndDragons.Core.Abstractions;
using DungeonAndDragons.Core.Enums;

namespace DungeonAndDragons.Core.Entities;

/// <summary>
/// Противник
/// </summary>
public class Enemy: IDbEntity, IEntity
{
    private Participants Participant => Participants.Enemy;
    
    /// <inheritdoc />
    [Key]
    public int Id { get; set; }
    
    /// <inheritdoc />
    public string Name { get; set; }
    
    /// <inheritdoc />
    public int HitPoints { get; set; }
    
    /// <inheritdoc />
    public int AttackModifier { get; set; }
    
    /// <inheritdoc />
    public int AttackPerRound { get; set; }
    
    /// <inheritdoc />
    public string Damage { get; set; }
    
    /// <inheritdoc />
    public int DamageModifier { get; set; }
    
    /// <inheritdoc />
    public int ArmorClass { get; set; }

    public Participants GetParticipant() => Participant;
}