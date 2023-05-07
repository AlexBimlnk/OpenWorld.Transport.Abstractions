namespace OpenWorld.Transport.Abstractions.Messages.Raw;

/// <summary>
/// Описывает исходное сообщение, используемое инфраструктурным транспортом.
/// </summary>
/// <typeparam name="TValue">
/// Тип тела сообщения.
/// </typeparam>
public interface IRawMessage<TValue>
{
    /// <summary>
    /// Тело сообщения.
    /// </summary>
    public TValue Value { get; }
}