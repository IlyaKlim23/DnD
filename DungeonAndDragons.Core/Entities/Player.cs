using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using DungeonAndDragons.Core.Abstractions;
using DungeonAndDragons.Core.Enums;

namespace DungeonAndDragons.Core.Entities;

/// <summary>
/// Игрок
/// </summary>
public class Player: IEntity
{
    private Participants Participant => Participants.User;
    
    /// <inheritdoc />
    [Required]
    [MaxLength(20, ErrorMessage = "Длина не должна превышать 20 символов")]
    [DisplayName("Имя")]
    public string Name { get; set; }
    
    /// <inheritdoc />
    [Required]
    [Range(0, 1000, ErrorMessage = "Должно быть в диапазоне от 0 до 1000")]
    [DisplayName("Здоровье")]
    public int HitPoints { get; set; }
    
    /// <inheritdoc />
    [Required]
    [Range(-5, 5, ErrorMessage = "Должно быть в диапазоне от -5 до 5")]
    [DisplayName("Модификатор атаки")]
    public int AttackModifier { get; set; }
    
    /// <inheritdoc />
    [Required]
    [Range(1, 5, ErrorMessage = "Должно быть в диапазоне от 1 до 5")]
    [DisplayName("Кол-во атак за раунд")]
    public int AttackPerRound { get; set; }
    
    /// <inheritdoc />
    [Required]
    [RegularExpression(@"\d+d\d+", ErrorMessage = "Неверный формат")]
    [DisplayName("Урон (кол-во бросков)d(максимальный урон)")]
    public string Damage { get; set; }
    
    /// <inheritdoc />
    [Required]
    [Range(-5, 5, ErrorMessage = "Должно быть в диапазоне от -5 до 5")]
    [DisplayName("Модификатор урона")]
    public int DamageModifier { get; set; }
    
    /// <inheritdoc />
    [Required]
    [Range(1, 1000, ErrorMessage = "Должно быть в диапазоне от 0 до 1000")]
    [DisplayName("Броня")]
    public int ArmorClass { get; set; }
    
    public Participants GetParticipant() => Participant;
}