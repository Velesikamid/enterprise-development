namespace Hotel.Domain.Entities;

/// <summary>
/// Клиенты
/// </summary>
public class Client
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    public required int Id { get; set; }

    /// <summary>
    /// Номер паспорта
    /// </summary>
    public required string PassportNumber { get; set; }

    /// <summary>
    /// Фамилия
    /// </summary>
    public required string LastName { get; set; }

    /// <summary>
    /// Имя
    /// </summary>
    public required string FirstName { get; set; }

    /// <summary>
    /// Отчество
    /// </summary>
    public string? Patronymic { get; set; }

    /// <summary>
    /// Дата рождения
    /// </summary>
    public required DateTime BirthDate { get; set; }

    /// <summary>
    /// Гражданство
    /// </summary>
    public required string Citizenship { get; set; }
}
