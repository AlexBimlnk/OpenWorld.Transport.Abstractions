namespace OpenWorld.Transport.Abstractions.Messages.Raw;

/// <summary>
/// Описывает полученное исходное сообщение, обогащенное информацией об источнике.
/// </summary>
/// <typeparam name="TValue">
/// Тип тела сообщения.
/// </typeparam>
public interface IRawReceivedMessage<TValue> : IRawMessage<TValue>
{
    /// <summary>
    /// Источник сообщения.
    /// </summary>
    public string Source { get; }
}