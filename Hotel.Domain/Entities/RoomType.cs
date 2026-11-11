using Hotel.Domain.Enums;

namespace Hotel.Domain.Entities;

/// <summary>
/// Тип номера
/// </summary>
public class RoomType
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    public required int Id { get; set; }

    /// <summary>
    /// Категория номера
    /// </summary>
    public required RoomCategory Category { get; set; }

    /// <summary>
    /// Площадь
    /// </summary>
    public required int Square { get; set; }

    /// <summary>
    /// Количество кроватей
    /// </summary>
    public required int BedNumber { get; set; }

    /// <summary>
    /// Наличие ванны/душа
    /// </summary>
    public required bool HasBathroom { get; set; }

    /// <summary>
    /// Цена комнаты за сутки проживания
    /// </summary>
    public required int Price { get; set; }
}