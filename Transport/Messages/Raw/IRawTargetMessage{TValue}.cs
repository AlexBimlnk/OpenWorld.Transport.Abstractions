namespace OpenWorld.Transport.Abstractions.Messages.Raw;

/// <summary>
/// Описывает исходное сообщение, обогащенное информацией о месте назначения.
/// </summary>
/// <typeparam name="TValue">
/// Тип тела сообщения.
/// </typeparam>
public interface IRawTargetMessage<TValue> : IRawMessage<TValue>
{
    /// <summary>
    /// Место назначения.
    /// </summary>
    public string Destination { get; }
}