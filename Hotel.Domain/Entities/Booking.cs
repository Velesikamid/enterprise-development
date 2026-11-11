namespace Hotel.Domain.Entities;

/// <summary>
/// Бронирование номера
/// </summary>
public class Booking
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    public required int Id { get; set; }

    /// <summary>
    /// Дата заезда
    /// </summary>
    public required DateTime ArrivalDate { get; set; }

    /// <summary>
    /// Количество суток проживания
    /// </summary>
    public required int DayNumber { get; set; }

    /// <summary>
    /// Клиент
    /// </summary>
    public required Client Client { get; set; }

    /// <summary>
    /// Номер
    /// </summary>
    public required Room Room { get; set; }
}
