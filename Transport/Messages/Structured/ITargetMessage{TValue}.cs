namespace OpenWorld.Transport.Abstractions.Messages.Structured;

/// <summary>
/// Описывает сообщение, обогащенное информацией о месте назначения.
/// </summary>
/// <typeparam name="TValue">
/// Тип тела сообщения.
/// </typeparam>
public interface ITargetMessage<TValue> : IMessage<TValue>
{
    /// <summary>
    /// Место назначения.
    /// </summary>
    public string Destination { get; }
}