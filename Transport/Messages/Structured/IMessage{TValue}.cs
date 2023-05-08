namespace OpenWorld.Transport.Abstractions.Messages.Structured;

/// <summary>
/// Описывает сообщение, используемое конечным транспортом.
/// </summary>
/// <typeparam name="TValue">
/// Тип тела сообщения.
/// </typeparam>
public interface IMessage<TValue>
{
    /// <summary>
    /// Тело сообщения.
    /// </summary>
    public TValue Value { get; }
}