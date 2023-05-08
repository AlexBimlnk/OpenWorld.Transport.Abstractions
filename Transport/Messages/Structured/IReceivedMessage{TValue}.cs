namespace OpenWorld.Transport.Abstractions.Messages.Structured;

/// <summary>
/// Описывает полученное сообщение, обогащенное информацией об источнике.
/// </summary>
/// <typeparam name="TValue">
/// Тип тела сообщения.
/// </typeparam>
public interface IReceivedMessage<TValue> : IMessage<TValue>
{
    /// <summary>
    /// Источник сообщения.
    /// </summary>
    public string Source { get; }
}