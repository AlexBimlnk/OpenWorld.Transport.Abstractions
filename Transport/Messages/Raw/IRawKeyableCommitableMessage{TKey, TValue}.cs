namespace OpenWorld.Transport.Abstractions.Messages.Raw;

/// <summary>
/// Описывает подтверждаемое исходное сообщение с ключом.
/// </summary>
/// <typeparam name="TKey">
/// Тип ключа сообщения.
/// </typeparam>
/// <typeparam name="TValue">
/// Тип тела сообщения.
/// </typeparam>
public interface IRawKeyableCommitableMessage<TKey, TValue> :
    IRawKeyableReceivedMessage<TKey, TValue>,
    IRawCommitableMessage<TValue>
{
}