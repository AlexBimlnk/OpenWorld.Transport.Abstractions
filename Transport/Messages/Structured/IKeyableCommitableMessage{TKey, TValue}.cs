namespace OpenWorld.Transport.Abstractions.Messages.Structured;

/// <summary>
/// Описывает подтверждаемое сообщение с ключом.
/// </summary>
/// <typeparam name="TKey">
/// Тип ключа сообщения.
/// </typeparam>
/// <typeparam name="TValue">
/// Тип тела сообщения.
/// </typeparam>
public interface IKeyableCommitableMessage<TKey, TValue> :
    IKeyableReceivedMessage<TKey, TValue>,
    ICommitableMessage<TValue>
    where TKey : IEquatable<TKey>
{
}