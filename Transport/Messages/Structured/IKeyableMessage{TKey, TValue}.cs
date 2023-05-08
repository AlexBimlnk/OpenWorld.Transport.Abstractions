namespace OpenWorld.Transport.Abstractions.Messages.Structured;

/// <summary>
/// Описывает сообщение с ключом, используемое конечным транспортом.
/// </summary>
/// <typeparam name="TKey">
/// Тип ключа сообщения.
/// </typeparam>
/// <typeparam name="TValue">
/// Тип тела сообщения.
/// </typeparam>
public interface IKeyableMessage<TKey, TValue> : IMessage<TValue>
    where TKey : IEquatable<TKey>
{
    /// <summary>
    /// Ключ сообщения.
    /// </summary>
    public TKey Key { get; }
}