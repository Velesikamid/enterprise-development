namespace Hotel.Domain.Entities;

/// <summary>
/// Номер
/// </summary>
public class Room
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    public required int Id { get; set; }

    /// <summary>
    /// Номер комнаты
    /// </summary>
    public required int Number { get; set; }

    /// <summary>
    /// Этаж комнаты
    /// </summary>
    public required int Floor { get; set; }

    /// <summary>
    /// Наличие балкона
    /// </summary>
    public required bool HasBalcony { get; set; }

    /// <summary>
    /// Тип комнаты
    /// </summary>
    public required RoomType Type { get; set; }
}
